using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    [Serializable()]
    class Banco:Cliente
    {
        public string NroCuenta { get; set; }
        public string NroTarjetaDebito { get; set; }
        public string NroTarjetaCredito { get; set; }
        public float LineaDebito { get; set; }
        public float Debito { get; set; }
        public float LineaCredito { get; set; }
        public float Credito { get; set; }
        public Banco(string Rut, string Nombre, string Contraseña, int Dinero) : base(Rut, Nombre, Contraseña, Dinero)
        {
        }
        public string PagoDebito()
        {
            return "";
        }
    }
}
