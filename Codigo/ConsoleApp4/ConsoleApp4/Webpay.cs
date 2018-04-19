using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Webpay
    {
        public string rut;
        public string banco;
        public string clave;

        public Webpay(string Rut, string Banco, string Clave)
        {
            rut = Rut;
            banco = Banco;
            clave = Clave;
        }

    }
}
