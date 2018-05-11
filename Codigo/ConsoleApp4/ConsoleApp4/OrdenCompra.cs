using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class OrdenCompra
    {
        [Serializable()]
        Cliente cliente;
        List<Producto> productos = new List<Producto>();
        Local local;

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
                suma = suma + producto.precio;
            }
            if (suma > cliente.dinero)
            {
                return false;
            }
            return true;
        }
        public bool verificarCompra(Cliente cliente, List<Producto> productos)
        {
            int suma=0;
            Console.WriteLine("El cliente: "+cliente.nombre+" compro: ");
            foreach (Producto producto in productos)
            {
                Console.WriteLine("Producto: "+ producto.nombre+", marca "+producto.marca+" ............ $"+producto.precio);
                suma = suma + producto.precio;
            }
            Console.WriteLine("Por un total de "+suma);
            Console.WriteLine("En el horario: "+DateTime.Now);
        }
       

    }
}
