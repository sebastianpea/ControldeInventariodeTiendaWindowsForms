using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeInventariodeTiendaWindowsForms
{
    public class ProductoPerecedero : Producto
    {
        protected string fechaVencimiento;

        public ProductoPerecedero() : base()
        {
            fechaVencimiento = "";
        }

        public ProductoPerecedero(int id, string nombre, decimal precio, int stockactual, int stockminimo, string marca, string fechaVencimiento)
            : base(id, nombre, precio, stockactual, stockminimo, marca)
        {
            this.fechaVencimiento = fechaVencimiento;
        }

        public string FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $", Fecha de Vencimiento: {fechaVencimiento}";
        }
    }
}
