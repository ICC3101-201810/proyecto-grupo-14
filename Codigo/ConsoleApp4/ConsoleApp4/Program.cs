using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Test.txt");
                List<Padre> padres = new List<Padre>();
                List<Cliente> clientes = new List<Cliente>();
                List<Administrador> administradores = new List<Administrador>();
                List<Local> locales = new List<Local>();
                List<Local> localesU = new List<Local>();
                Console.BackgroundColor = ConsoleColor.White;
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Bienvenido");
                    Console.WriteLine("1.- Usuario nuevo");
                    Console.WriteLine("2.- Usuario existente");
                    Console.WriteLine("3.- Salir");
                    string respuesta = Console.ReadLine();
                    if (respuesta == "1")
                    {
                        Console.WriteLine("Ingrese si usted es padre(1), administrador(2) o cliente(3)");
                        string respuesta1 = Console.ReadLine();
                        while (respuesta1 == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Ingrese rut valido (sin punto y con guión): ");
                            string rut = Console.ReadLine();
                            Console.WriteLine("Ingrese nombre: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese contraseña: ");
                            string contraseña = Console.ReadLine();
                            Padre padre = new Padre(rut, nombre, contraseña);
                            if (padre.verificarRut(rut) == false)
                            {
                                Console.Beep();
                                Console.Beep();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Rut invalido");
                                continue;
                            }
                            padres.Add(padre);
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Padre añadido");
                            sw.WriteLine("Se ha creado el usuario Padre: "
                                + padre.rut + ", " + padre.nombre + ", " + padre.contraseña +
                                ", a la hora: " + DateTime.Now);
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        }
                        while (respuesta1 == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Ingrese rut valido (sin punto y con guión): ");
                            string rut = Console.ReadLine();
                            Console.WriteLine("Ingrese nombre: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese contraseña: ");
                            string contraseña = Console.ReadLine();
                            Administrador administrador = new Administrador(rut, nombre, contraseña);
                            if (administrador.verificarRut(rut) == false)
                            {
                                Console.Beep();
                                Console.Beep();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Rut invalido");
                                continue;
                            }
                            administradores.Add(administrador);
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Administrador añadido");
                            sw.WriteLine("Se ha creado el usuario Administrador: "
                                + administrador.rut + ", " + administrador.nombre + ", " + administrador.contraseña +
                                ", a la hora: " + DateTime.Now);
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        }
                        while (respuesta1 == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Ingrese rut valido (sin punto y con guión): ");
                            string rut = Console.ReadLine();
                            Console.WriteLine("Ingrese nombre: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese contraseña: ");
                            string contraseña = Console.ReadLine();
                            Console.WriteLine("Ingrese suma de dinero: ");
                            string dinero1 = Console.ReadLine();
                            int dinero = Int32.Parse(dinero1);
                            Cliente cliente = new Cliente(rut, nombre, contraseña, dinero);
                            if (cliente.verificarRut(rut) == false)
                            {
                                Console.Beep();
                                Console.Beep();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Rut invalido");
                                continue;
                            }
                            clientes.Add(cliente);
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Cliente añadido");
                            sw.WriteLine("Se ha creado el usuario Cliente: "+
                                cliente.rut + ", " + cliente.nombre + ", " + cliente.contraseña + ", " + cliente.dinero +
                                ", a la hora: " + DateTime.Now);
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        }
                    }
                    while (respuesta == "2")
                    {
                        int s = 0;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ingrese rut valido (sin punto y con guión): ");
                        string rut = Console.ReadLine();
                        Console.WriteLine("Ingrese contraseña: ");
                        string contraseña = Console.ReadLine();
                        Usuario usuario = new Usuario(rut, contraseña);
                        if (usuario.verificarRut(rut) == false)
                        {
                            Console.Beep();
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Rut invalido");
                            continue;
                        }
                        foreach (Padre padre in padres)
                        {
                            if (padre.verificarPadre(usuario, padre) == true)
                            {
                                s++;
                                Console.Beep();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("El usuario es valido");
                                sw.WriteLine("El Padre: "+padre.nombre+", rut: "+padre.rut+", ha ingresado a la hora: "+DateTime.Now);
                                while (true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Bienvenido padre " + padre.nombre);
                                    Console.WriteLine("1.- Agregar Local");
                                    Console.WriteLine("2.- Ver locales");
                                    Console.WriteLine("3.- Cerrar sesión");
                                    string respuesta1 = Console.ReadLine();
                                    if (respuesta1 == "1")
                                    {
                                        Console.WriteLine("Ingrese nombre: ");
                                        string nombre = Console.ReadLine();
                                        Console.WriteLine("Ingrese direccion: ");
                                        string direccion = Console.ReadLine();
                                        Console.WriteLine("Ingrese rut del administrador: ");
                                        string rutAdmin = Console.ReadLine();
                                        Console.WriteLine("Ingrese si el local tendrá despacho (1) o no (otra tecla): ");
                                        string despacho1 = Console.ReadLine();
                                        bool despacho = true;
                                        if (despacho1 == "1")
                                        {
                                            despacho = true;
                                        }
                                        else { despacho = false; }
                                        Console.WriteLine("Ingrese si el local acepta efectivo (1) o no (otra tecla): ");
                                        string efectivo1 = Console.ReadLine();
                                        bool efectivo = true;
                                        if (efectivo1 == "1")
                                        {
                                            efectivo = true;
                                        }
                                        Console.WriteLine("Ingrese si el local acepta debito (1) o no (otra tecla): ");
                                        string debito1 = Console.ReadLine();
                                        bool debito = true;
                                        if (debito1 == "1")
                                        {
                                            debito = true;
                                        }
                                        else { debito = false; }
                                        Console.WriteLine("Ingrese si el local acepta credito (1) o no (otra tecla): ");
                                        string credito1 = Console.ReadLine();
                                        bool credito = true;
                                        if (credito1 == "1")
                                        {
                                            credito = true;
                                        }
                                        else { credito = false; }
                                        Console.WriteLine("Ingrese si el local acepta cheque (1) o no (otra tecla): ");
                                        string cheque1 = Console.ReadLine();
                                        bool cheque = true;
                                        if (cheque1 == "1")
                                        {
                                            cheque = true;
                                        }
                                        else { cheque = false; }
                                        Local local = new Local(nombre, direccion, rutAdmin, despacho, efectivo, debito, credito, cheque);
                                        if (local.validarRutAdmin(rutAdmin) == false)
                                        {
                                            Console.Beep();
                                            Console.Beep();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Rut invalido");
                                            continue;
                                        }
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        if (local.perteneceUniversidad(direccion) == true)
                                        {
                                            localesU.Add(local);
                                            Console.Beep();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Local de Universidad añadido");
                                            sw.WriteLine("El Padre: "+padre.nombre+", rut: "+padre.rut+", ha añadidio un nuevo local de Universidad a la hora: "+DateTime.Now);
                                            sw.WriteLine("El Local: "+local.nombre+", "+local.direccion+", "+local.rutAdmin+", "+local.despacho+", "
                                                +local.efectivo+", "+local.debito+", "+local.credito+", "+local.cheque+", ha sido añadido");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                        }
                                        else
                                        {
                                            locales.Add(local);
                                            Console.Beep();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Local añadido");
                                            sw.WriteLine("El Padre: "+padre.nombre+", rut: "+padre.rut+", ha añadidio un nuevo local a la hora: "+DateTime.Now);
                                            sw.WriteLine("El Local: "+local.nombre+", "+local.direccion+", "+local.rutAdmin+", "+local.despacho+", "
                                                +local.efectivo+", "+local.debito+", "+local.credito+", "+local.cheque+", ha sido añadido");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                        }
                                    }
                                    else if (respuesta1 == "2")
                                    {
                                        foreach (Local local in locales)
                                        {
                                            Console.WriteLine("Locales afuera de la Universidad: ");
                                            local.verInfo();
                                        }
                                        foreach (Local local in localesU)
                                        {
                                            Console.WriteLine("Locales dentro de la Universidad: ");
                                            local.verInfo();
                                        }
                                    }
                                    else if (respuesta1 == "3")
                                    {
                                        Console.Beep();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Sesión cerrada");
                                        sw.WriteLine("El Padre: "+padre.nombre+", rut: "+padre.rut+", ha cerrado sesión a la hora: "+DateTime.Now);
                                        break;
                                    }

                                }
                                break;
                            }
                        }
                        foreach (Administrador administrador in administradores)
                        {
                            if (administrador.verificarAdministrador(usuario, administrador) == true)
                            {
                                s++;
                                int o = 0;
                                Console.Beep();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("El usuario es valido");
                                sw.WriteLine("El Administrador: "+administrador.nombre+", rut: "+administrador.rut+", ha ingresado a la hora: "+DateTime.Now);
                                foreach (Local local in locales)
                                {
                                    if (local.verificarAdministradorLocal(local, administrador) == true)
                                    {
                                        o++;
                                        while (true)
                                        {
                                            o++;
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("Bienvenido administrador " + administrador.nombre);
                                            Console.WriteLine("Dueño del local: " + local.nombre);
                                            Console.WriteLine("1.- Agregar Stock");
                                            Console.WriteLine("2.- Ver local");
                                            Console.WriteLine("3.- Cerrar sesión");
                                            string respuesta1 = Console.ReadLine();
                                            if (respuesta1 == "1")
                                            {
                                                Console.WriteLine("Ingrese nombre del producto: ");
                                                string nombre = Console.ReadLine();
                                                Console.WriteLine("Ingrese marca del producto: ");
                                                string marca = Console.ReadLine();
                                                Console.WriteLine("Ingrese precio del producto: ");
                                                string precio1 = Console.ReadLine();
                                                int precio = Int32.Parse(precio1);
                                                Console.WriteLine("Ingrese stock del producto: ");
                                                string stock1 = Console.ReadLine();
                                                int stock = Int32.Parse(stock1);
                                                Producto producto = new Producto(nombre, marca, precio, stock);
                                                local.agregarProducto(producto);
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Poducto agregado");
                                                sw.WriteLine("El Administrador: "+administrador.nombre+", rut:"+administrador.rut+", ha agregado un nuevo producto a la hora: "+DateTime.Now);
                                                sw.WriteLine("El Producto: "+producto.nombre+", "+producto.marca+", "+producto.precio+", "+producto.stock+", ha sido agregado" );

                                            }
                                            else if (respuesta1 == "2")
                                            {
                                                Console.WriteLine("Información del local: ");
                                                local.verInfo();
                                                Console.WriteLine("Stock: ");
                                                local.verProductos();
                                            }
                                            else if (respuesta1 == "3")
                                            {
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Sesión cerrada");
                                                sw.WriteLine("El Administrador: "+administrador.nombre+", rut: "+administrador.rut+", ha cerrado sesión a la hora: "+DateTime.Now);
                                                break;
                                            }
                                        }
                                    }
                                }
                                foreach (Local local in localesU)
                                {
                                    if (local.verificarAdministradorLocal(local, administrador) == true)
                                    {
                                        o++;
                                        while (true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("Bienvenido administrador " + administrador.nombre);
                                            Console.WriteLine("Dueño del local: " + local.nombre);
                                            Console.WriteLine("1.- Agregar Stock");
                                            Console.WriteLine("2.- Ver local");
                                            Console.WriteLine("3.- Cerrar sesión");
                                            string respuesta1 = Console.ReadLine();
                                            if (respuesta1 == "1")
                                            {
                                                Console.WriteLine("Ingrese nombre del producto: ");
                                                string nombre = Console.ReadLine();
                                                Console.WriteLine("Ingrese marca del producto: ");
                                                string marca = Console.ReadLine();
                                                Console.WriteLine("Ingrese precio del producto: ");
                                                string precio1 = Console.ReadLine();
                                                int precio = Int32.Parse(precio1);
                                                Console.WriteLine("Ingrese stock del producto: ");
                                                string stock1 = Console.ReadLine();
                                                int stock = Int32.Parse(stock1);
                                                Producto producto = new Producto(nombre, marca, precio, stock);
                                                local.agregarProducto(producto);
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Poducto agregado");
                                                sw.WriteLine("El Administrador: "+administrador.nombre+", rut:"+administrador.rut+", ha agregado un nuevo producto a la hora: "+DateTime.Now);
                                                sw.WriteLine("El Producto: "+producto.nombre+", "+producto.marca+", rut:"+producto.precio+", "+producto.stock+", ha sido agregado" );

                                            }
                                            else if (respuesta1 == "2")
                                            {
                                                Console.WriteLine("Información del local: ");
                                                local.verInfo();
                                                Console.WriteLine("Stock: ");
                                                local.verProductos();
                                            }
                                            else if (respuesta1 == "3")
                                            {
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Sesión cerrada");
                                                sw.WriteLine("El Administrador: "+administrador.nombre+", rut: "+administrador.rut+", ha cerrado sesión a la hora: "+DateTime.Now);
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (o == 0)
                                {
                                    Console.Beep();
                                    Console.Beep();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("El rut del administrador no está asociado a ningún local");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }
                                break;
                            }
                        }
                        foreach (Cliente cliente in clientes)
                        {
                            if (cliente.verificarCliente(usuario, cliente) == true)
                            {
                                s++;
                                Console.Beep();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("El usuario es valido");
                                sw.WriteLine("El Cliente: ",cliente.nombre+", "+cliente.rut+", ha ingresado a la hora: "+DateTime.Now);
                                while(true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Bienvenido cliente " + cliente.nombre);
                                    Console.WriteLine("1.- Comprar");
                                    Console.WriteLine("2.- Ver estado de cuenta");
                                    Console.WriteLine("3.- Cerrar sesión");
                                    string respuesta1 = Console.ReadLine();
                                    if (respuesta == "2")
                                    {
                                        Console.WriteLine("Su cuenta actual posee: $" + cliente.dinero);
                                    }
                                    else if(respuesta1 == "3")
                                    {
                                        Console.Beep();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Sesión cerrada");
                                        sw.WriteLine("El Cliente: ", cliente.nombre + ", " + cliente.rut + ", ha cerrado sesión a la hora: " + DateTime.Now);
                                    }

                                    while (respuesta1=="1")
                                    {
                                        Console.WriteLine("Seleccionar local :\n1.- Locales dentro de la universidad\n2.- Locales fuera de la universidad");
                                        Console.WriteLine("3.- Volver al menu");
                                        string respuesta2 = Console.ReadLine();
                                        while(respuesta2=="1")
                                        {
                                            int r=0;
                                            foreach(Local local in localesU)
                                            {
                                                local.verInfo();
                                            }
                                            Console.WriteLine("Ingrese nombre local deseado:");
                                            string respuesta3=Console.ReadLine();
                                            foreach(Local local in localesU)
                                            {
                                                
                                                while(respuesta3==local.nombre)
                                                {
                                                    r++;
                                                    Console.WriteLine("Bienvenido a "+ local.nombre );
                                                    Console.WriteLine("1.- Ver Lista de productos");
                                                    Console.WriteLine("2.- Comprar ");
                                                    Console.WriteLine("3.- Volver a seleccionar local");
                                                    string respuesta4 = Console.ReadLine();
                                                    if(respuesta3=="1")
                                                    {
                                                        local.verProductos();
                                                    }
                                                    else if(respuesta3=="3")
                                                    {
                                                        Console.Beep();
                                                        break;
                                                    }
                                                    while(respuesta3=="2")
                                                    {

                                                    }

                                                }
                                                
                                            }
                                            if(r==0)
                                            {
                                                Console.Beep();
                                                Console.Beep();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("El nombre ingresado no pertenece a ningun local");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                continue;
                                            }
                                            break;
                                            


                                        }

                                        if (respuesta2=="3")
                                        {
                                            Console.Beep();
                                            break;
                                        }
                                    } 
                                }
                            }
                        }
                        if (s == 0)
                        {
                            Console.Beep();
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Usuario o contraseña invalida");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Desea ir al menu principal? si(1), no(otro)");
                            string r = Console.ReadLine();
                            if (r == "1")
                            {
                                break;
                            }
                            continue;
                        }
                        break;
                    }
                    if (respuesta == "3")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Programa finalizado");
                        break;
                    }

                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
