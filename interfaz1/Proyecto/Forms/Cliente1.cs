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
    public partial class Cliente1 : Form
    {
        Banco CuentaUsuario;
        Form1 ParentWindow;
        Cliente current;
        public Cliente1(Banco d , Cliente c, Form1 parentWindow)
        {
            this.current = c;
            this.CuentaUsuario = d;
            this.ParentWindow = parentWindow;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Cliente";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contraseña contraseña = new Contraseña();
            contraseña.Show();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void localesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocalesU cm = new LocalesU(current,CuentaUsuario,this);
            cm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnClosed(EventArgs e)
        {
            ParentWindow.Show();
            base.OnClosed(e);
        }

        private void verSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            label1.Visible = true;
            string dinero = Convert.ToString(current.Dinero);
            label2.Text = dinero;
            label2.Visible = true;
        }

        private void agregarDineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Visible = false;
            label1.Visible = false;
            label3.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dinero = Int32.Parse(textBox1.Text);
            current.Dinero += dinero;
            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
        }
    }
}
