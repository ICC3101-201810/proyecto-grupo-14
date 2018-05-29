using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable()]
    public class Local
    {
        List<Producto> productos = new List<Producto>();
        List<OrdenCompra> ordenCompras = new List<OrdenCompra>();
        private string nombre;
        private string direccion;
        private bool despacho;
        private bool efectivo;
        private bool debito;
        private bool credito;
        private bool cheque;
        private string rutAdmin;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool Despacho { get => despacho; set => despacho = value; }
        public bool Efectivo { get => efectivo; set => efectivo = value; }
        public bool Debito { get => debito; set => debito = value; }
        public bool Credito { get => credito; set => credito = value; }
        public bool Cheque { get => cheque; set => cheque = value; }
        public string RutAdmin { get => rutAdmin; set => rutAdmin = value; }

        public Local(string Nombre, string Direccion, string RutAdmin, bool Despacho, bool Efectivo, bool Debito, bool Credito, bool Cheque)
        {
            nombre = Nombre;
            direccion = Direccion;
            rutAdmin = RutAdmin;
            despacho = Despacho;
            efectivo = Efectivo;
            debito = Debito;
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
            local.RutAdmin = local.RutAdmin.Replace("-", "");
            if (local.RutAdmin == administrador.rut)
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
        public bool agregarOdernCompra(OrdenCompra ordenCompra)
        {
            ordenCompras.Add(ordenCompra);
            return true;
        }

        public bool verificarProducto(string nombre)
        {
            foreach (Producto producto in productos)
            {
                if (nombre == producto.Nombre)
                {

                    return true;
                }
            }
            return false;
        }
        public List<Producto> GetProductos()
        {
            return this.productos;
        }



        public bool Eliminar(Local loc, string a)
        {
            
            foreach (Local lc in Listas.locales)
            {
                
                if (lc.Nombre == a)
                {
                    Listas.locales.Remove(lc);
                    return true;
                    
                }
            }

            foreach (Local lcU in Listas.localesU)
            {
                
                
                if (lcU.Nombre == a)
                {
                    Listas.localesU.Remove(lcU);
                    return true;
                    

                }
            }
            
            return false;

            
        }

        
    }
}
