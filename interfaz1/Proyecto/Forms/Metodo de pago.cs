using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Forms
{
    public partial class Metodo_de_pago : Form
    {
        Compralu ParentWindow;
        OrdenCompra CurrentO;
        Cliente Current;
        Banco CurrentC;
        public Metodo_de_pago(Cliente c, Banco d, OrdenCompra a, Compralu parentWindow)
        {
            this.Current = c;
            this.ParentWindow = (Compralu)parentWindow;
            this.CurrentO = a;
            this.CurrentC = d;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Webpay menu = new Webpay(CurrentC, CurrentO, this);
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WebpayC menu = new WebpayC(CurrentC, CurrentO, this);
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //efectivo
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void Metodo_de_pago_Load(object sender, EventArgs e)
        {

        }
    }
}
