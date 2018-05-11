namespace Proyecto
{
    partial class Padre1
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
            this.localesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLocalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cerrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localesToolStripMenuItem,
            this.cuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // localesToolStripMenuItem
            // 
            this.localesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarLocalToolStripMenuItem,
            this.editarLocalToolStripMenuItem,
            this.eliminarLocalToolStripMenuItem,
            this.verLocalesToolStripMenuItem});
            this.localesToolStripMenuItem.Name = "localesToolStripMenuItem";
            this.localesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.localesToolStripMenuItem.Text = "Locales";
            // 
            // agregarLocalToolStripMenuItem
            // 
            this.agregarLocalToolStripMenuItem.Name = "agregarLocalToolStripMenuItem";
            this.agregarLocalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.agregarLocalToolStripMenuItem.Text = "Agregar Local";
            this.agregarLocalToolStripMenuItem.Click += new System.EventHandler(this.agregarLocalToolStripMenuItem_Click);
            // 
            // editarLocalToolStripMenuItem
            // 
            this.editarLocalToolStripMenuItem.Name = "editarLocalToolStripMenuItem";
            this.editarLocalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editarLocalToolStripMenuItem.Text = "Editar Local";
            // 
            // eliminarLocalToolStripMenuItem
            // 
            this.eliminarLocalToolStripMenuItem.Name = "eliminarLocalToolStripMenuItem";
            this.eliminarLocalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.eliminarLocalToolStripMenuItem.Text = "Eliminar Local";
            this.eliminarLocalToolStripMenuItem.Click += new System.EventHandler(this.eliminarLocalToolStripMenuItem_Click);
            // 
            // verLocalesToolStripMenuItem
            // 
            this.verLocalesToolStripMenuItem.Name = "verLocalesToolStripMenuItem";
            this.verLocalesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.verLocalesToolStripMenuItem.Text = "Ver Locales";
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
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(318, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(104, 23);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "Cerrar Sesion";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Padre1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 190);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Padre1";
            this.Text = "Padre1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem localesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLocalesToolStripMenuItem;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
    }
}