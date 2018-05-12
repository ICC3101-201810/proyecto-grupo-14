using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\Bancos.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    Listas.Cuentas = (List<Banco>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\Ordenes.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    Listas.OrdenesCompras = (List<OrdenCompra>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\padres.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    Listas.padres = (List<Padre>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\clientes.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    Listas.clientes = (List<Cliente>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\administradores.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    Listas.administradores = (List<Administrador>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\locales.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    Listas.locales = (List<Local>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\localesU.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    Listas.localesU = (List<Local>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            this.CenterToScreen();
            this.Text = "Menu Principal";
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\padres.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Listas.padres);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\Ordenes.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Listas.OrdenesCompras);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\Bancos.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Listas.Cuentas);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\clientes.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Listas.clientes);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\administradores.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Listas.administradores);
                }
            }
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\locales.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Listas.locales);
                }
            }
            
            catch (IOException)
            {
            }
            try
            {
                using (Stream stream = File.Open(@"\..\..\docs\localesU.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Listas.localesU);
                }
            }
            catch (IOException)
            {
            }
            Application.Exit();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            int o = 0;
            foreach(Cliente c in Listas.clientes)
            {
                if(c.rut==textBox1.Text && c.contraseña== textBox2.Text)
                {
                    o++;
                    this.Hide();
                    Cliente1 cliente = new Cliente1();
                    cliente.Show();

                }
            }
            foreach (Administrador a in Listas.administradores)
            {
                if (a.rut == textBox1.Text && a.contraseña == textBox2.Text)
                {
                    o++;
                    this.Hide();
                    Administrador1 administrador = new Administrador1();
                    administrador.Show();
                }
            }

            foreach (Padre p in Listas.padres)
            {
                if (p.rut == textBox1.Text && p.contraseña == textBox2.Text)
                {
                    o++;
                    this.Hide();
                    Padre1 padre = new Padre1();
                    padre.Show();

                }
            }
            if(o==0)
            {
                MessageBox.Show("Usuario no encontrado","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar registrar = new Registrar();
            registrar.Show();
        }
    }
}
