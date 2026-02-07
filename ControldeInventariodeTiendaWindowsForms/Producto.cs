using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControldeInventariodeTiendaWindowsForms
{
    public class Producto
    {
        protected int id;
        protected string nombre;
        protected decimal precio;
        protected int stockactual;
        protected int stockminimo;
        protected string marca;

        public int Id
            {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
            {
            get { return nombre; }
            set { nombre = value; }
        }
        public decimal Precio
            {
            get { return precio; }
            set { precio = value; }
        }
        public int StockActual
            {
            get { return stockactual; }
            set { stockactual = value; }
        }
        public int StockMinimo
        {
            get { return stockminimo; }
            set { stockminimo = value; }
        }
            public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public Producto()
            {
            id = 0;
            nombre = "";
            precio = 0;
            stockactual = 0;
            stockminimo = 0;
            marca = "";
        }
        public Producto(int id, string nombre, decimal precio, int stockactual, int stockminimo, string marca)
            {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.stockactual = stockactual;
            this.stockminimo = stockminimo;
            this.marca = marca;
        }
        public override string ToString()
        {
            return $"ID: {id}, Nombre: {nombre}, Precio: {precio}, Stock Actual: {stockactual}, Stock Mínimo: {stockminimo}, Marca: {marca}";
        }




    }
}
