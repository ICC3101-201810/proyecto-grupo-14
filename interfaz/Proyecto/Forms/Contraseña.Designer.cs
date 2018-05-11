namespace Proyecto
{
    partial class Contraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rut = new System.Windows.Forms.TextBox();
            this.contraseña_a = new System.Windows.Forms.TextBox();
            this.contraseña_n = new System.Windows.Forms.TextBox();
            this.Listo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña Nueva";
            // 
            // rut
            // 
            this.rut.Location = new System.Drawing.Point(154, 15);
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(206, 20);
            this.rut.TabIndex = 3;
            // 
            // contraseña_a
            // 
            this.contraseña_a.Location = new System.Drawing.Point(154, 47);
            this.contraseña_a.Name = "contraseña_a";
            this.contraseña_a.Size = new System.Drawing.Size(206, 20);
            this.contraseña_a.TabIndex = 4;
            // 
            // contraseña_n
            // 
            this.contraseña_n.Location = new System.Drawing.Point(154, 76);
            this.contraseña_n.Name = "contraseña_n";
            this.contraseña_n.Size = new System.Drawing.Size(206, 20);
            this.contraseña_n.TabIndex = 5;
            // 
            // Listo
            // 
            this.Listo.Location = new System.Drawing.Point(285, 113);
            this.Listo.Name = "Listo";
            this.Listo.Size = new System.Drawing.Size(75, 23);
            this.Listo.TabIndex = 6;
            this.Listo.Text = "Listo";
            this.Listo.UseVisualStyleBackColor = true;
            this.Listo.Click += new System.EventHandler(this.Listo_Click);
            // 
            // Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 148);
            this.Controls.Add(this.Listo);
            this.Controls.Add(this.contraseña_n);
            this.Controls.Add(this.contraseña_a);
            this.Controls.Add(this.rut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Contraseña";
            this.Text = "Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rut;
        private System.Windows.Forms.TextBox contraseña_a;
        private System.Windows.Forms.TextBox contraseña_n;
        private System.Windows.Forms.Button Listo;
    }
}