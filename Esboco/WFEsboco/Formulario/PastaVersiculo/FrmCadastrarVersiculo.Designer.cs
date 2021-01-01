namespace WFEsboco.Formulario.PastaVersiculo
{
    partial class FrmCadastrarVersiculo
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
            this.txt_capitulo = new System.Windows.Forms.TextBox();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_fonte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capitulo";
            // 
            // txt_capitulo
            // 
            this.txt_capitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_capitulo.Location = new System.Drawing.Point(151, 141);
            this.txt_capitulo.Name = "txt_capitulo";
            this.txt_capitulo.Size = new System.Drawing.Size(243, 30);
            this.txt_capitulo.TabIndex = 1;
            this.txt_capitulo.TextChanged += new System.EventHandler(this.txt_capitulo_TextChanged);
            // 
            // txt_texto
            // 
            this.txt_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_texto.Location = new System.Drawing.Point(151, 209);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(243, 30);
            this.txt_texto.TabIndex = 3;
            this.txt_texto.TextChanged += new System.EventHandler(this.txt_texto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto";
            // 
            // txt_id_fonte
            // 
            this.txt_id_fonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_fonte.Location = new System.Drawing.Point(151, 270);
            this.txt_id_fonte.Name = "txt_id_fonte";
            this.txt_id_fonte.Size = new System.Drawing.Size(243, 30);
            this.txt_id_fonte.TabIndex = 5;
            this.txt_id_fonte.TextChanged += new System.EventHandler(this.txt_id_fonte_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id da fonte";
            // 
            // FrmCadastrarVersiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_id_fonte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_capitulo);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastrarVersiculo";
            this.Text = "FrmCadastrarVersiculo";
            this.Load += new System.EventHandler(this.FrmCadastrarVersiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_capitulo;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_fonte;
        private System.Windows.Forms.Label label3;
    }
}