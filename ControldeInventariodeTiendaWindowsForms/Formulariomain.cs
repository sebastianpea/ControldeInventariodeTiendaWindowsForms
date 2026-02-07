using System;
using System.Linq;
using System.Windows.Forms;

namespace ControldeInventariodeTiendaWindowsForms
{
    public partial class MainForm : Form
    {
        private bool esAdministrador;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Mostrar usuario actual y configurar permisos
            var usuario = SistemaBasedeDatos.Instancia.UsuarioActual;
            if (usuario != null)
            {
                esAdministrador = usuario is EmpleadoAdministrador;
                lblUsuarioActual.Text = $"Usuario: {usuario.Nombre} ({usuario.IdEmpleado}) - {(esAdministrador ? "Administrador" : "Empleado")}";

                // Configurar permisos visuales
                ConfigurarPermisos();
            }

            // Cargar productos iniciales
            CargarProductos();
        }

        private void ConfigurarPermisos()
        {
            if (esAdministrador)
            {
                // Administrador: acceso completo
                btnAgregarProducto.Enabled = true;
                btnEliminarProducto.Enabled = true;
                btnGestionarUsuarios.Visible = true;

                // Campos de producto habilitados
                txtId.Enabled = true;
                txtNombre.Enabled = true;
                txtPrecio.Enabled = true;
                txtStockActual.Enabled = true;
                txtStockMinimo.Enabled = true;
                txtMarca.Enabled = true;
                cmbTipoProducto.Enabled = true;
                txtAtributoExtra.Enabled = true;
            }
            else
            {
                // Empleado: solo modificar stock
                btnAgregarProducto.Enabled = false;
                btnEliminarProducto.Enabled = false;
                btnGestionarUsuarios.Visible = false;

                // Campos de producto deshabilitados
                txtId.Enabled = false;
                txtNombre.Enabled = false;
                txtPrecio.Enabled = false;
                txtStockActual.Enabled = false;
                txtStockMinimo.Enabled = false;
                txtMarca.Enabled = false;
                cmbTipoProducto.Enabled = false;
                txtAtributoExtra.Enabled = false;

                // Solo puede modificar stock
                groupBoxStock.Enabled = true;
            }
        }

