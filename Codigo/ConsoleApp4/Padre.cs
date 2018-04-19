using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Padre:Usuario
    {
        List<Local> locales = new List<Local>();
        public string nombre;
        public Padre(string Rut, string Nombre, string Contraseña):base(Rut, Contraseña)
        {
            nombre = Nombre;
        }
        public bool agregarLocal(Local local)
        {
            locales.Add(local);
            return true;
        }
        public bool verificarPadre(Usuario usuario, Padre padre)
        {
            if (usuario.rut == padre.rut && usuario.contraseña == padre.contraseña)
            {
                return true;
            }
            return false;
        }
    }
}
