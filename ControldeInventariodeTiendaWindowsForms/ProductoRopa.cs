using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeInventariodeTiendaWindowsForms
{
    internal class ProductoRopa : Producto
    {
        protected string talla;
        protected string material;
        public ProductoRopa() : base()
        {
            talla = "";
            material = "";
        }
        public ProductoRopa(int id, string nombre, decimal precio, int stockactual, int stockminimo, string marca, string talla, string material)
            : base(id, nombre, precio, stockactual, stockminimo, marca)
        {
            this.talla = talla;
            this.material = material;
        }
        public string Talla
        {
            get { return talla; }
            set { talla = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $", Talla: {talla}, Material: {material}";
        }
    }
}
