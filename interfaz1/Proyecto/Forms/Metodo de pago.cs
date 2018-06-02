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
        Compralo ParentWindow;
        OrdenCompra CurrentO;
        Cliente Current;
        Local CurrentL;
        public Metodo_de_pago(Local l,Cliente c,  OrdenCompra a, Compralo parentWindow)
        {
            this.CurrentL = l;
            this.Current = c;
            this.ParentWindow = parentWindow;
            this.CurrentO = a;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Metodo de Pago";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Webpay menu = new Webpay(CurrentO, Current,CurrentL, this);
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WebpayC menu = new WebpayC(CurrentO,  Current, CurrentL, this);
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Current.Dinero <= CurrentO.VerMonto())
            {
                MessageBox.Show("No posees el efectivo suficiente, selecciona otra opcion de pago o elimina algo de la cuenta volviendo atras");
            }
            else
            {
                List<Producto> productos = CurrentL.GetProductos();
                foreach (Producto producto in productos)
                {
                    foreach (Producto producto1 in CurrentO.Productos)
                    {
                        if (producto.Nombre == producto1.Nombre && producto.Marca == producto1.Marca)
                        {
                            producto.Stock -= 1;
                        }
                    }
                }
                Current.Dinero -= CurrentO.VerMonto();
                CurrentL.agregarOdernCompra(CurrentO);
                CurrentL.Totalefectivo += CurrentO.VerMonto();
                MessageBox.Show("Compra realizada con exito");
                this.Close();
                Form1 menu = new Form1();
                Cliente1 cl = new Cliente1(Current, menu);
                cl.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentWindow.Show();
        }

        private void Metodo_de_pago_Load(object sender, EventArgs e)
        {

        }
    }
}
