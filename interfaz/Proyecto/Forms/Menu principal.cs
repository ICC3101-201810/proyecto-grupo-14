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
            this.CenterToScreen();
            this.Text = "Menu Principal";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.Open("padres.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, Listas.padres);
            }
            using (Stream stream = File.Open("clientes.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, Listas.clientes);
            }
            using (Stream stream = File.Open("administradores.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, Listas.administradores);
            }
            using (Stream stream = File.Open("locales.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, Listas.locales);
            }
            using (Stream stream = File.Open("localesU.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, Listas.localesU);
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
