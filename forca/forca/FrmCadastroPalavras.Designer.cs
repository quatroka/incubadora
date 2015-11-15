namespace forca
{
    partial class FrmCadastroPalavras
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
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.txtDica2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDica3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDica1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(299, 42);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(171, 30);
            this.txtPalavra.TabIndex = 1;
            // 
            // txtDica2
            // 
            this.txtDica2.Location = new System.Drawing.Point(299, 152);
            this.txtDica2.Name = "txtDica2";
            this.txtDica2.Size = new System.Drawing.Size(171, 30);
            this.txtDica2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dica ";
            // 
            // txtDica3
            // 
            this.txtDica3.Location = new System.Drawing.Point(299, 188);
            this.txtDica3.Name = "txtDica3";
            this.txtDica3.Size = new System.Drawing.Size(171, 30);
            this.txtDica3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dica ";
            // 
            // txtDica1
            // 
            this.txtDica1.Location = new System.Drawing.Point(299, 116);
            this.txtDica1.Name = "txtDica1";
            this.txtDica1.Size = new System.Drawing.Size(171, 30);
            this.txtDica1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dica ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCadastroPalavras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDica1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDica3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDica2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCadastroPalavras";
            this.Text = "CADASTRO DE PALAVRAS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadastroPalavras_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.TextBox txtDica2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDica3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDica1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}