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
        Cliente1 ParentWindow;
        public LocalesU(Cliente c, Cliente1 cl)
        {
            this.CurrentC = c;
            this.ParentWindow = cl;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Locales";
            listView1.Visible = true;
            listView1.Items.Clear();
            ListViewItem item = new ListViewItem();
            foreach (Local local in Listas.locales)
            {
                
                item = listView1.Items.Add(local.Nombre1);
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
            string text;
            try
            {
                text = listView1.SelectedItems[0].Text;
            }
            catch (Exception)
            {
                text = "";
                throw;
            }
            int i = 0;
            foreach(Local l in Listas.locales)
            {
                if (text == l.Nombre1)
                {
                    lt = l;
                    i++;
                    break;
                }
            }
            if (i==0)
            {
                MessageBox.Show("Seleccione un local", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.FullRowSelect == false)
            {
                MessageBox.Show("Seleccione un local", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                Compralo cm = new Compralo(lt, CurrentC, this);
                cm.Show();
            }
        }

        private void LocalesU_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentWindow.Show();
        }
    }
}
