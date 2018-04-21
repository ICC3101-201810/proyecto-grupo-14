using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Credito:Webpay
    {
        public string numeroTarjeta;
        private string cvc;
        public string fechaVencimiento;
        public Credito(string Rut, string Banco, string Clave, string CVC, string Fechavencimiento,string NumeroTarjeta):base(Rut, Banco, Clave)
        {
            cvc = CVC;
            fechaVencimiento = Fechavencimiento;
            numeroTarjeta = NumeroTarjeta;
        }
        public bool verificarCVC(string cvc)
        {
            if (cvc.Length > 3 || cvc.Length < 3)
            {
                return false;
            }
            return true;
        }
        public bool verificarNumeroTarjera(string numeroTarjeta)
        {
            if (numeroTarjeta.Length > 16 || numeroTarjeta.Length < 16)
            {
                return false;
            }
            return true;
        }
        public bool verificarVechaVencimiento(string fechaVencimiento)
        {
            string fechaVencimiento1 = "01/"+fechaVencimiento;
            DateTime fechaVencimiento2 = DateTime.Parse(fechaVencimiento1);
            int result = DateTime.Compare(fechaVencimiento2, DateTime.Now);
            if ( result < 0)
            {
                return false;
            }
            return true;
        }
    }
}
