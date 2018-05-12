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
    public partial class EditarProductos : Form
    {
        public EditarProductos()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Editar Producto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Local local in Listas.locales)
            {
                if (local.rutAdmin == textBox6.Text)
                {
                    List<Producto> productos = local.GetProductos();
                    foreach (Producto producto in productos)
                    {
                        if (textBox1.Text == producto.nombre)
                        {
                            i++;
                            textBox2.Enabled = true;
                            label2.Enabled = true;
                            textBox3.Enabled = true;
                            label3.Enabled = true;
                            textBox4.Enabled = true;
                            label4.Enabled = true;
                            label5.Enabled = true;
                            textBox5.Enabled = true;
                            button2.Enabled = true;
                        }
                    }
                }
            }
            foreach (Local local in Listas.localesU)
            {
                if (local.rutAdmin == textBox6.Text)
                {
                    List<Producto> productos = local.GetProductos();
                    foreach (Producto producto in productos)
                    {
                        if (textBox1.Text == producto.nombre)
                        {
                            textBox2.Enabled = true;
                            label2.Enabled = true;
                            textBox3.Enabled = true;
                            label3.Enabled = true;
                            textBox4.Enabled = true;
                            label4.Enabled = true;
                            label5.Enabled = true;
                            textBox5.Enabled = true;
                            button2.Enabled = true;
                        }
                    }
                }
            }
            if (i == 0)
            {
                textBox2.Enabled = false;
                label2.Enabled = false;
                textBox3.Enabled = false;
                label3.Enabled = false;
                textBox4.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                textBox5.Enabled = false;
                button2.Enabled = false;
                MessageBox.Show("Local no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach(Local local in Listas.locales)
                {
                    if(local.rutAdmin == textBox6.Text)
                    {
                        List<Producto> productos = local.GetProductos();
                        int precio = Int32.Parse(textBox4.Text);
                        int stock = Int32.Parse(textBox5.Text);
                        Producto producto = new Producto(textBox2.Text, textBox3.Text, precio, stock);
                        productos.Add(producto);
                        local.EliminarProducto(productos, textBox6.Text, textBox1.Text);
                        MessageBox.Show("Producto Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
                foreach (Local local in Listas.locales)
                {
                    if (local.rutAdmin == textBox6.Text)
                    {
                        List<Producto> productos = local.GetProductos();
                        int precio = Int32.Parse(textBox4.Text);
                        int stock = Int32.Parse(textBox5.Text);
                        Producto producto = new Producto(textBox2.Text, textBox3.Text, precio, stock);
                        productos.Add(producto);
                        local.EliminarProducto(productos, textBox6.Text, textBox1.Text);
                        MessageBox.Show("Producto Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
            }
            
        }
    }
}
