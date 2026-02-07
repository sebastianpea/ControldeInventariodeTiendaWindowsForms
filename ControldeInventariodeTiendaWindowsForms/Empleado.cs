using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControldeInventariodeTiendaWindowsForms
{
    internal class Empleado
    {
        protected string nombre;
        protected string idEmpleado;
        protected string correoElectronico;
        protected string contraseña;
        protected List<ProductoElectrónico> productosElectrónicos;
        protected List<ProductoPerecedero> productosPerecederos;
        protected List<ProductoRopa> productosRopa;
        protected List<ProductoJuguete> productosJuguete;
        protected string stockActual;
        protected string stockMinimo;


        public Empleado()
        {
            nombre = "";
            idEmpleado = "";
            correoElectronico = "";
            contraseña = "";
            productosElectrónicos = new List<ProductoElectrónico>();
            productosPerecederos = new List<ProductoPerecedero>();
            productosRopa = new List<ProductoRopa>();
            productosJuguete = new List<ProductoJuguete>();
            stockActual = "";
            stockMinimo = "";
        }

        public Empleado(string nombre, string idEmpleado, string correoElectronico, string contraseña)
        {
            this.nombre = nombre;
            this.idEmpleado = idEmpleado;
            this.correoElectronico = correoElectronico;
            this.contraseña = contraseña;
            productosElectrónicos = new List<ProductoElectrónico>();
            productosPerecederos = new List<ProductoPerecedero>();
            productosRopa = new List<ProductoRopa>();
            productosJuguete = new List<ProductoJuguete>();
            stockActual = "";
            stockMinimo = "";
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}, ID Empleado: {idEmpleado}, Correo Electrónico: {correoElectronico}";
        }
        public void AgregarStock(Producto producto, int cantidad)
        {
            if (producto is ProductoElectrónico)
            {
                var productoElectrónico = producto as ProductoElectrónico;
                productoElectrónico.StockActual += cantidad;
            }
            else if (producto is ProductoPerecedero)
            {
                var productoPerecedero = producto as ProductoPerecedero;
                productoPerecedero.StockActual += cantidad;
            }
            else if (producto is ProductoRopa)
            {
                var productoRopa = producto as ProductoRopa;
                productoRopa.StockActual += cantidad;
            }
            else if (producto is ProductoJuguete)
            {
                var productoJuguete = producto as ProductoJuguete;
                productoJuguete.StockActual += cantidad;
            }

        }
        public void EliminarStock(Producto producto, int cantidad)
        {
            if (producto is ProductoElectrónico)
            {
                var productoElectrónico = producto as ProductoElectrónico;
                productoElectrónico.StockActual -= cantidad;
            }
            else if (producto is ProductoPerecedero)
            {
                var productoPerecedero = producto as ProductoPerecedero;
                productoPerecedero.StockActual -= cantidad;
            }
            else if (producto is ProductoRopa)
            {
                var productoRopa = producto as ProductoRopa;
                productoRopa.StockActual -= cantidad;
            }
            else if (producto is ProductoJuguete)
            {
                var productoJuguete = producto as ProductoJuguete;
                productoJuguete.StockActual -= cantidad;
            }
            //consultar stock
            string stockInfo = $"Stock Actual: {producto.StockActual}, Stock Mínimo: {producto.StockMinimo}";



        }
    }
}
