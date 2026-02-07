using System;
using System.Linq;
using System.Windows.Forms;

namespace ControldeInventariodeTiendaWindowsForms
{
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
        }

        private void HistorialForm_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            lstHistorial.Items.Clear();
            var movimientos = SistemaBasedeDatos.Instancia.HistorialMovimientos;

            if (movimientos.Count == 0)
            {
                lstHistorial.Items.Add("No hay movimientos registrados.");
                return;
            }

            // Mostrar los movimientos más recientes primero
            var movimientosOrdenados = movimientos.OrderByDescending(m => m.Fecha).ToList();

            foreach (var movimiento in movimientosOrdenados)
            {
                lstHistorial.Items.Add(movimiento.ToString());
            }

            lblTotal.Text = $"Total de movimientos: {movimientos.Count}";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            lstHistorial.Items.Clear();
            var movimientos = SistemaBasedeDatos.Instancia.HistorialMovimientos;

            if (movimientos.Count == 0)
            {
                lstHistorial.Items.Add("No hay movimientos registrados.");
                return;
            }

            // Filtrar por tipo de movimiento
            var movimientosFiltrados = movimientos.AsEnumerable();

            if (rbEntradas.Checked)
            {
                movimientosFiltrados = movimientosFiltrados.Where(m => m.TipoMovimiento == "Entrada");
            }
            else if (rbSalidas.Checked)
            {
                movimientosFiltrados = movimientosFiltrados.Where(m => m.TipoMovimiento == "Salida");
            }

            // Filtrar por fecha si está activado
            if (chkFiltrarFecha.Checked)
            {
                DateTime fechaDesde = dtpDesde.Value.Date;
                DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                movimientosFiltrados = movimientosFiltrados
                    .Where(m => m.Fecha >= fechaDesde && m.Fecha <= fechaHasta);
            }

            // Filtrar por producto si hay texto
            if (!string.IsNullOrWhiteSpace(txtBuscarProducto.Text))
            {
                string busqueda = txtBuscarProducto.Text.ToLower();
                movimientosFiltrados = movimientosFiltrados
                    .Where(m => m.NombreProducto.ToLower().Contains(busqueda));
            }

            var resultado = movimientosFiltrados.OrderByDescending(m => m.Fecha).ToList();

            if (resultado.Count == 0)
            {
                lstHistorial.Items.Add("No se encontraron movimientos con los filtros aplicados.");
            }
            else
            {
                foreach (var movimiento in resultado)
                {
                    lstHistorial.Items.Add(movimiento.ToString());
                }
            }

            lblTotal.Text = $"Movimientos encontrados: {resultado.Count}";
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            rbTodos.Checked = true;
            chkFiltrarFecha.Checked = false;
            txtBuscarProducto.Clear();
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            CargarHistorial();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
