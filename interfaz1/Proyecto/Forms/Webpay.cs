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
    public partial class Webpay : Form
    {
        Banco current;
        OrdenCompra currentc;
        Usuario currentU;
        Metodo_de_pago parentWindow;
        public Webpay(Banco a, OrdenCompra b, Metodo_de_pago parentWindow)
        {

            this.parentWindow = parentWindow;
            this.current = a;
            this.currentc = b;
            this.currentU = (Usuario)current;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Webpay tarjeta de debito";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            current.PagoConDebito(a, b, currentc.VerMonto(), current.rut);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Parent.Show();
        }

        private void Webpay_Load(object sender, EventArgs e)
        {

        }
    }
}
