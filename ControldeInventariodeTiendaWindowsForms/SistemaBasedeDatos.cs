using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeInventariodeTiendaWindowsForms
{
    internal class SistemaBasedeDatos
    {
        protected List<Producto> productos;
        protected List<ProductoElectrónico> productosElectrónicos;
        protected List<ProductoPerecedero> productosPerecederos;

        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        public List<ProductoElectrónico> ProductosElectrónicos
        {
            get { return productosElectrónicos; }
            set { productosElectrónicos = value; }
        }

        public List<ProductoPerecedero> ProductosPerecederos
        {
            get { return productosPerecederos; }
            set { productosPerecederos = value; }
        }

        public SistemaBasedeDatos()
        {
            productos = new List<Producto>();

            productosElectrónicos = new List<ProductoElectrónico>();

            productosPerecederos = new List<ProductoPerecedero>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Productos:");
            foreach (var producto in productos)
            {
                sb.AppendLine(producto.ToString());
            }
            sb.AppendLine("Productos Electrónicos:");
            foreach (var productoElectrónico in productosElectrónicos)
            {
                sb.AppendLine(productoElectrónico.ToString());
            }
            sb.AppendLine("Productos Perecederos:");
            foreach (var productoPerecedero in productosPerecederos)
            {
                sb.AppendLine(productoPerecedero.ToString());
            }
            return sb.ToString();
        }

    }
}

