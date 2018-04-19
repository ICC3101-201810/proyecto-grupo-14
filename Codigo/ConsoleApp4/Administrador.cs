using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Administrador:Usuario
    {
        public string nombre;
        public Administrador(string Rut, string Nombre, string Contraseña):base(Rut, Contraseña)
        {
            nombre = Nombre;
        }
        public bool verificarAdministrador(Usuario usuario, Administrador administrador)
        {
            if (usuario.rut == administrador.rut && usuario.contraseña == administrador.contraseña)
            {
                return true;
            }
            return false;
        }
    }
}
