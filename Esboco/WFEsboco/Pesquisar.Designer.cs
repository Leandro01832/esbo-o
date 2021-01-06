namespace WFEsboco
{
    partial class Pesquisar
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
            this.dgdados = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_pesquisa_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_todos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pesquisa_id_valor2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_pesquisa_id_valor1 = new System.Windows.Forms.TextBox();
            this.radio_mensagem = new System.Windows.Forms.RadioButton();
            this.radio_fonte = new System.Windows.Forms.RadioButton();
            this.check_pesquisa_id = new System.Windows.Forms.CheckBox();
            this.check_pesquisa_tipo = new System.Windows.Forms.CheckBox();
            this.check_pesquisa_texto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdados
            // 
            this.dgdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdados.Location = new System.Drawing.Point(82, 367);
            this.dgdados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgdados.Name = "dgdados";
            this.dgdados.RowTemplate.Height = 24;
            this.dgdados.Size = new System.Drawing.Size(1270, 642);
            this.dgdados.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 192);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(728, 37);
            this.comboBox1.TabIndex = 7;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(2446, 1153);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(244, 94);
            this.btn_pesquisar.TabIndex = 8;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // txt_pesquisa_nome
            // 
            this.txt_pesquisa_nome.Enabled = false;
            this.txt_pesquisa_nome.Location = new System.Drawing.Point(2313, 48);
            this.txt_pesquisa_nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pesquisa_nome.Name = "txt_pesquisa_nome";
            this.txt_pesquisa_nome.Size = new System.Drawing.Size(361, 30);
            this.txt_pesquisa_nome.TabIndex = 19;
            this.txt_pesquisa_nome.TextChanged += new System.EventHandler(this.txt_pesquisa_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2098, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pesquisar por nome";
            // 
            // btn_todos
            // 
            this.btn_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todos.Location = new System.Drawing.Point(2019, 1153);
            this.btn_todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(368, 94);
            this.btn_todos.TabIndex = 21;
            this.btn_todos.Text = "Todos os registros";
            this.btn_todos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2500, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Até";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2307, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "De";
            // 
            // txt_pesquisa_id_valor2
            // 
            this.txt_pesquisa_id_valor2.Enabled = false;
            this.txt_pesquisa_id_valor2.Location = new System.Drawing.Point(2572, 125);
            this.txt_pesquisa_id_valor2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pesquisa_id_valor2.Name = "txt_pesquisa_id_valor2";
            this.txt_pesquisa_id_valor2.Size = new System.Drawing.Size(102, 30);
            this.txt_pesquisa_id_valor2.TabIndex = 35;
            this.txt_pesquisa_id_valor2.TextChanged += new System.EventHandler(this.txt_pesquisa_id_valor2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2112, 133);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Pesquisar por id";
            // 
            // txt_pesquisa_id_valor1
            // 
            this.txt_pesquisa_id_valor1.Enabled = false;
            this.txt_pesquisa_id_valor1.Location = new System.Drawing.Point(2355, 125);
            this.txt_pesquisa_id_valor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pesquisa_id_valor1.Name = "txt_pesquisa_id_valor1";
            this.txt_pesquisa_id_valor1.Size = new System.Drawing.Size(102, 30);
            this.txt_pesquisa_id_valor1.TabIndex = 33;
            this.txt_pesquisa_id_valor1.TextChanged += new System.EventHandler(this.txt_pesquisa_id_valor1_TextChanged);
            // 
            // radio_mensagem
            // 
            this.radio_mensagem.AutoSize = true;
            this.radio_mensagem.Location = new System.Drawing.Point(75, 75);
            this.radio_mensagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radio_mensagem.Name = "radio_mensagem";
            this.radio_mensagem.Size = new System.Drawing.Size(131, 29);
            this.radio_mensagem.TabIndex = 38;
            this.radio_mensagem.TabStop = true;
            this.radio_mensagem.Text = "Mensagem";
            this.radio_mensagem.UseVisualStyleBackColor = true;
            this.radio_mensagem.CheckedChanged += new System.EventHandler(this.radio_mensagem_CheckedChanged);
            // 
            // radio_fonte
            // 
            this.radio_fonte.AutoSize = true;
            this.radio_fonte.Location = new System.Drawing.Point(385, 75);
            this.radio_fonte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radio_fonte.Name = "radio_fonte";
            this.radio_fonte.Size = new System.Drawing.Size(83, 29);
            this.radio_fonte.TabIndex = 39;
            this.radio_fonte.TabStop = true;
            this.radio_fonte.Text = "Fonte";
            this.radio_fonte.UseVisualStyleBackColor = true;
            this.radio_fonte.CheckedChanged += new System.EventHandler(this.radio_fonte_CheckedChanged);
            // 
            // check_pesquisa_id
            // 
            this.check_pesquisa_id.AutoSize = true;
            this.check_pesquisa_id.Location = new System.Drawing.Point(1384, 33);
            this.check_pesquisa_id.Name = "check_pesquisa_id";
            this.check_pesquisa_id.Size = new System.Drawing.Size(174, 29);
            this.check_pesquisa_id.TabIndex = 40;
            this.check_pesquisa_id.Text = "Pesquisar por id";
            this.check_pesquisa_id.UseVisualStyleBackColor = true;
            this.check_pesquisa_id.CheckedChanged += new System.EventHandler(this.check_pesquisa_id_CheckedChanged_1);
            // 
            // check_pesquisa_tipo
            // 
            this.check_pesquisa_tipo.AutoSize = true;
            this.check_pesquisa_tipo.Location = new System.Drawing.Point(1384, 126);
            this.check_pesquisa_tipo.Name = "check_pesquisa_tipo";
            this.check_pesquisa_tipo.Size = new System.Drawing.Size(190, 29);
            this.check_pesquisa_tipo.TabIndex = 41;
            this.check_pesquisa_tipo.Text = "Pesquisar por tipo";
            this.check_pesquisa_tipo.UseVisualStyleBackColor = true;
            this.check_pesquisa_tipo.CheckedChanged += new System.EventHandler(this.check_pesquisa_tipo_CheckedChanged);
            // 
            // check_pesquisa_texto
            // 
            this.check_pesquisa_texto.AutoSize = true;
            this.check_pesquisa_texto.Location = new System.Drawing.Point(1384, 224);
            this.check_pesquisa_texto.Name = "check_pesquisa_texto";
            this.check_pesquisa_texto.Size = new System.Drawing.Size(195, 29);
            this.check_pesquisa_texto.TabIndex = 42;
            this.check_pesquisa_texto.Text = "Pesquisar no texto";
            this.check_pesquisa_texto.UseVisualStyleBackColor = true;
            this.check_pesquisa_texto.CheckedChanged += new System.EventHandler(this.check_pesquisa_texto_CheckedChanged);
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.check_pesquisa_texto);
            this.Controls.Add(this.check_pesquisa_tipo);
            this.Controls.Add(this.check_pesquisa_id);
            this.Controls.Add(this.radio_fonte);
            this.Controls.Add(this.radio_mensagem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pesquisa_id_valor2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_pesquisa_id_valor1);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pesquisa_nome);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgdados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pesquisar";
            this.Text = "Pesquisar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgdados;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_pesquisa_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pesquisa_id_valor2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_pesquisa_id_valor1;
        private System.Windows.Forms.RadioButton radio_mensagem;
        private System.Windows.Forms.RadioButton radio_fonte;
        private System.Windows.Forms.CheckBox check_pesquisa_id;
        private System.Windows.Forms.CheckBox check_pesquisa_tipo;
        private System.Windows.Forms.CheckBox check_pesquisa_texto;
    }
}