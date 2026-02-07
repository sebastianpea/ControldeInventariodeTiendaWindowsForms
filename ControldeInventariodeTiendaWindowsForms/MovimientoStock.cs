using System;

namespace ControldeInventariodeTiendaWindowsForms
{
    public class MovimientoStock
    {
        private DateTime fecha;
        private string tipoMovimiento;
        private int cantidad;
        private string nombreProducto;
        private int idProducto;
        private string usuarioResponsable;
        private string observaciones;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string TipoMovimiento
        {
            get { return tipoMovimiento; }
            set { tipoMovimiento = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string UsuarioResponsable
        {
            get { return usuarioResponsable; }
            set { usuarioResponsable = value; }
        }
        // Constructores
        public MovimientoStock()
        {
            fecha = DateTime.Now;
            tipoMovimiento = "";
            cantidad = 0;
            nombreProducto = "";
            idProducto = 0;
            usuarioResponsable = "";
        }
        public MovimientoStock(string tipoMovimiento, int cantidad, string nombreProducto,
            int idProducto, string usuarioResponsable, string observaciones)
        {
            this.fecha = DateTime.Now;
            this.tipoMovimiento = tipoMovimiento;
            this.cantidad = cantidad;
            this.nombreProducto = nombreProducto;
            this.idProducto = idProducto;
            this.usuarioResponsable = usuarioResponsable;
            this.observaciones = observaciones;
        }

        public MovimientoStock(string tipoMovimiento, int cantidad, string nombreProducto,
            int idProducto, string usuarioResponsable)
        {
            this.fecha = DateTime.Now;
            this.tipoMovimiento = tipoMovimiento;
            this.cantidad = cantidad;
            this.nombreProducto = nombreProducto;
            this.idProducto = idProducto;
            this.usuarioResponsable = usuarioResponsable;
        }
        public override string ToString()
        {
            return $"Fecha: {fecha}, Tipo: {tipoMovimiento}, Cantidad: {cantidad}, " +
                   $"Producto: {nombreProducto} (ID: {idProducto}), Usuario: {usuarioResponsable}";
        }
    }
}

