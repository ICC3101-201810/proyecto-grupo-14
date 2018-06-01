using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable()]
    public class Padre : Usuario
    {
        private List<Local> locales;
        private string nombre;

        

        public List<Local> Locales { get => locales; set => locales = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Padre(string Rut, string Nombre, string Contraseña) : base(Rut, Contraseña)
        {
            nombre = Nombre;
        }
        public bool agregarLocal(Local local)
        {
            Locales.Add(local);
            return true;
        }
        public bool verificarPadre(Usuario usuario, Padre padre)
        {
            if (usuario.Rut == padre.Rut && usuario.Contraseña == padre.Contraseña)
            {
                return true;
            }
            return false;
        }
    }
}
