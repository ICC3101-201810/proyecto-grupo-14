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
        Cliente cliente;
        List<Producto> productos = new List<Producto>();
        Local local;
        int id { get; set; }
        public OrdenCompra(Cliente Cliente, List<Producto> Productos, Local Local)
        {
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
            if (suma > cliente.dinero)
            {
                return false;
            }
            return true;
        }
        public void verInfo()
        {
            int suma = 0;
            Console.WriteLine("El cliente: " + cliente.nombre + " compro: ");
            foreach (Producto producto in productos)
            {
                Console.WriteLine("Producto: " + producto.Nombre + ", marca " + producto.Marca + " ............ $" + producto.Precio);
                suma = suma + producto.Precio;
            }
            Console.WriteLine("Por un total de " + suma);
            Console.WriteLine("En el horario: " + DateTime.Now);
        }


    }
}
