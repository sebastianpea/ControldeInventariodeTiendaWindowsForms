using System;
using System.Linq;
using System.Windows.Forms;

namespace ControldeInventariodeTiendaWindowsForms
{
    public partial class GestionUsuariosForm : Form
    {
        public GestionUsuariosForm()
        {
            InitializeComponent();
        }

        private void GestionUsuariosForm_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            lstUsuarios.Items.Clear();
            var empleados = SistemaBasedeDatos.Instancia.Empleados;

            if (empleados.Count == 0)
            {
                lstUsuarios.Items.Add("No hay usuarios registrados.");
                return;
            }

            foreach (var empleado in empleados)
            {
                string tipo = empleado is EmpleadoAdministrador ? "Admin" : "Empleado";
                lstUsuarios.Items.Add($"{empleado.Nombre} - {empleado.CorreoElectronico} ({tipo})");
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
                {
                    MessageBox.Show("El ID del empleado es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdEmpleado.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
                {
                    MessageBox.Show("Ingrese un correo válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtContraseña.Text) || txtContraseña.Text.Length < 6)
                {
                    MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                    return;
                }

                // Verificar si el correo ya existe
                var existe = SistemaBasedeDatos.Instancia.ObtenerEmpleadoPorCorreoYContraseña(
                    txtCorreo.Text.Trim(), "");

                if (existe != null)
                {
                    MessageBox.Show("Ya existe un usuario con ese correo.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear el nuevo empleado
                Empleado nuevoEmpleado;

                if (chkEsAdmin.Checked)
                {
                    nuevoEmpleado = new EmpleadoAdministrador(
                        txtNombre.Text.Trim(),
                        txtIdEmpleado.Text.Trim(),
                        txtCorreo.Text.Trim(),
                        txtContraseña.Text
                    );
                }
                else
                {
                    nuevoEmpleado = new Empleado(
                        txtNombre.Text.Trim(),
                        txtIdEmpleado.Text.Trim(),
                        txtCorreo.Text.Trim(),
                        txtContraseña.Text
                    );
                }

                SistemaBasedeDatos.Instancia.AgregarEmpleado(nuevoEmpleado);
                CargarUsuarios();
                LimpiarCampos();

                MessageBox.Show("Usuario agregado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario de la lista.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = SistemaBasedeDatos.Instancia.Empleados[lstUsuarios.SelectedIndex];

            // No permitir eliminar al administrador principal
            if (empleado.CorreoElectronico == "endmin@gmail.com")
            {
                MessageBox.Show("No se puede eliminar al administrador principal.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = MessageBox.Show($"¿Eliminar al usuario '{empleado.Nombre}'?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SistemaBasedeDatos.Instancia.Empleados.RemoveAt(lstUsuarios.SelectedIndex);
                CargarUsuarios();
                MessageBox.Show("Usuario eliminado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtIdEmpleado.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            chkEsAdmin.Checked = false;
            txtNombre.Focus();
        }
    }
}