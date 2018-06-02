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

        Cliente currentU;
        Metodo_de_pago parentWindow;
        OrdenCompra CurrentK;
        Local CurrentL;
        public WebpayC(OrdenCompra k, Cliente rt, Local p, Metodo_de_pago parentWindow)
        {
            this.CurrentL = p;
            this.CurrentK = k;
            this.parentWindow = parentWindow;
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
            foreach (Banco br in Listas.Cuentas)
            {
                if (br.NroTarjetaCredito1 == a)
                {
                    if (b == br.ContrasenaCredito)
                    {
                        if (br.Credito1 >= CurrentK.VerMonto())
                        {
                            List<Producto> productos = CurrentL.GetProductos();
                            foreach (Producto producto in productos)
                            {
                                foreach (Producto producto1 in CurrentK.Productos)
                                {
                                    if (producto.Nombre == producto1.Nombre && producto.Marca == producto1.Marca)
                                    {
                                        producto.Stock -= 1;
                                    }
                                }
                            }
                            br.PagoConCredito(a, b, CurrentK.VerMonto());
                            this.Close();
                            Form1 mn = new Form1();
                            Cliente1 cl = new Cliente1(currentU, mn);
                            MessageBox.Show("Pago exitoso, retire los productos de la manera acordada previamente");
                            CurrentL.agregarOdernCompra(CurrentK);
                            CurrentL.Totaldebito += CurrentK.VerMonto();
                            CurrentL.VenderProductos(CurrentK);
                            cl.Show();
                        }
                        else
                        {
                            MessageBox.Show("No hay saldo suficiente en tu linea de debito, intenta con otro medio de pago o saca algun producto de la lista");
                            this.Close();
                            parentWindow.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("no existe, trata con otra tarjeta");
                    this.Close();
                    parentWindow.Show();
                }

            }

        }
    }
}
