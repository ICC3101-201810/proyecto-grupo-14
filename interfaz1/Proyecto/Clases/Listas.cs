using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable()]
    public static class Listas
    {
        public static List<Padre> padres = new List<Padre>();
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Administrador> administradores = new List<Administrador>();
        public static List<Local> locales = new List<Local>();
        public static List<OrdenCompra> OrdenesCompras = new List<OrdenCompra>();
        public static List<Banco> Cuentas = new List<Banco>();

        public static void SerializarP(List<Padre> plistaPersona)
        {

            FileStream _fs = new FileStream(@"..\..\docs\padres.dat", FileMode.Create);
            BinaryFormatter _formatter = new BinaryFormatter();
            _formatter.Serialize(_fs, plistaPersona);
            _fs.Close();
        }
        public static List<Padre> DeserializarP(string pArchivo)
        {
            if (File.Exists(@"..\..\docs\" + pArchivo) == true)
            {
                FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
                BinaryFormatter _formatter = new BinaryFormatter();
                List<Padre> _persona = _formatter.Deserialize(_fs) as List<Padre>;
                _fs.Close();
                return _persona;
            }
            return new List<Padre>();


        }
        public static void SerializarA(List<Administrador> plistaPersona)
        {
            FileStream _fs = new FileStream(@"..\..\docs\admin.dat", FileMode.Create);
            BinaryFormatter _formatter = new BinaryFormatter();
            _formatter.Serialize(_fs, plistaPersona);
            _fs.Close();
        }
        public static List<Administrador> DeserializarA(string pArchivo)
        {
            if (File.Exists(@"..\..\docs\" + pArchivo) == true)
            {
                FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
                BinaryFormatter _formatter = new BinaryFormatter();
                List<Administrador> _persona = _formatter.Deserialize(_fs) as List<Administrador>;
                _fs.Close();
                return _persona;
            }
            return new List<Administrador>();
        }
        public static void SerializarC(List<Cliente> plistaPersona)
        {
            FileStream _fs = new FileStream(@"..\..\docs\cliente.dat", FileMode.Create);
            BinaryFormatter _formatter = new BinaryFormatter();
            _formatter.Serialize(_fs, plistaPersona);
            _fs.Close();
        }
        public static List<Cliente> DeserializarC(string pArchivo)
        {
            if (File.Exists(@"..\..\docs\" + pArchivo) == true)
            {
                FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
                BinaryFormatter _formatter = new BinaryFormatter();
                List<Cliente> _persona = _formatter.Deserialize(_fs) as List<Cliente>;
                _fs.Close();
                return _persona;
            }
            return new List<Cliente>();
        }

        public static void SerializarL(List<Local> plistaPersona)
        {
            FileStream _fs = new FileStream(@"..\..\docs\local.dat", FileMode.Create);
            BinaryFormatter _formatter = new BinaryFormatter();
            _formatter.Serialize(_fs, plistaPersona);
            _fs.Close();
        }
        public static List<Local> DeserializarL(string pArchivo)
        {
            if (File.Exists(@"..\..\docs\" + pArchivo) == true)
            {
                FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
                BinaryFormatter _formatter = new BinaryFormatter();
                List<Local> _persona = _formatter.Deserialize(_fs) as List<Local>;
                _fs.Close();
                return _persona;
            }
            return new List<Local>();
        }
        public static void SerializarB(List<Banco> plistaPersona)
            {
                FileStream _fs = new FileStream(@"..\..\docs\banco.dat", FileMode.Create);
                BinaryFormatter _formatter = new BinaryFormatter();
                _formatter.Serialize(_fs, plistaPersona);
                _fs.Close();
            }
        public static List<Banco> DeserializarB(string pArchivo)
            {
                if (File.Exists(@"..\..\docs\" + pArchivo) == true)
                {
                    FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
                    BinaryFormatter _formatter = new BinaryFormatter();
                    List<Banco> _persona = _formatter.Deserialize(_fs) as List<Banco>;
                    _fs.Close();
                    return _persona;
                }
                return new List<Banco>();
            }
        } 
}
