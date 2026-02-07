using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeInventariodeTiendaWindowsForms
{
    public class ProductoElectrónico : Producto
    {
        protected string garantíameses;

        public ProductoElectrónico() : base()
        {
            garantíameses = "";
        }

        public ProductoElectrónico(int id, string nombre, decimal precio, int stockactual, int stockminimo, string marca, string garantíameses)
            : base(id, nombre, precio, stockactual, stockminimo, marca)
        {
            this.garantíameses = garantíameses;
        }

        public string GarantíaMeses
        {
            get { return garantíameses; }
            set { garantíameses = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $", Garantía: {garantíameses} meses";
        }
    }
}
