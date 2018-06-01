using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable()]
    public class Cliente : Usuario
    {
        public float dinero { get; set; }
        public string nombre { get; set; }
        public Cliente(string Rut, string Nombre, string Contraseña, float Dinero) : base(Rut, Contraseña)
        {
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
                if (local.Efectivo == true)
                {
                    return true;
                }
                return false;
            }

            else if (metodo == "2")
            {
                if (local.Debito == true)
                {
                    return true;
                }
                return false;
            }

            else if (metodo == "3")
            {
                if (local.Credito == true)
                {
                    return true;
                }
                return false;
            }

            else if (metodo == "4")
            {
                if (local.Cheque == true)
                {
                    return true;
                }
                return false;
            }
            return false;

        }

    }
}