        private void CargarProductos()
        {
            lstProductos.Items.Clear();
            var productos = SistemaBasedeDatos.Instancia.Productos;

            if (productos.Count == 0)
            {
                lstProductos.Items.Add("No hay productos en el inventario.");
                return;
            }

            foreach (var producto in productos)
            {
                lstProductos.Items.Add(producto.ToString());
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!esAdministrador)
            {
                MessageBox.Show("Solo los administradores pueden agregar productos.", "Acceso Denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validar campos
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del producto es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser un número válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser un número válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    return;
                }

                if (!int.TryParse(txtStockActual.Text, out int stockActual))
                {
                    MessageBox.Show("El stock actual debe ser un número válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStockActual.Focus();
                    return;
                }

                if (!int.TryParse(txtStockMinimo.Text, out int stockMinimo))
                {
                    MessageBox.Show("El stock mínimo debe ser un número válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStockMinimo.Focus();
                    return;
                }

                // Crear producto según el tipo seleccionado
                Producto nuevoProducto = null;
                string tipoProducto = cmbTipoProducto.SelectedItem?.ToString();

                switch (tipoProducto)
                {
                    case "Electrónico":
                        string garantia = txtAtributoExtra.Text;
                        nuevoProducto = new ProductoElectrónico(id, txtNombre.Text, precio,
                            stockActual, stockMinimo, txtMarca.Text, garantia);
                        break;

                    case "Perecedero":
                        string fechaVencimiento = txtAtributoExtra.Text;
                        nuevoProducto = new ProductoPerecedero(id, txtNombre.Text, precio,
                            stockActual, stockMinimo, txtMarca.Text, fechaVencimiento);
                        break;

                    case "Ropa":
                        string[] atributos = txtAtributoExtra.Text.Split(',');
                        string talla = atributos.Length > 0 ? atributos[0].Trim() : "";
                        string material = atributos.Length > 1 ? atributos[1].Trim() : "";
                        nuevoProducto = new ProductoRopa(id, txtNombre.Text, precio,
                            stockActual, stockMinimo, txtMarca.Text, talla, material);
                        break;

                    case "Juguete":
                        string edadRecomendada = txtAtributoExtra.Text;
                        nuevoProducto = new ProductoJuguete(id, txtNombre.Text, precio,
                            stockActual, stockMinimo, txtMarca.Text, edadRecomendada);
                        break;

                    default:
                        nuevoProducto = new Producto(id, txtNombre.Text, precio,
                            stockActual, stockMinimo, txtMarca.Text);
                        break;
                }

                // Agregar al sistema
                SistemaBasedeDatos.Instancia.Productos.Add(nuevoProducto);
                CargarProductos();
                LimpiarCampos();

                MessageBox.Show("Producto agregado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (!esAdministrador)
            {
                MessageBox.Show("Solo los administradores pueden eliminar productos.", "Acceso Denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("¿Está seguro de eliminar este producto?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SistemaBasedeDatos.Instancia.Productos.RemoveAt(lstProductos.SelectedIndex);
                CargarProductos();
                MessageBox.Show("Producto eliminado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarStock_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidadStock.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var producto = SistemaBasedeDatos.Instancia.Productos[lstProductos.SelectedIndex];
            var usuario = SistemaBasedeDatos.Instancia.UsuarioActual;

            if (rbAgregar.Checked)
            {
                producto.StockActual += cantidad;

                // Registrar movimiento de entrada
                var movimiento = new MovimientoStock(
                    "Entrada",
                    cantidad,
                    producto.Nombre,
                    producto.Id,
                    usuario.Nombre,
                    "Entrada de stock"
                );
                SistemaBasedeDatos.Instancia.RegistrarMovimiento(movimiento);

                MessageBox.Show($"Stock agregado. Nuevo stock: {producto.StockActual}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbQuitar.Checked)
            {
                if (producto.StockActual >= cantidad)
                {
                    producto.StockActual -= cantidad;

                    // Registrar movimiento de salida
                    var movimiento = new MovimientoStock(
                        "Salida",
                        cantidad,
                        producto.Nombre,
                        producto.Id,
                        usuario.Nombre,
                        "Salida de stock"
                    );
                    SistemaBasedeDatos.Instancia.RegistrarMovimiento(movimiento);

                    MessageBox.Show($"Stock reducido. Nuevo stock: {producto.StockActual}", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock disponible.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            CargarProductos();
            txtCantidadStock.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStockActual.Clear();
            txtStockMinimo.Clear();
            txtMarca.Clear();
            txtAtributoExtra.Clear();
            cmbTipoProducto.SelectedIndex = -1;
            if (esAdministrador)
                txtId.Focus();
        }

        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!esAdministrador) return;

            string tipo = cmbTipoProducto.SelectedItem?.ToString();

            switch (tipo)
            {
                case "Electrónico":
                    lblAtributoExtra.Text = "Garantía (meses):";
                    txtAtributoExtra.Visible = true;
                    lblAtributoExtra.Visible = true;
                    break;
                case "Perecedero":
                    lblAtributoExtra.Text = "Fecha Vencimiento:";
                    txtAtributoExtra.Visible = true;
                    lblAtributoExtra.Visible = true;
                    break;
                case "Ropa":
                    lblAtributoExtra.Text = "Talla, Material:";
                    txtAtributoExtra.Visible = true;
                    lblAtributoExtra.Visible = true;
                    break;
                case "Juguete":
                    lblAtributoExtra.Text = "Edad Recomendada:";
                    txtAtributoExtra.Visible = true;
                    lblAtributoExtra.Visible = true;
                    break;
                default:
                    txtAtributoExtra.Visible = false;
                    lblAtributoExtra.Visible = false;
                    break;
            }
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            if (!esAdministrador)
            {
                MessageBox.Show("Solo los administradores pueden gestionar usuarios.", "Acceso Denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abrir formulario de gestión de usuarios
            using (GestionUsuariosForm gestionForm = new GestionUsuariosForm())
            {
                gestionForm.ShowDialog();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea cerrar sesión?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SistemaBasedeDatos.Instancia.UsuarioActual = null;
                this.Close();
            }
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            // Abrir formulario de historial
            using (HistorialForm historialForm = new HistorialForm())
            {
                historialForm.ShowDialog();
            }
        }
    }
}
