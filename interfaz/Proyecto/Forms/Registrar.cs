using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Registro Nuevo Usuario";
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                textBox4.Enabled = true;
                label6.Enabled = true;
            }
            else if (checkBox3.Checked == false)
            {
                textBox4.Enabled = false;
                label6.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox4.Text = "";
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox4.Text = "";
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void Listo_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string a1 = textBox3.Text;
            Usuario u = new Usuario(a, a1);
            if (u.verificarRut(a) == false)
            {
                MessageBox.Show("Rut invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }

            if (u.VerificadorUsuario(Listas.clientes, Listas.administradores, Listas.padres, a, a1) == true)
            {
                MessageBox.Show("Usuario ya existente","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox3.Text = "";
            }

            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked ==false)
            {
                MessageBox.Show("Seleccione una opcion de usuario para poder continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (checkBox3.Checked== true && textBox4.Text=="")
            {
<<<<<<< HEAD
                MessageBox.Show("Complete todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
=======
                MessageBox.Show("Complete todos los campos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> 1f1396be5c4a8c3b2564256b3ee45314413b89c6
            }
            
            else
            {
                if(checkBox1.Checked==true)
                {
                    string rut = textBox1.Text;
                    string nombre = textBox2.Text;
                    string contraseña = textBox3.Text;
                    Padre padre = new Padre(rut, nombre, contraseña);
                    Listas.padres.Add(padre);


                    MessageBox.Show("Padre creado satisfactoriamente","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 menu = new Form1();
                    menu.Show();

                }
                else if (checkBox2.Checked == true)
                {
                    string rut = textBox1.Text;
                    string nombre = textBox2.Text;
                    string contraseña = textBox3.Text;
                    Administrador administrador = new Administrador(rut, nombre, contraseña);
                    Listas.administradores.Add(administrador);


                    MessageBox.Show("Admnistrador creado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 menu = new Form1();
                    menu.Show();

                }
                else if (checkBox3.Checked == true)
                {
                    string rut = textBox1.Text;
                    string nombre = textBox2.Text;
                    string contraseña = textBox3.Text;
                    string efectivo1 = textBox4.Text;
                    int efectivo = Int32.Parse(efectivo1);
                    Cliente cliente = new Cliente(rut, nombre, contraseña, efectivo);
                    Listas.clientes.Add(cliente);


                    MessageBox.Show("Cliente creado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 menu = new Form1();
                    menu.Show();

                }

            }
            
        }
    }
}
