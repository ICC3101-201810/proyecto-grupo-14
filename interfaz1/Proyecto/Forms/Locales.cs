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
    public partial class LocalesU : Form
    {
        Cliente CurrentC;
        Banco CurrentB;
        Cliente1 ParentWindow;
        public LocalesU(Cliente c, Banco b, Cliente1 cl)
        {
            this.CurrentC = c;
            this.CurrentB = b;
            this.ParentWindow = cl;
            InitializeComponent();

            listView1.Visible = true;
            listView1.Items.Clear();
            foreach (Local local in Listas.locales)
            {
                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(local.Nombre);
                item.SubItems.Add(local.Direccion);
                item.SubItems.Add(local.Despacho.ToString());
                item.SubItems.Add(local.Credito.ToString());
                item.SubItems.Add(local.Debito.ToString());
                item.SubItems.Add(local.Efectivo.ToString());
                item.SubItems.Add(local.Cheque.ToString());
                item.SubItems.Add(local.Ubicacion);
            }
        }
        Local lt;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            string text = listView1.SelectedItems[0].Text;
            foreach(Local l in Listas.locales)
            {
                if (text == l.Nombre)
                {
                    lt = l;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compralo cm = new Compralo(lt,CurrentC, CurrentB, this);
            cm.Show();
            
        }

        private void LocalesU_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }
    }
}
