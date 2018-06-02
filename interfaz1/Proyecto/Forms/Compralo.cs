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
        List<Producto> sq = new List<Producto>();
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
            ListViewItem item = new ListViewItem();
            listView1.Items.Clear();
            foreach (Producto local in currentL.GetProductos())
            {
                    item = listView1.Items.Add(local.Nombre);
                    item.SubItems.Add(local.Marca);
                    item.SubItems.Add(local.Precio.ToString());
                    item.SubItems.Add(local.Stock.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentWindow.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como no  pudimos agregar a la lista OrdenCompra no se puede desplegar");
        }

        string nombre;
        string marca;
        int cantidad;
        ListViewItem item = new ListViewItem();

        private void button4_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            marca = textBox2.Text;
            nombre = textBox1.Text;
            cantidad = Int32.Parse(textBox3.Text);
            int cq = 0;
            foreach (Producto p in currentL.GetProductos())
            {
                if (nombre == p.Nombre && p.Marca == marca && p.Stock != 0 && p.Stock >= cantidad)
                {
                    cq++;
                    sq.Add(p);
                    break;

                }

            }
            if (cq == 0) { MessageBox.Show("No se encuentra el producto"); }

            foreach (Producto p in sq)
            {
                item = listView2.Items.Add(p.Nombre);
                item.SubItems.Add(p.Marca);
                item.SubItems.Add(p.Precio.ToString());
                item.SubItems.Add(cantidad.ToString());
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrdenCompra O = new OrdenCompra(1, current, sq, currentL);
            this.Hide();
            Forms.Metodo_de_pago mt = new Forms.Metodo_de_pago(currentL, current,currentb,O,this);
            mt.Show();
        }

        private void Compralo_Load(object sender, EventArgs e)
        {

        }

        private void Compralo_Load_1(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
