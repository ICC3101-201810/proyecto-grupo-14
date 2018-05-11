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
        public float LineaCredito { get; set; }
        public float Credito { get; set; }
        public Banco(string Rut, string Nombre, string Contraseña, int Dinero) : base(Rut, Nombre, Contraseña, Dinero)
        {
        }
        public bool NroDeCuenta(string nroCuenta, string rut)
        {
            if (NroCuenta == NroCuenta && rut == rut) {
                return true;
            }
            return false;
        }
        public bool PagoConDebito(string NroDeTarjetaDebito, string contraseña, float monto, Banco Cl)
        {
            if (NroDeTarjetaDebito == Cl.NroTarjetaDebito && contraseña== Cl.contraseña)
            {
                if (Cl.Debito >= monto)
                {
                    Cl.Debito -= monto;
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool PagoConCredito(string NroDeTarjetaCredito, string contraseña, float monto, Banco Cl)
        {
            if (NroDeTarjetaCredito == Cl.NroTarjetaCredito && contraseña == Cl.contraseña)
            {
                if (Cl.Credito >= monto)
                {
                    Cl.Credito -= monto;
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
