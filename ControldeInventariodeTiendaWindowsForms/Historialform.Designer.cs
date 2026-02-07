namespace ControldeInventariodeTiendaWindowsForms
{
    partial class HistorialForm
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
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbEntradas = new System.Windows.Forms.RadioButton();
            this.rbSalidas = new System.Windows.Forms.RadioButton();
            this.chkFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.BackColor = System.Drawing.Color.White;
            this.groupBoxFiltros.Controls.Add(this.lblTipoMovimiento);
            this.groupBoxFiltros.Controls.Add(this.rbTodos);
            this.groupBoxFiltros.Controls.Add(this.rbEntradas);
            this.groupBoxFiltros.Controls.Add(this.rbSalidas);
            this.groupBoxFiltros.Controls.Add(this.chkFiltrarFecha);
            this.groupBoxFiltros.Controls.Add(this.lblDesde);
            this.groupBoxFiltros.Controls.Add(this.dtpDesde);
            this.groupBoxFiltros.Controls.Add(this.lblHasta);
            this.groupBoxFiltros.Controls.Add(this.dtpHasta);
            this.groupBoxFiltros.Controls.Add(this.lblBuscarProducto);
            this.groupBoxFiltros.Controls.Add(this.txtBuscarProducto);
            this.groupBoxFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxFiltros.Location = new System.Drawing.Point(20, 20);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(350, 320);
            this.groupBoxFiltros.TabIndex = 0;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoMovimiento.Location = new System.Drawing.Point(20, 30);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(137, 20);
            this.lblTipoMovimiento.TabIndex = 0;
            this.lblTipoMovimiento.Text = "Tipo de movimiento:";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbTodos.Location = new System.Drawing.Point(20, 60);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(70, 24);
            this.rbTodos.TabIndex = 1;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbEntradas
            // 
            this.rbEntradas.AutoSize = true;
            this.rbEntradas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbEntradas.Location = new System.Drawing.Point(120, 60);
            this.rbEntradas.Name = "rbEntradas";
            this.rbEntradas.Size = new System.Drawing.Size(86, 24);
            this.rbEntradas.TabIndex = 2;
            this.rbEntradas.Text = "Entradas";
            this.rbEntradas.UseVisualStyleBackColor = true;
            // 
            // rbSalidas
            // 
            this.rbSalidas.AutoSize = true;
            this.rbSalidas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbSalidas.Location = new System.Drawing.Point(230, 60);
            this.rbSalidas.Name = "rbSalidas";
            this.rbSalidas.Size = new System.Drawing.Size(74, 24);
            this.rbSalidas.TabIndex = 3;
            this.rbSalidas.Text = "Salidas";
            this.rbSalidas.UseVisualStyleBackColor = true;
            // 
            // chkFiltrarFecha
            // 
            this.chkFiltrarFecha.AutoSize = true;
            this.chkFiltrarFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkFiltrarFecha.Location = new System.Drawing.Point(20, 100);
            this.chkFiltrarFecha.Name = "chkFiltrarFecha";
            this.chkFiltrarFecha.Size = new System.Drawing.Size(127, 24);
            this.chkFiltrarFecha.TabIndex = 4;
            this.chkFiltrarFecha.Text = "Filtrar por fecha";
            this.chkFiltrarFecha.UseVisualStyleBackColor = true;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesde.Location = new System.Drawing.Point(20, 135);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 20);
            this.lblDesde.TabIndex = 5;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(80, 132);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(250, 27);
            this.dtpDesde.TabIndex = 6;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHasta.Location = new System.Drawing.Point(20, 175);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(48, 20);
            this.lblHasta.TabIndex = 7;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(80, 172);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(250, 27);
            this.dtpHasta.TabIndex = 8;
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuscarProducto.Location = new System.Drawing.Point(20, 220);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(127, 20);
            this.lblBuscarProducto.TabIndex = 9;
            this.lblBuscarProducto.Text = "Buscar producto:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarProducto.Location = new System.Drawing.Point(20, 250);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(310, 27);
            this.txtBuscarProducto.TabIndex = 10;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(20, 350);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(150, 35);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Aplicar Filtros";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(180, 350);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(190, 35);
            this.btnLimpiarFiltros.TabIndex = 2;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.HorizontalScrollbar = true;
            this.lstHistorial.ItemHeight = 18;
            this.lstHistorial.Location = new System.Drawing.Point(390, 50);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(780, 490);
            this.lstHistorial.TabIndex = 3;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHistorial.Location = new System.Drawing.Point(390, 20);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(230, 25);
            this.lblHistorial.TabIndex = 4;
            this.lblHistorial.Text = "Historial de Movimientos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(390, 550);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(167, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total de movimientos: 0";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1020, 545);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 35);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // HistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1190, 595);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.groupBoxFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistorialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial de Movimientos de Stock";
            this.Load += new System.EventHandler(this.HistorialForm_Load);
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbEntradas;
        private System.Windows.Forms.RadioButton rbSalidas;
        private System.Windows.Forms.CheckBox chkFiltrarFecha;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCerrar;
    }
}