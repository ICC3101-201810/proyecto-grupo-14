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
        public LocalesU()
        {
            InitializeComponent();

            listView1.Visible = true;
            listView1.Items.Clear();
            foreach (Local local in Listas.localesU)
            {
                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(local.Nombre);
                item.SubItems.Add(local.Direccion);
                item.SubItems.Add(local.Despacho.ToString());
                item.SubItems.Add(local.Credito.ToString());
                item.SubItems.Add(local.Debito.ToString());
                item.SubItems.Add(local.Efectivo.ToString());
                item.SubItems.Add(local.Cheque.ToString());

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
