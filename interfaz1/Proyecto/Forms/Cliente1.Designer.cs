﻿namespace Proyecto
{
    partial class Cliente1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localesUniversidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarToolStripMenuItem,
            this.efectivoToolStripMenuItem,
            this.cuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localesUniversidadToolStripMenuItem});
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.comprarToolStripMenuItem.Text = "Comprar";
            this.comprarToolStripMenuItem.Click += new System.EventHandler(this.comprarToolStripMenuItem_Click);
            // 
            // localesUniversidadToolStripMenuItem
            // 
            this.localesUniversidadToolStripMenuItem.Name = "localesUniversidadToolStripMenuItem";
            this.localesUniversidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localesUniversidadToolStripMenuItem.Text = "Locales ";
            this.localesUniversidadToolStripMenuItem.Click += new System.EventHandler(this.localesToolStripMenuItem_Click);
            // 
            // efectivoToolStripMenuItem
            // 
            this.efectivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verSaldoToolStripMenuItem,
            this.agregarDineroToolStripMenuItem});
            this.efectivoToolStripMenuItem.Name = "efectivoToolStripMenuItem";
            this.efectivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.efectivoToolStripMenuItem.Text = "Efectivo";
            // 
            // verSaldoToolStripMenuItem
            // 
            this.verSaldoToolStripMenuItem.Name = "verSaldoToolStripMenuItem";
            this.verSaldoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verSaldoToolStripMenuItem.Text = "Ver Saldo";
            this.verSaldoToolStripMenuItem.Click += new System.EventHandler(this.verSaldoToolStripMenuItem_Click);
            // 
            // agregarDineroToolStripMenuItem
            // 
            this.agregarDineroToolStripMenuItem.Name = "agregarDineroToolStripMenuItem";
            this.agregarDineroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarDineroToolStripMenuItem.Text = "Agregar Dinero";
            this.agregarDineroToolStripMenuItem.Click += new System.EventHandler(this.agregarDineroToolStripMenuItem_Click);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(332, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(90, 23);
            this.cerrar.TabIndex = 1;
            this.cerrar.Text = "Cerrar Sesion";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saldo: ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agregar dinero:";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cliente1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cliente1";
            this.Text = "Cliente1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localesUniversidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDineroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}