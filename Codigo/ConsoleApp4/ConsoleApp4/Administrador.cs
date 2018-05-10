using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    [Serializable()]
    public class Administrador:Usuario
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

        public bool VerificadorRut(List<Cliente> cl, List<Administrador> admin, List<Padre> padre, string rut)
        {
            foreach (Cliente p in cl) {
                if (p.rut == rut)
                {
                    return true;
                }
            }
            foreach (Administrador p in admin) {
                if (p.rut == rut)
                {
                    return true;
                }
            }
            foreach (Padre p in padre)
            {
                if (p.rut == rut)
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
