using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Producto
    {
        public string nombre;
        public string marca;
        public int precio;
        public int stock;

        public Producto(string Nombre, string Marca, int Precio, int Stock)
        {
            nombre = Nombre;
            marca = Marca;
            precio = Precio;
            stock = Stock;
        }
        public void verInfoProducto()
        {
            Console.WriteLine("Nombre: " + nombre + ", marca: " + marca + ", precio: " + precio + ", stock: " + stock);
        }

    }
}
