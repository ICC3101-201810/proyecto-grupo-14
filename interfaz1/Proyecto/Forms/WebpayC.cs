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
        public WebpayC()
        {
            InitializeComponent();
        }
        //rut cliente
        float monto;
        Banco cl;
        
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
            cl.PagoConCredito(a, b, monto, cl);
        }
    }
}
