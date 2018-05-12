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
    public partial class EditarLocal : Form
    {
        public EditarLocal()
        {
            InitializeComponent();
            this.Text = "Editar local";
            this.CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Local la in Listas.locales)
            {
                if (la.nombre == textBox1.Text)
                {
                    textBox2.Enabled = true;
                    label2.Enabled = true;
                    textBox3.Enabled = true;
                    label3.Enabled = true;
                    textBox4.Enabled = true;
                    label4.Enabled = true;
                    label5.Enabled = true;
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    button2.Enabled = true;


                }
                else
                {
                    textBox2.Enabled = false;
                    label2.Enabled = false;
                    textBox3.Enabled = false;
                    label3.Enabled = false;
                    textBox4.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox5.Enabled = false;
                    button2.Enabled = false;
                    MessageBox.Show("Local no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            foreach (Local laU in Listas.localesU)
            {
                if (laU.nombre == textBox1.Text)
                {
                    textBox2.Enabled = true;
                    label2.Enabled = true;
                    textBox3.Enabled = true;
                    label3.Enabled = true;
                    textBox4.Enabled = true;
                    label4.Enabled = true;
                    label5.Enabled = true;
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    button2.Enabled= true;
                }
                else
                {
                    textBox2.Enabled = false;
                    label2.Enabled = false;
                    textBox3.Enabled = false;
                    label3.Enabled = false;
                    textBox4.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox5.Enabled = false;
                    button2.Enabled =false;
                    MessageBox.Show("Local no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            Local locla = new Local(textBox2.Text, textBox3.Text, textBox4.Text, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked);
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
            {
                MessageBox.Show("Seleccione al menos 1 metodo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (textBox3.Text == "Monseñor...")
                {
                    Local local = new Local(textBox2.Text, textBox3.Text, textBox4.Text, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked);
                    Listas.localesU.Add(local);
                    local.Eliminar(local, textBox1.Text);
                    MessageBox.Show("Local Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    Local local = new Local(textBox2.Text, textBox3.Text, textBox4.Text, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked);
                    Listas.locales.Add(local);
                    local.Eliminar(local, textBox1.Text);
                    MessageBox.Show("Local Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
            }
        }
    }
    }

