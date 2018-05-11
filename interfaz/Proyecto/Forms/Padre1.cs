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
        }

        private void eliminarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarLocal el = new EliminarLocal();
            el.Show();
        }

        private void editarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarLocal ell = new EditarLocal();
            ell.Show();
        }
    }
}
