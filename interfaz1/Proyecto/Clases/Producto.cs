using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable()]
    public class Producto
    {
        private string nombre;
        private string marca;
        private int precio;
        private int stock;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public Producto(string Nombre, string Marca, int Precio, int Stock)
        {
            nombre = Nombre;
            marca = Marca;
            precio = Precio;
            stock = Stock;
        }

    }
}
