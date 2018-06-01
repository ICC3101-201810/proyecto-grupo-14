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
    public partial class editarProducto : Form
    {
        Administrador current;
        public editarProducto(Administrador a)
        {
            this.current = a;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Editar Producto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            foreach (Local local in Listas.locales)
            {
                if (local.RutAdmin == current.Rut)
                {
                    List<Producto> productos = local.GetProductos();
                    foreach (Producto producto in productos)
                    {
                        if (producto.Nombre==textBox1.Text)
                        {
                            c++;
                            label6.Enabled = true;
                            checkBox1.Enabled = true;
                            checkBox2.Enabled = true;
                            checkBox3.Enabled = true;
                            checkBox4.Enabled = true;
                            button2.Enabled = true;
                        }
                    }
                }
            }
            if (c == 0)
            {
                label6.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                button2.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                MessageBox.Show("No se ha encontrado el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                label2.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label3.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                label3.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label4.Enabled = true;
                textBox4.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label5.Enabled = true;
                textBox5.Enabled = true;
            }
            else
            {
                label5.Enabled = false;
                textBox5.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Local local in Listas.locales)
            {
                if (local.RutAdmin == current.Rut)
                {
                    List<Producto> productos = local.GetProductos();
                    foreach (Producto producto in productos)
                    {
                        if (producto.Nombre == textBox1.Text)
                        {
                            if (checkBox1.Checked == true)
                            {
                                producto.Nombre = textBox2.Text;
                            }
                            if (checkBox2.Checked == true)
                            {
                                producto.Marca = textBox3.Text;
                            }
                            if (checkBox3.Checked == true)
                            {
                                int precio = Int32.Parse(textBox4.Text);
                                producto.Precio = precio;
                            }
                            if (checkBox4.Checked == true)
                            {
                                int stock = Int32.Parse(textBox5.Text);
                                producto.Stock = stock;
                            }
                        }
                    }
                }
            }
            
            MessageBox.Show("Producto editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
