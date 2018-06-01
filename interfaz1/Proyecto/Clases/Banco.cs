using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable()]
    public class Banco : Cliente
    {
        public string NroCuenta { get; set; }
        public string NroTarjetaDebito { get; set; }
        public string NroTarjetaCredito { get; set; }
        public float LineaDebito { get; set; }
        public float Debito { get; set; }
        public string contrasenaDebito { get; set; }
        public float LineaCredito { get; set; }
        public float Credito { get; set; }
        public string contrasenaCredito { get; set; }
        public Banco(string Rut, string Nombre, string Contraseña, int Dinero) : base(Rut, Nombre, Contraseña, Dinero)
        {
        }
        public bool NroDeCuenta(string nroCuenta1, string rut1)
        {
            if (nroCuenta1 == NroCuenta && rut1 == rut)
            {
                return true;
            }
            return false;
        }
        public bool PagoConDebito(string NroDeTarjetaDebito1, string contraseña1, float monto, string rut1)
        {
            if (NroDeTarjetaDebito1 == NroTarjetaDebito && contraseña1== contrasenaDebito && rut1 ==rut )
            {
                if (Debito >= monto)
                {
                    Debito -= monto;
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool PagoConCredito(string NroDeTarjetaCredito1, string contraseña1, float monto, string rut1)
        {
            if (NroDeTarjetaCredito1 == NroTarjetaCredito && contraseña1 == contrasenaCredito && rut1==rut)
            {
                if (Credito >= monto)
                {
                    Credito -= monto;
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
