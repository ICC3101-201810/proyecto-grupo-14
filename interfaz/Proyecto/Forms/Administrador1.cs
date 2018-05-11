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
    public partial class Administrador1 : Form
    {
        public Administrador1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Administrador";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contraseña contraseña = new Contraseña();
            contraseña.Show();
        }

        private void agregarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProducto ag = new AgregarProducto();
            ag.Show();
        }
    }
}
