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
        private string rut;
        private string contraseña;

        public string Rut { get => rut; set => rut = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

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
                this.Rut = this.Rut.ToUpper();
                this.Rut = this.Rut.Replace("-", "");
                int rutAux = int.Parse(this.Rut.Substring(0, this.Rut.Length - 1));
                char dv = char.Parse(this.Rut.Substring(this.Rut.Length - 1, 1));
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
                if (p.Rut == rut && p.Contraseña == contraseña)
                {
                    return true;
                }
            }
            foreach (Administrador p in admin)
            {
                if (p.Rut == rut && p.Contraseña == contraseña)
                {
                    return true;
                }
            }
            foreach (Padre p in padre)
            {
                if (p.Rut == rut && p.Contraseña == contraseña)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CambiarContraseña(List<Cliente> cl, List<Administrador> admin, List<Padre> padre, string rut, string contraseña_a, string contraseña_n)
        {
            foreach (Cliente p in cl)
            {
                if (p.Rut == rut && p.Contraseña == contraseña_a)
                {
                    Cliente c1 = new Cliente(rut, p.Nombre, contraseña_n, p.Dinero);
                    cl.Add(c1);
                    cl.Remove(p);
                    return true;
                }
            }
            foreach (Administrador p in admin)
            {
                if (p.Rut == rut && p.Contraseña == contraseña_a)
                {
                    Administrador a1 = new Administrador(rut, p.Nombre, contraseña_n);
                    admin.Add(a1);
                    admin.Remove(p);
                    return true;
                }
            }
            foreach (Padre p in padre)
            {
                if (p.Rut == rut && p.Contraseña == contraseña_a)
                {
                    Padre p1 = new Padre(rut, p.Nombre, contraseña_n);
                    padre.Add(p1);
                    padre.Remove(p);
                    return true;
                }
            }
            return false;
        }

    }
}
