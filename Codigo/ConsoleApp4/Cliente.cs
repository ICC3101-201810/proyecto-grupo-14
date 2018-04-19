using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Cliente:Usuario
    {
        public int dinero;
        public string nombre;
        public Cliente(string Rut, string Nombre, string Contraseña, int Dinero) : base(Rut, Contraseña)
        {
            dinero = Dinero;
            nombre = Nombre;
        }
        public bool verificarCliente(Usuario usuario, Cliente cliente)
        {
            if (usuario.rut == cliente.rut && usuario.contraseña == cliente.contraseña)
            {
                return true;
            }
            return false;
        }

    }
}
