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
        OrdenCompra O;
        string nombre;
        string marca;
        int cantidad;
        Producto seleccion;
        private void button4_Click(object sender, EventArgs e)
        {
            marca = maskedTextBox2.Text;
            nombre = maskedTextBox1.Text;
            cantidad = Int32.Parse(maskedTextBox3.Text);
            seleccion.Marca = marca;
            seleccion.Nombre = nombre;
            seleccion.Stock = cantidad;
            O.productos.Add(seleccion);
        }

        private void button6_Click(object sender, EventArgs e)
        {
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
    }
}
