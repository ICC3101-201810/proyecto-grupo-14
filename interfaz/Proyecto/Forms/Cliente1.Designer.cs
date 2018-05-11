namespace Proyecto
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
            this.localesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrar = new System.Windows.Forms.Button();
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
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localesUniversidadToolStripMenuItem,
            this.localesToolStripMenuItem});
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.comprarToolStripMenuItem.Text = "Comprar";
            // 
            // localesUniversidadToolStripMenuItem
            // 
            this.localesUniversidadToolStripMenuItem.Name = "localesUniversidadToolStripMenuItem";
            this.localesUniversidadToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.localesUniversidadToolStripMenuItem.Text = "Locales Universidad";
            // 
            // localesToolStripMenuItem
            // 
            this.localesToolStripMenuItem.Name = "localesToolStripMenuItem";
            this.localesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.localesToolStripMenuItem.Text = "Locales";
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
            this.verSaldoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.verSaldoToolStripMenuItem.Text = "Ver Saldo";
            // 
            // agregarDineroToolStripMenuItem
            // 
            this.agregarDineroToolStripMenuItem.Name = "agregarDineroToolStripMenuItem";
            this.agregarDineroToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.agregarDineroToolStripMenuItem.Text = "Agregar Dinero";
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
            // Cliente1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 185);
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
        private System.Windows.Forms.ToolStripMenuItem localesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDineroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.Button cerrar;
    }
}