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
            foreach (Padre p in Listas.DeserializarP("padres.dat"))
            {
                Listas.padres.Add(p);
            }
            foreach (Administrador a in Listas.DeserializarA("admin.dat"))
            {
                Listas.administradores.Add(a);
            }
            foreach (Cliente c in Listas.DeserializarC("cliente.dat"))
            {
                Listas.clientes.Add(c);
            }
            foreach (Local l in Listas.DeserializarL("local.dat"))
            {
                Listas.locales.Add(l);
            }
            foreach (Local l in Listas.DeserializarLU("localu.dat"))
            {
                Listas.localesU.Add(l);
            }
            
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Listas.SerializarP(Listas.padres);
            Listas.SerializarA(Listas.administradores);
            Listas.SerializarC(Listas.clientes);
            Listas.SerializarL(Listas.locales);
            Listas.SerializarLU(Listas.localesU);
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
                    break;

                }
            }
            foreach (Administrador a in Listas.administradores)
            {
                if (a.rut == textBox1.Text && a.contraseña == textBox2.Text)
                {
                    o++;
                    this.Hide();
                    Administrador1 administrador = new Administrador1(a,this);
                    administrador.Show();
                    break;
                }
            }

            foreach (Padre p in Listas.padres)
            {
                if (p.rut == textBox1.Text && p.contraseña == textBox2.Text)
                {
                    o++;
                    this.Hide();
                    Padre1 padre = new Padre1(this);
                    padre.Show();
                    break;

                }
            }
            if(o==0)
            {
                MessageBox.Show("Usuario no encontrado","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar registrar = new Registrar();
            registrar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
