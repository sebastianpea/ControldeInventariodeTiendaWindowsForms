namespace ControldeInventariodeTiendaWindowsForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblAtributoExtra = new System.Windows.Forms.Label();
            this.txtAtributoExtra = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxStock = new System.Windows.Forms.GroupBox();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.rbAgregar = new System.Windows.Forms.RadioButton();
            this.rbQuitar = new System.Windows.Forms.RadioButton();
            this.btnModificarStock = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.BackColor = System.Drawing.Color.White;
            this.groupBoxDatos.Controls.Add(this.lblId);
            this.groupBoxDatos.Controls.Add(this.txtId);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.lblPrecio);
            this.groupBoxDatos.Controls.Add(this.txtPrecio);
            this.groupBoxDatos.Controls.Add(this.lblStockActual);
            this.groupBoxDatos.Controls.Add(this.txtStockActual);
            this.groupBoxDatos.Controls.Add(this.lblStockMinimo);
            this.groupBoxDatos.Controls.Add(this.txtStockMinimo);
            this.groupBoxDatos.Controls.Add(this.lblMarca);
            this.groupBoxDatos.Controls.Add(this.txtMarca);
            this.groupBoxDatos.Controls.Add(this.lblTipoProducto);
            this.groupBoxDatos.Controls.Add(this.cmbTipoProducto);
            this.groupBoxDatos.Controls.Add(this.lblAtributoExtra);
            this.groupBoxDatos.Controls.Add(this.txtAtributoExtra);
            this.groupBoxDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.Location = new System.Drawing.Point(20, 60);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(400, 400);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del Producto";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblId.Location = new System.Drawing.Point(20, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.Location = new System.Drawing.Point(150, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(230, 27);
            this.txtId.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.Location = new System.Drawing.Point(20, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(150, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrecio.Location = new System.Drawing.Point(20, 110);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.Location = new System.Drawing.Point(150, 107);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(230, 27);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStockActual.Location = new System.Drawing.Point(20, 150);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(95, 20);
            this.lblStockActual.TabIndex = 6;
            this.lblStockActual.Text = "Stock Actual:";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockActual.Location = new System.Drawing.Point(150, 147);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(230, 27);
            this.txtStockActual.TabIndex = 7;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStockMinimo.Location = new System.Drawing.Point(20, 190);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(105, 20);
            this.lblStockMinimo.TabIndex = 8;
            this.lblStockMinimo.Text = "Stock Mínimo:";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockMinimo.Location = new System.Drawing.Point(150, 187);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(230, 27);
            this.txtStockMinimo.TabIndex = 9;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMarca.Location = new System.Drawing.Point(20, 230);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMarca.Location = new System.Drawing.Point(150, 227);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(230, 27);
            this.txtMarca.TabIndex = 11;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoProducto.Location = new System.Drawing.Point(20, 270);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(42, 20);
            this.lblTipoProducto.TabIndex = 12;
            this.lblTipoProducto.Text = "Tipo:";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Items.AddRange(new object[] {
            "General",
            "Electrónico",
            "Perecedero",
            "Ropa",
            "Juguete"});
            this.cmbTipoProducto.Location = new System.Drawing.Point(150, 267);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(230, 28);
            this.cmbTipoProducto.TabIndex = 13;
            this.cmbTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProducto_SelectedIndexChanged);
            // 
            // lblAtributoExtra
            // 
            this.lblAtributoExtra.AutoSize = true;
            this.lblAtributoExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAtributoExtra.Location = new System.Drawing.Point(20, 310);
            this.lblAtributoExtra.Name = "lblAtributoExtra";
            this.lblAtributoExtra.Size = new System.Drawing.Size(109, 20);
            this.lblAtributoExtra.TabIndex = 14;
            this.lblAtributoExtra.Text = "Atributo Extra:";
            this.lblAtributoExtra.Visible = false;
            // 
            // txtAtributoExtra
            // 
            this.txtAtributoExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAtributoExtra.Location = new System.Drawing.Point(150, 307);
            this.txtAtributoExtra.Multiline = true;
            this.txtAtributoExtra.Name = "txtAtributoExtra";
            this.txtAtributoExtra.Size = new System.Drawing.Size(230, 60);
            this.txtAtributoExtra.TabIndex = 15;
            this.txtAtributoExtra.Visible = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(20, 470);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 40);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(150, 470);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(120, 40);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(280, 470);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 40);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBoxStock
            // 
            this.groupBoxStock.BackColor = System.Drawing.Color.White;
            this.groupBoxStock.Controls.Add(this.lblCantidadStock);
            this.groupBoxStock.Controls.Add(this.txtCantidadStock);
            this.groupBoxStock.Controls.Add(this.rbAgregar);
            this.groupBoxStock.Controls.Add(this.rbQuitar);
            this.groupBoxStock.Controls.Add(this.btnModificarStock);
            this.groupBoxStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxStock.Location = new System.Drawing.Point(20, 520);
            this.groupBoxStock.Name = "groupBoxStock";
            this.groupBoxStock.Size = new System.Drawing.Size(400, 150);
            this.groupBoxStock.TabIndex = 4;
            this.groupBoxStock.TabStop = false;
            this.groupBoxStock.Text = "Modificar Stock";
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCantidadStock.Location = new System.Drawing.Point(20, 30);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(72, 20);
            this.lblCantidadStock.TabIndex = 0;
            this.lblCantidadStock.Text = "Cantidad:";
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidadStock.Location = new System.Drawing.Point(110, 27);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(270, 27);
            this.txtCantidadStock.TabIndex = 1;
            // 
            // rbAgregar
            // 
            this.rbAgregar.AutoSize = true;
            this.rbAgregar.Checked = true;
            this.rbAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbAgregar.Location = new System.Drawing.Point(20, 70);
            this.rbAgregar.Name = "rbAgregar";
            this.rbAgregar.Size = new System.Drawing.Size(130, 24);
            this.rbAgregar.TabIndex = 2;
            this.rbAgregar.TabStop = true;
            this.rbAgregar.Text = "Agregar Stock";
            this.rbAgregar.UseVisualStyleBackColor = true;
            // 
            // rbQuitar
            // 
            this.rbQuitar.AutoSize = true;
            this.rbQuitar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbQuitar.Location = new System.Drawing.Point(200, 70);
            this.rbQuitar.Name = "rbQuitar";
            this.rbQuitar.Size = new System.Drawing.Size(116, 24);
            this.rbQuitar.TabIndex = 3;
            this.rbQuitar.Text = "Quitar Stock";
            this.rbQuitar.UseVisualStyleBackColor = true;
            // 
            // btnModificarStock
            // 
            this.btnModificarStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnModificarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificarStock.ForeColor = System.Drawing.Color.White;
            this.btnModificarStock.Location = new System.Drawing.Point(20, 100);
            this.btnModificarStock.Name = "btnModificarStock";
            this.btnModificarStock.Size = new System.Drawing.Size(150, 35);
            this.btnModificarStock.TabIndex = 4;
            this.btnModificarStock.Text = "Modificar";
            this.btnModificarStock.UseVisualStyleBackColor = false;
            this.btnModificarStock.Click += new System.EventHandler(this.btnModificarStock_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.HorizontalScrollbar = true;
            this.lstProductos.ItemHeight = 18;
            this.lstProductos.Location = new System.Drawing.Point(440, 90);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(750, 580);
            this.lstProductos.TabIndex = 5;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductos.Location = new System.Drawing.Point(440, 60);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(198, 25);
            this.lblProductos.TabIndex = 6;
            this.lblProductos.Text = "Inventario Productos";
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.AutoSize = true;
            this.lblUsuarioActual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblUsuarioActual.Location = new System.Drawing.Point(20, 15);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(74, 23);
            this.lblUsuarioActual.TabIndex = 7;
            this.lblUsuarioActual.Text = "Usuario:";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1040, 10);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 35);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGestionarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(860, 10);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(170, 35);
            this.btnGestionarUsuarios.TabIndex = 9;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1210, 690);
            this.Controls.Add(this.btnGestionarUsuarios);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblUsuarioActual);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.groupBoxStock);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.groupBoxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventario de Tienda";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxStock.ResumeLayout(false);
            this.groupBoxStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label lblAtributoExtra;
        private System.Windows.Forms.TextBox txtAtributoExtra;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxStock;
        private System.Windows.Forms.Label lblCantidadStock;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.RadioButton rbAgregar;
        private System.Windows.Forms.RadioButton rbQuitar;
        private System.Windows.Forms.Button btnModificarStock;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblUsuarioActual;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnGestionarUsuarios;
    }
}