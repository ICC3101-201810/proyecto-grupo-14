using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Cliente : Usuario
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

        public bool SeleccionarMetodoDePago(Local local, string metodo)
        {
            //1 = efectivo , 2=debito , 3=credito , 4=cheque

            if (metodo == "1")
            {
                if (local.efectivo == true)
                {
                    return true;
                }
                return false;
            }

            else if (metodo == "2")
            {
                if (local.debito == true)
                {
                    return true;
                }
                return false;
            }

            else if (metodo == "3")
            {
                if (local.credito == true)
                {
                    return true;
                }
                return false;
            }

            else if (metodo == "4")
            {
                if (local.cheque == true)
                {
                    return true;
                }
                return false;
            }
            return false;

        }

    }
}
