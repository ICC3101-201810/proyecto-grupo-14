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
        private string NroCuenta;
        private string NroTarjetaDebito;
        private string NroTarjetaCredito;
        private float LineaDebito;
        private float Debito;
        private string contrasenaDebito;
        private float LineaCredito;
        private float Credito;
        private string contrasenaCredito;

        public string NroCuenta1 { get => NroCuenta; set => NroCuenta = value; }
        public string NroTarjetaDebito1 { get => NroTarjetaDebito; set => NroTarjetaDebito = value; }
        public string NroTarjetaCredito1 { get => NroTarjetaCredito; set => NroTarjetaCredito = value; }
        public float LineaDebito1 { get => LineaDebito; set => LineaDebito = value; }
        public float Debito1 { get => Debito; set => Debito = value; }
        public string ContrasenaDebito { get => contrasenaDebito; set => contrasenaDebito = value; }
        public float LineaCredito1 { get => LineaCredito; set => LineaCredito = value; }
        public float Credito1 { get => Credito; set => Credito = value; }
        public string ContrasenaCredito { get => contrasenaCredito; set => contrasenaCredito = value; }

        public Banco(string contrasenaCredito,float Credito,float LineaCredito,string contrasenaDebito,float Debito,float LineaDebito,string NroCuenta, string NroTarjetaDebito, string NroTarjetaCredito, string Rut, string Nombre, string Contraseña, int Dinero) : base(Rut, Nombre, Contraseña, Dinero)
        {
            this.NroCuenta = NroCuenta;
            this.NroTarjetaDebito = NroTarjetaDebito;
            this.NroTarjetaCredito = NroTarjetaCredito;
            this.LineaDebito = LineaDebito;
            this.Debito = Debito;
            this.contrasenaDebito = contrasenaDebito;
            this.LineaCredito = LineaCredito;
            this.Credito = Credito;
            this.contrasenaCredito = contrasenaCredito;
        }
        public bool NroDeCuenta(string nroCuenta1, string rut1)
        {
            if (nroCuenta1 == NroCuenta1 && rut1 == Rut)
            {
                return true;
            }
            return false;
        }
        public bool PagoConDebito(string NroDeTarjetaDebito1, string contraseña1, float monto, string rut1)
        {
            if (NroDeTarjetaDebito1 == NroTarjetaDebito1 && contraseña1== ContrasenaDebito && rut1 ==Rut )
            {
                if (Debito1 >= monto)
                {
                    Debito1 -= monto;
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool PagoConCredito(string NroDeTarjetaCredito1, string contraseña1, float monto, string rut1)
        {
            if (NroDeTarjetaCredito1 == NroTarjetaCredito1 && contraseña1 == ContrasenaCredito && rut1==Rut)
            {
                if (Credito1 >= monto)
                {
                    Credito1 -= monto;
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
