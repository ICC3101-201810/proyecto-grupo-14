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
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Cambiar Contraseña";
        }

        private void Listo_Click(object sender, EventArgs e)
        {
            string rut1 = rut.Text;
            string contraseña_a1 = contraseña_a.Text;
            string contraseña_n1 = contraseña_n.Text;
            Usuario a = new Usuario(rut1, contraseña_a1);
            if (a.CambiarContraseña(Listas.clientes, Listas.administradores, Listas.padres, rut1, contraseña_a1, contraseña_n1) == true)
            {
                MessageBox.Show("Contraseña cambiada satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se ha podido cambiar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
