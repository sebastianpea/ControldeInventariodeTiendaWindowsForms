using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeInventariodeTiendaWindowsForms
{
    internal class ProductoJuguete : Producto
    {
        protected string edadRecomendada;

        public ProductoJuguete() : base()
        {
            edadRecomendada = "";
        }
        public ProductoJuguete(int id, string nombre, decimal precio, int stockactual, int stockminimo, string marca, string edadRecomendada)
            : base(id, nombre, precio, stockactual, stockminimo, marca)
        {
            this.edadRecomendada = edadRecomendada;
        }
        public string EdadRecomendada
        {
            get { return edadRecomendada; }
            set { edadRecomendada = value; }
        }
        public override string ToString()
        {
           return base.ToString() + $", Edad Recomendada: {edadRecomendada}";
        }

      
    }
}
