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
        private float dinero;
        private string nombre;

        public float Dinero { get => dinero; set => dinero = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Cliente(string Rut, string Nombre, string Contraseña, float Dinero) : base(Rut, Contraseña)
        {
            nombre = Nombre;
            dinero = Dinero;
        }
        public bool verificarCliente(Usuario usuario, Cliente cliente)
        {
            if (usuario.Rut == cliente.Rut && usuario.Contraseña == cliente.Contraseña)
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
