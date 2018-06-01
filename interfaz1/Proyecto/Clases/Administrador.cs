using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable()]
    public class Administrador : Usuario
    {
        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        public Administrador(string Rut, string Nombre, string Contraseña) : base(Rut, Contraseña)
        {
            nombre = Nombre;
        }

        

        public bool verificarAdministrador(Usuario usuario, Administrador administrador)
        {
            if (usuario.Rut == administrador.Rut && usuario.Contraseña == administrador.Contraseña)
            {
                return true;
            }
            return false;
        }
    }
}
