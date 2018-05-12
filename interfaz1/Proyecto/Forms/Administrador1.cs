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
    public partial class Administrador1 : Form
    {
        public Administrador1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Administrador";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contraseña contraseña = new Contraseña();
            contraseña.Show();
            label1.Visible = false;
            textBox1.Visible = false;
            listView1.Visible = false;
            button1.Visible = false;
        }

        private void agregarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProducto ag = new AgregarProducto();
            ag.Show();
            label1.Visible = false;
            textBox1.Visible = false;
            listView1.Visible = false;
            button1.Visible = false;
        }

        private void verLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Local local in Listas.locales)
            {
                if (local.rutAdmin == textBox1.Text)
                {
                    label1.Visible = false;
                    textBox1.Visible = false;
                    button1.Visible = false;
                    listView1.Visible = true;
                    listView1.Items.Clear();
                    List<Producto> productos = local.GetProductos();
                    foreach (Producto producto in productos)
                    {
                        ListViewItem item = new ListViewItem();
                        item = listView1.Items.Add(producto.nombre);
                        item.SubItems.Add(producto.marca);
                        item.SubItems.Add(producto.precio.ToString());
                        item.SubItems.Add(producto.stock.ToString());
                    }
                }
            }
            label1.Visible = true;
            textBox1.Visible = true;
            foreach (Local local in Listas.localesU)
            {
                if (local.rutAdmin == textBox1.Text)
                {
                    listView1.Visible = true;
                    listView1.Items.Clear();
                    List<Producto> productos = local.GetProductos();
                    foreach (Producto producto in productos)
                    {
                        ListViewItem item = new ListViewItem();
                        item = listView1.Items.Add(producto.nombre);
                        item.SubItems.Add(producto.marca);
                        item.SubItems.Add(producto.precio.ToString());
                        item.SubItems.Add(producto.stock.ToString());
                    }
                }
            }
        }

        private void editarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
