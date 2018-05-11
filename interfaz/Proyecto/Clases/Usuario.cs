using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable()]
    public class Usuario
    {
        public string rut;
        public string contraseña;

        public Usuario(string Rut, string Contraseña)
        {
            rut = Rut;
            contraseña = Contraseña;
        }

        public bool verificarRut(string Rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }
        public bool VerificadorUsuario(List<Cliente> cl, List<Administrador> admin, List<Padre> padre, string rut, string contraseña)
        {
            foreach (Cliente p in cl)
            {
                if (p.rut == rut && p.contraseña == contraseña)
                {
                    return true;
                }
            }
            foreach (Administrador p in admin)
            {
                if (p.rut == rut && p.contraseña == contraseña)
                {
                    return true;
                }
            }
            foreach (Padre p in padre)
            {
                if (p.rut == rut && p.contraseña == contraseña)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
