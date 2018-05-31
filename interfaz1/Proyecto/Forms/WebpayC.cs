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
    public partial class WebpayC : Form
    {

        Banco current;
        OrdenCompra currentc;
        Usuario currentU;
        Metodo_de_pago parentWindow;
        public WebpayC(Banco a, OrdenCompra b, Metodo_de_pago parentWindow)
        {

            this.parentWindow = parentWindow;
            this.current = a;
            this.currentc = b;
            this.currentU = (Usuario)current;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Webpay tarjeta de debito";
        }

        private void WebpayC_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            current.PagoConCredito(a, b, currentc.VerMonto(), currentU.rut);
        }
    }
}
