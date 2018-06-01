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
    public partial class AgregarProducto : Form
    {
        Administrador current;
        public AgregarProducto(Administrador a)
        {
            this.current = a;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Agegar Producto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Local local in Listas.locales)
            {
                if (local.RutAdmin == current.rut)
                {
                    i++;
                    int precio = Int32.Parse(textBox3.Text);
                    int stock = Int32.Parse(textBox4.Text);
                    Producto producto = new Producto(textBox1.Text, textBox2.Text, precio, stock);
                    local.agregarProducto(producto);
                    MessageBox.Show("Producto agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            foreach (Local local in Listas.locales)
            {
                if (local.RutAdmin == current.rut)
                {
                    i++;
                    int precio = Int32.Parse(textBox3.Text);
                    int stock = Int32.Parse(textBox4.Text);
                    Producto producto = new Producto(textBox1.Text, textBox2.Text, precio, stock);
                    local.agregarProducto(producto);
                    MessageBox.Show("Producto agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            if(i == 0)
            {
                MessageBox.Show("No se ha podido agregar el produco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }



        }
    }
}
