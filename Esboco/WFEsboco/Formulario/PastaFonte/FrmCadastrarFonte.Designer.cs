namespace WFEsboco.Formulario.PastaFonte
{
    partial class FrmCadastrarFonte
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
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_livro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mensagem_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor";
            // 
            // txt_autor
            // 
            this.txt_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_autor.Location = new System.Drawing.Point(176, 129);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(254, 34);
            this.txt_autor.TabIndex = 1;
            this.txt_autor.TextChanged += new System.EventHandler(this.txt_autor_TextChanged);
            // 
            // txt_livro
            // 
            this.txt_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_livro.Location = new System.Drawing.Point(176, 208);
            this.txt_livro.Name = "txt_livro";
            this.txt_livro.Size = new System.Drawing.Size(254, 34);
            this.txt_livro.TabIndex = 3;
            this.txt_livro.TextChanged += new System.EventHandler(this.txt_livro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Livro";
            // 
            // txt_mensagem_id
            // 
            this.txt_mensagem_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensagem_id.Location = new System.Drawing.Point(235, 284);
            this.txt_mensagem_id.Name = "txt_mensagem_id";
            this.txt_mensagem_id.Size = new System.Drawing.Size(195, 34);
            this.txt_mensagem_id.TabIndex = 5;
            this.txt_mensagem_id.TextChanged += new System.EventHandler(this.txt_mensagem_id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id da mensagem";
            // 
            // FrmCadastrarFonte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_mensagem_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_livro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastrarFonte";
            this.Text = "FrmCadastrarFonte";
            this.Load += new System.EventHandler(this.FrmCadastrarFonte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_livro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mensagem_id;
        private System.Windows.Forms.Label label3;
    }
}