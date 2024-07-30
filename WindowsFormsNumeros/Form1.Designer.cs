namespace WindowsFormsNumeros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.n1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtN3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(79, 64);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(108, 24);
            this.n1.TabIndex = 0;
            this.n1.Text = "Número 1:";
            this.n1.Click += new System.EventHandler(this.txtN1_Click);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(193, 64);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(223, 20);
            this.txtN1.TabIndex = 1;
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(79, 112);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(108, 24);
            this.n2.TabIndex = 2;
            this.n2.Text = "Número 2:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(193, 112);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(223, 20);
            this.txtN2.TabIndex = 3;
            // 
            // btnSomar
            // 
            this.btnSomar.ForeColor = System.Drawing.Color.Maroon;
            this.btnSomar.Location = new System.Drawing.Point(83, 183);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(91, 33);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.Color.Purple;
            this.btnLimpar.Location = new System.Drawing.Point(205, 183);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 34);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.Location = new System.Drawing.Point(325, 182);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 34);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtN3
            // 
            this.txtN3.AutoSize = true;
            this.txtN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.Location = new System.Drawing.Point(78, 263);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(109, 24);
            this.txtN3.TabIndex = 9;
            this.txtN3.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(200, 262);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(575, 382);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label txtN3;
        private System.Windows.Forms.Label lblResultado;
    }
}

