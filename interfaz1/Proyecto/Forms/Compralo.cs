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
        Local currentL;
        Cliente current;
        Usuario currentU;
        Banco currentb;
        LocalesU parentWindow;
        float total;
        public Compralo(Local l, Cliente a, Banco c, LocalesU parentWindow)
        {
            this.currentL = l;
            this.parentWindow = parentWindow;
            this.currentb = c;
            this.current = a;
            this.currentU = (Usuario)current;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Compralo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Producto local in currentL.GetProductos())
            {
                    ListViewItem item = new ListViewItem();
                    item = listView1.Items.Add(local.Nombre);
                    item.SubItems.Add(local.Marca);
                    item.SubItems.Add(local.Precio.ToString());
                    item.SubItems.Add(local.Stock.ToString());
                    total += local.Precio;
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
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
                foreach (Local lq in Listas.locales)
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
            Forms.Metodo_de_pago mt = new Forms.Metodo_de_pago(current,currentb,total,this);
            mt.Show();
        }

        private void Compralo_Load(object sender, EventArgs e)
        {

        }

        private void Compralo_Load_1(object sender, EventArgs e)
        {

        }
        string nombre;
        string marca;
        int cantidad;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            nombre = maskedTextBox1.Text;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            marca = maskedTextBox2.Text;
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cantidad = Int32.Parse(maskedTextBox3.Text);
        }
    }
}
