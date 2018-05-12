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
        public static List<Local> localesU = new List<Local>();
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
            FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
            BinaryFormatter _formatter = new BinaryFormatter();
            List<Padre> _persona = _formatter.Deserialize(_fs) as List<Padre>;
            _fs.Close();
            return _persona;
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
            FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
            BinaryFormatter _formatter = new BinaryFormatter();
            List<Administrador> _persona = _formatter.Deserialize(_fs) as List<Administrador>;
            _fs.Close();
            return _persona;
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
            FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
            BinaryFormatter _formatter = new BinaryFormatter();
            List<Cliente> _persona = _formatter.Deserialize(_fs) as List<Cliente>;
            _fs.Close();
            return _persona;
        }
        public static void SerializarLU(List<Local> plistaPersona)
        {
            FileStream _fs = new FileStream(@"..\..\docs\localu.dat", FileMode.Create);
            BinaryFormatter _formatter = new BinaryFormatter();
            _formatter.Serialize(_fs, plistaPersona);
            _fs.Close();
        }
        public static List<Local> DeserializarLU(string pArchivo)
        {
            FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
            BinaryFormatter _formatter = new BinaryFormatter();
            List<Local> _persona = _formatter.Deserialize(_fs) as List<Local>;
            _fs.Close();
            return _persona;
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
            FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
            BinaryFormatter _formatter = new BinaryFormatter();
            List<Local> _persona = _formatter.Deserialize(_fs) as List<Local>;
            _fs.Close();
            return _persona;
        }
    }
}
