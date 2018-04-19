using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Local
    {
        List<Producto> productos = new List<Producto>();
        public string nombre;
        string direccion;
        bool despacho;
        bool efectivo;
        bool credito;
        bool cheque;
        public string rutAdmin;

        public Local(string Nombre, string Direccion,string RutAdmin, bool Despacho, bool Efectivo, bool Credito, bool Cheque)
        {
            nombre = Nombre;
            direccion = Direccion;
            rutAdmin = RutAdmin;
            despacho = Despacho;
            efectivo = Efectivo;
            credito = Credito;
            cheque = Cheque;
        }
        public bool validarRutAdmin(string rut)
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
        public void verInfo()
        {
            Console.WriteLine("Nombre: " + nombre + ", direccion: " + direccion + ", rut admin: " + rutAdmin + ", despacho: " + despacho + ", efectivo: " + efectivo + ", credito: " + credito + ", cheque: " + cheque);
        }

        public bool perteneceUniversidad(string direccion)
        {
            if (direccion == "Monseñor...")
            {
                return true;
            }
            else { return false; }
        }

        public bool verificarAdministradorLocal(Local local, Administrador administrador)
        {
            local.rutAdmin = local.rutAdmin.Replace("-", "");
            if (local.rutAdmin == administrador.rut)
            {
                return true;
            }
            return false;
        }

        public bool agregarProducto(Producto producto)
        {
            productos.Add(producto);
            return true;
        }

        public void verProductos()
        {
            foreach (Producto producto in productos)
            {
                producto.verInfoProducto();
            }
        }
    }
}
