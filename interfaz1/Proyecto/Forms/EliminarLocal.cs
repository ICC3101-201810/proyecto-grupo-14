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
    public partial class EliminarLocal : Form
    {
        public EliminarLocal()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Eliminar Local";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = "";
            bool a=false;
            Local la = new Local(0,0,0,textBox1.Text, textBox1.Text,textBox1.Text,a,a,a,a,a,b);
            

            if(la.Eliminar(la, textBox1.Text) == false)
            {
                MessageBox.Show("Nombre no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }

            else 
            {
                MessageBox.Show("Local eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }

        }   
    }
}
