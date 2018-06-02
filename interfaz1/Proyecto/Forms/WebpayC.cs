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
        Cliente currentU;
        Metodo_de_pago parentWindow;
        OrdenCompra CurrentK;
        Local CurrentL;
        public WebpayC(OrdenCompra k, Banco a, Cliente rt, Local p, Metodo_de_pago parentWindow)
        {
            this.CurrentL = p;
            this.CurrentK = k;
            this.parentWindow = parentWindow;
            this.current = a;
            this.currentU = rt;
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
            if (b == current.Contraseña)
            {
                if (current.Credito1 >= CurrentK.VerMonto())
                {
                    current.PagoConCredito(a, b, CurrentK.VerMonto());
                    this.Close();
                    Form1 mn = new Form1();
                    Cliente1 cl = new Cliente1(current,currentU, mn);
                    MessageBox.Show("Pago exitoso, retire los productos de la manera acordada preciamente");
                    CurrentL.agregarOdernCompra(CurrentK);
                    CurrentL.VenderProductos(CurrentK);
                    cl.Show();
                    cl.Show();
                }
                else
                {
                    MessageBox.Show("no hay saldo suficiente en tu linea de credito, intenta con otro medio de pago o saca algun producto de la lista");
                    this.Close();
                    Parent.Show();
                }
            }
                
        }
    }
}
