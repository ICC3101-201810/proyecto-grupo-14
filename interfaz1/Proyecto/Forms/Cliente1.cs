﻿using System;
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
        public Cliente1(Banco d , Form1 parentWindow)
        {
            this.CuentaUsuario = d;
            this.ParentWindow = parentWindow;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Cliente";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
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
    }
}
