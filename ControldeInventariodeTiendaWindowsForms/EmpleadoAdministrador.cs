using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeInventariodeTiendaWindowsForms
{
    internal class EmpleadoAdministrador : Empleado
    {
        public List<Empleado> empleados;

        public EmpleadoAdministrador() : base()
        {
            empleados = new List<Empleado>();
        }
        public EmpleadoAdministrador(string nombre, string idEmpleado, string correoElectronico, string contraseña)
            : base(nombre, idEmpleado, correoElectronico, contraseña)
        {
            empleados = new List<Empleado>();
        }
        //empleado de ejemplo
        public EmpleadoAdministrador CrearEjemplo()
        {
            var empleadoAdministrador = new EmpleadoAdministrador("endmin", "007", "endmin@gmail.com", "endmin123");
            return empleadoAdministrador;
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }
        public void EliminarEmpleado(Empleado empleado)
        {
            empleados.Remove(empleado);
        }
        public void AgregarProductos(Producto producto)
        {
            if (producto is ProductoElectrónico)
            {
                var productoElectrónico = producto as ProductoElectrónico;
                productosElectrónicos.Add(productoElectrónico);
            }
            else if (producto is ProductoPerecedero)
            {
                var productoPerecedero = producto as ProductoPerecedero;
                productosPerecederos.Add(productoPerecedero);
            }
            else if (producto is ProductoRopa)
            {
                var productoRopa = producto as ProductoRopa;
                productosRopa.Add(productoRopa);
            }
            else if (producto is ProductoJuguete)
            {
                var productoJuguete = producto as ProductoJuguete;
                productosJuguete.Add(productoJuguete);
            }
        }
    }
}
