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
    public partial class Administrador1 : Form

    {
        Administrador current;
        Usuario currentU;
        Form1 parentWindow;
        public Administrador1(Administrador a, Form1 parentWindow)
        {
            this.parentWindow = parentWindow;
            this.current = a;
            this.currentU = (Usuario)current;
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Administrador";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            Contraseña contraseña = new Contraseña();
            contraseña.Show();
            listView1.Visible = false;
        }

        private void agregarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            AgregarProducto ag = new AgregarProducto(current);
            ag.Show();
            listView1.Visible = false;
        }

        private void verLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            foreach (Local local in Listas.locales)
            {
                if (local.RutAdmin == current.Rut)
                {
                    listView1.Visible = true;
                    listView1.Items.Clear();
                    List<Producto> productos = local.GetProductos();
                    foreach (Producto producto in productos)
                    {
                        ListViewItem item = new ListViewItem();
                        item = listView1.Items.Add(producto.Nombre);
                        item.SubItems.Add(producto.Marca);
                        item.SubItems.Add(producto.Precio.ToString());
                        item.SubItems.Add(producto.Stock.ToString());
                    }
                }
            }
            foreach (Local local in Listas.locales)
            {
                if (local.RutAdmin == current.Rut)
                {
                    listView1.Visible = true;
                    listView1.Items.Clear();
                    List<Producto> productos = local.GetProductos();
                    foreach (Producto producto in productos)
                    {
                        ListViewItem item = new ListViewItem();
                        item = listView1.Items.Add(producto.Nombre);
                        item.SubItems.Add(producto.Marca);
                        item.SubItems.Add(producto.Precio.ToString());
                        item.SubItems.Add(producto.Stock.ToString());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void editarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            editarProducto ep = new editarProducto(current);
            ep.Show();
            listView1.Visible = false;
        }
        protected override void OnClosed(EventArgs e)
        {
            parentWindow.Show();
            base.OnClosed(e);
        }

        private void Administrador1_Load(object sender, EventArgs e)
        {

        }

        private void Administrador1_Load_1(object sender, EventArgs e)
        {

        }

        private void Administrador1_Load_2(object sender, EventArgs e)
        {

        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.Visible = false;
            foreach (Local local in Listas.locales)
            {
                if (local.RutAdmin == current.Rut)
                {
                    List<Producto> productos = local.GetProductos();
                    if (local.EliminarProducto(productos, textBox1.Text) == true)
                    {
                        MessageBox.Show("Producto eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
        }
    }
}
