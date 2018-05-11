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
    public partial class AgregarLocal : Form
    {
        public AgregarLocal()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Agregar Local";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox3.Text=="" || textBox2.Text=="" || textBox1.Text=="")
            {
                MessageBox.Show("Complete todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (checkBox2.Checked==false && checkBox3.Checked==false && checkBox4.Checked==false && checkBox5.Checked==false)
            {
                MessageBox.Show("Seleccione al menos 1 metodo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
                
            else
            {
            bool despacho = false;
            bool efectivo = false;
            bool debito = false;
            bool credito = false;
            bool cheque = false;
            if (checkBox1.Checked == true)
            {
                despacho = true;
            }
            if (checkBox2.Checked== true)
            {
                efectivo = true;
            }

            if (checkBox3.Checked == true)
            {
                credito = true;
            }
            if(checkBox4.Checked== true)
            {
                debito = true;
            }
            if(checkBox5.Checked== true)
            {
                cheque = true;
            }

                if (textBox3.Text == "Monseñor...")
                {
                    Local local = new Local(textBox1.Text, textBox3.Text, textBox2.Text, despacho, efectivo, debito, credito, cheque);
                    Listas.localesU.Add(local);
                    MessageBox.Show("Local Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    Local local = new Local(textBox1.Text, textBox3.Text, textBox2.Text, despacho, efectivo, debito, credito, cheque);
                    Listas.locales.Add(local);
                    MessageBox.Show("Local Agregado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();

                }
            }
            
            

            
        }
    }
}
