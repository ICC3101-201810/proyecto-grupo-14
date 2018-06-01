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
        Banco CurrentC;
        Local CurrentL;
        public Metodo_de_pago(Local l,Cliente c, Banco d, OrdenCompra a, Compralo parentWindow)
        {
            this.CurrentL = l;
            this.Current = c;
            this.ParentWindow = parentWindow;
            this.CurrentO = a;
            this.CurrentC = d;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Webpay menu = new Webpay(CurrentO,CurrentC, Current,CurrentL, this);
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WebpayC menu = new WebpayC(CurrentO, CurrentC, Current, CurrentL, this);
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Current.Dinero <= CurrentO.VerMonto())
            {
                MessageBox.Show("no posees el efectivo suficiente, selecciona otra opcion de pago o elimina algo de la cuenta volviendo atras");
            }
            else
            {
                Current.Dinero -= CurrentO.VerMonto();
                CurrentL.agregarOdernCompra(CurrentO);
                CurrentL.Totalefectivo += CurrentO.VerMonto();
                MessageBox.Show("tienes el efectivo suficiente, recuerda no gastarlo antes de llegar a la tienda");
                this.Close();
                Form1 menu = new Form1();
                Cliente1 cl = new Cliente1(CurrentC, Current, menu);
                cl.Show();
            }
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
