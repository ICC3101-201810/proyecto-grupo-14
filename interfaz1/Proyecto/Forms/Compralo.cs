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
    public partial class Compralo : Form
    {
        public Compralo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ar = 0;
            foreach (Local loca in Listas.localesU)
            {
                if (textBox1.Text == loca.RutAdmin)
                {
                    ar += 1;
                    label2.Enabled = true;
                    textBox2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                }
            }
            if (ar == 1)
            {
                label2.Enabled = false;
                textBox2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                MessageBox.Show("Local no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Local lq in Listas.localesU)
            {
                if (textBox1.Text == lq.RutAdmin)
                {
                    listView1.Visible = true;
                    List<Producto> pq = lq.GetProductos();
                    foreach (Producto local in pq)
                    {
                        ListViewItem item = new ListViewItem();
                        item = listView1.Items.Add(local.Nombre);
                        item.SubItems.Add(local.Marca);
                        item.SubItems.Add(local.Precio.ToString());
                        item.SubItems.Add(local.Stock.ToString());

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente1 c = new Cliente1();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como no  pudimos agregar a la lista OrdenCompra no se puede desplegar");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ingrese nombre de un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Local lq in Listas.localesU)
                {
                    if (textBox1.Text == lq.RutAdmin)
                    {

                        List<Producto> pq = lq.GetProductos();
                        MessageBox.Show("No pudimos agregar a la lista OrdenCompra");

                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Metodo_de_pago mt = new Forms.Metodo_de_pago();
            mt.Show();
        }

        private void Compralo_Load(object sender, EventArgs e)
        {

        }
    }
}
