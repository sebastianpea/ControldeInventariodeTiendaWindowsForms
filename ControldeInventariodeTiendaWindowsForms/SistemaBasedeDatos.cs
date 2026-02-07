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

        // Lista de empleados (usuarios)
        protected List<Empleado> empleados;

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

        public List<Empleado> Empleados
        {
            get { return empleados; }
            set { empleados = value; }
        }

        // Usuario autenticado actualmente
        public Empleado UsuarioActual { get; set; }

        public static SistemaBasedeDatos Instancia { get; } = new SistemaBasedeDatos();

        public SistemaBasedeDatos()
        {
            productos = new List<Producto>();

            productosElectrónicos = new List<ProductoElectrónico>();

            productosPerecederos = new List<ProductoPerecedero>();

            empleados = new List<Empleado>();

            // Empleado de ejemplo
            var admin = new EmpleadoAdministrador("endmin", "007", "endmin@gmail.com", "endmin123");
            empleados.Add(admin);
        }

        public Empleado ObtenerEmpleadoPorCorreoYContraseña(string correo, string contraseña)
        {
            // Si la contraseña está vacía, solo buscar por correo (usado para validar si existe)
            if (string.IsNullOrEmpty(contraseña))
            {
                return empleados.FirstOrDefault(e => e != null && e.CorreoElectronico == correo);
            }

            // Búsqueda completa por correo y contraseña
            return empleados.FirstOrDefault(e => e != null &&
                e.CorreoElectronico == correo &&
                e.Contrasena == contraseña);
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            if (empleado != null)
                empleados.Add(empleado);
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
