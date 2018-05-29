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
        Form1 parentWindow;
        public Padre1(Form1 parentWindow)
        {
            this.parentWindow = parentWindow;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Padre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                item = listView1.Items.Add(local.Nombre);
                item.SubItems.Add(local.Direccion);
                item.SubItems.Add(local.Despacho.ToString());
                item.SubItems.Add(local.Credito.ToString());
                item.SubItems.Add(local.Debito.ToString());
                item.SubItems.Add(local.Efectivo.ToString());
                item.SubItems.Add(local.Cheque.ToString());
                item.SubItems.Add(local.RutAdmin);
            }
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
                item.SubItems.Add(local.RutAdmin);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarLocal ed = new EditarLocal();
            ed.Show();
            listView1.Visible = false;
        }
        protected override void OnClosed(EventArgs e)
        {
            parentWindow.Show();
            base.OnClosed(e);
        }
    }
}
