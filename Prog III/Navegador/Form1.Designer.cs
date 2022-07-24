
namespace Navegador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RojoVB = new System.Windows.Forms.Button();
            this.VerdeVB = new System.Windows.Forms.Button();
            this.AzulVB = new System.Windows.Forms.Button();
            this.buttonver = new System.Windows.Forms.Button();
            this.buttonir = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(145, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar en Google";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(145, 35);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(482, 20);
            this.buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RojoVB
            // 
            this.RojoVB.BackColor = System.Drawing.Color.Red;
            this.RojoVB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RojoVB.Location = new System.Drawing.Point(677, 12);
            this.RojoVB.Name = "RojoVB";
            this.RojoVB.Size = new System.Drawing.Size(102, 40);
            this.RojoVB.TabIndex = 3;
            this.RojoVB.Text = "Rojo";
            this.RojoVB.UseVisualStyleBackColor = false;
            this.RojoVB.Click += new System.EventHandler(this.RojoVB_Click);
            // 
            // VerdeVB
            // 
            this.VerdeVB.BackColor = System.Drawing.Color.Green;
            this.VerdeVB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VerdeVB.Location = new System.Drawing.Point(677, 58);
            this.VerdeVB.Name = "VerdeVB";
            this.VerdeVB.Size = new System.Drawing.Size(102, 40);
            this.VerdeVB.TabIndex = 4;
            this.VerdeVB.Text = "Verde";
            this.VerdeVB.UseVisualStyleBackColor = false;
            this.VerdeVB.Click += new System.EventHandler(this.VerdeVB_Click);
            // 
            // AzulVB
            // 
            this.AzulVB.BackColor = System.Drawing.Color.Blue;
            this.AzulVB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AzulVB.Location = new System.Drawing.Point(677, 104);
            this.AzulVB.Name = "AzulVB";
            this.AzulVB.Size = new System.Drawing.Size(102, 40);
            this.AzulVB.TabIndex = 5;
            this.AzulVB.Text = "Azul";
            this.AzulVB.UseVisualStyleBackColor = false;
            this.AzulVB.Click += new System.EventHandler(this.AzulVB_Click);
            // 
            // buttonver
            // 
            this.buttonver.Location = new System.Drawing.Point(838, 24);
            this.buttonver.Name = "buttonver";
            this.buttonver.Size = new System.Drawing.Size(102, 40);
            this.buttonver.TabIndex = 6;
            this.buttonver.Text = "Ver";
            this.buttonver.UseVisualStyleBackColor = true;
            this.buttonver.Click += new System.EventHandler(this.buttonver_Click);
            // 
            // buttonir
            // 
            this.buttonir.Location = new System.Drawing.Point(421, 70);
            this.buttonir.Name = "buttonir";
            this.buttonir.Size = new System.Drawing.Size(206, 23);
            this.buttonir.TabIndex = 8;
            this.buttonir.Text = "Ir a la URL";
            this.buttonir.UseVisualStyleBackColor = true;
            this.buttonir.Click += new System.EventHandler(this.buttonir_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 150);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(928, 517);
            this.webBrowser1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(952, 679);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.buttonir);
            this.Controls.Add(this.buttonver);
            this.Controls.Add(this.AzulVB);
            this.Controls.Add(this.VerdeVB);
            this.Controls.Add(this.RojoVB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Buscador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RojoVB;
        private System.Windows.Forms.Button VerdeVB;
        private System.Windows.Forms.Button AzulVB;
        private System.Windows.Forms.Button buttonver;
        private System.Windows.Forms.Button buttonir;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

