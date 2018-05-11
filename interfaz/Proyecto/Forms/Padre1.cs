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
    public partial class Padre1 : Form
    {
        public Padre1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Padre";
            listView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void agregarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AgregarLocal ag = new AgregarLocal();
            ag.Show();
            listView1.Visible = false;
        }

        private void eliminarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarLocal el = new EliminarLocal();
            el.Show();
            listView1.Visible = false;
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contraseña contraseña = new Contraseña();
            contraseña.Show();
        }

        private void verLocalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            foreach (Local local in Listas.locales)
            {
                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(local.nombre);
                item.SubItems.Add(local.direccion);
                item.SubItems.Add(local.despacho.ToString());
                item.SubItems.Add(local.credito.ToString());
                item.SubItems.Add(local.debito.ToString());
                item.SubItems.Add(local.efectivo.ToString());
                item.SubItems.Add(local.cheque.ToString());
                item.SubItems.Add(local.rutAdmin.ToString());
            }
            foreach (Local local in Listas.localesU)
            {
                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(local.nombre);
                item.SubItems.Add(local.direccion);
                item.SubItems.Add(local.despacho.ToString());
                item.SubItems.Add(local.credito.ToString());
                item.SubItems.Add(local.debito.ToString());
                item.SubItems.Add(local.efectivo.ToString());
                item.SubItems.Add(local.cheque.ToString());
                item.SubItems.Add(local.rutAdmin.ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
