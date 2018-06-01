using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable()]
    public class OrdenCompra
    {
        private Cliente cliente;
        private List<Producto> productos;
        private Local local;
        private int id;
       

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }
        public Local Local { get => local; set => local = value; }
        public int Id { get => id; set => id = value; }

        public OrdenCompra(int di, Cliente Cliente, List<Producto> Productos, Local Local)
        {
            id = di;
            cliente = Cliente;
            productos = Productos;
            local = Local;
        }
        public bool verificarCompra(Cliente cliente, List<Producto> productos)
        {
            int suma = 0;
            foreach (Producto producto in productos)
            {
                suma = suma + producto.Precio;
            }
            if (suma > cliente.Dinero)
            {
                return false;
            }
            return true;
        }
        public void verInfo()
        {
            int suma = 0;
            Console.WriteLine("El cliente: " + Cliente.Nombre + " compro: ");
            foreach (Producto producto in Productos)
            {
                Console.WriteLine("Producto: " + producto.Nombre + ", marca " + producto.Marca + " ............ $" + producto.Precio);
                suma = suma + producto.Precio;
            }
            Console.WriteLine("Por un total de " + suma);
            Console.WriteLine("En el horario: " + DateTime.Now);
        }
        public float VerMonto()
            {
            float suma = 0;
            foreach (Producto producto in Productos)
            {
                suma = suma + producto.Precio;
            }
            return suma;
        }

    }
}
