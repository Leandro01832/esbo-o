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
            this.check_pesquisa_id = new System.Windows.Forms.CheckBox();
            this.check_pesquisa_nome = new System.Windows.Forms.CheckBox();
            this.txt_pesquisa_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_todos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pesquisa_id_valor2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_pesquisa_id_valor1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdados
            // 
            this.dgdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdados.Location = new System.Drawing.Point(55, 305);
            this.dgdados.Name = "dgdados";
            this.dgdados.RowTemplate.Height = 24;
            this.dgdados.Size = new System.Drawing.Size(1240, 493);
            this.dgdados.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(487, 37);
            this.comboBox1.TabIndex = 7;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(1631, 738);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(163, 60);
            this.btn_pesquisar.TabIndex = 8;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // check_pesquisa_id
            // 
            this.check_pesquisa_id.AutoSize = true;
            this.check_pesquisa_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_pesquisa_id.Location = new System.Drawing.Point(631, 24);
            this.check_pesquisa_id.Name = "check_pesquisa_id";
            this.check_pesquisa_id.Size = new System.Drawing.Size(175, 29);
            this.check_pesquisa_id.TabIndex = 9;
            this.check_pesquisa_id.Text = "Pesquisar por Id";
            this.check_pesquisa_id.UseVisualStyleBackColor = true;
            this.check_pesquisa_id.CheckedChanged += new System.EventHandler(this.check_pesquisa_id_CheckedChanged);
            // 
            // check_pesquisa_nome
            // 
            this.check_pesquisa_nome.AutoSize = true;
            this.check_pesquisa_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_pesquisa_nome.Location = new System.Drawing.Point(881, 24);
            this.check_pesquisa_nome.Name = "check_pesquisa_nome";
            this.check_pesquisa_nome.Size = new System.Drawing.Size(208, 29);
            this.check_pesquisa_nome.TabIndex = 18;
            this.check_pesquisa_nome.Text = "Pesquisar por nome";
            this.check_pesquisa_nome.UseVisualStyleBackColor = true;
            this.check_pesquisa_nome.CheckedChanged += new System.EventHandler(this.check_pesquisa_nome_CheckedChanged);
            // 
            // txt_pesquisa_nome
            // 
            this.txt_pesquisa_nome.Enabled = false;
            this.txt_pesquisa_nome.Location = new System.Drawing.Point(1542, 31);
            this.txt_pesquisa_nome.Name = "txt_pesquisa_nome";
            this.txt_pesquisa_nome.Size = new System.Drawing.Size(242, 22);
            this.txt_pesquisa_nome.TabIndex = 19;
            this.txt_pesquisa_nome.TextChanged += new System.EventHandler(this.txt_pesquisa_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1399, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pesquisar por nome";
            // 
            // btn_todos
            // 
            this.btn_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todos.Location = new System.Drawing.Point(1346, 738);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(245, 60);
            this.btn_todos.TabIndex = 21;
            this.btn_todos.Text = "Todos os registros";
            this.btn_todos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1667, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Até";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1538, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "De";
            // 
            // txt_pesquisa_id_valor2
            // 
            this.txt_pesquisa_id_valor2.Enabled = false;
            this.txt_pesquisa_id_valor2.Location = new System.Drawing.Point(1715, 80);
            this.txt_pesquisa_id_valor2.Name = "txt_pesquisa_id_valor2";
            this.txt_pesquisa_id_valor2.Size = new System.Drawing.Size(69, 22);
            this.txt_pesquisa_id_valor2.TabIndex = 35;
            this.txt_pesquisa_id_valor2.TextChanged += new System.EventHandler(this.txt_pesquisa_id_valor2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1408, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Pesquisar por id";
            // 
            // txt_pesquisa_id_valor1
            // 
            this.txt_pesquisa_id_valor1.Enabled = false;
            this.txt_pesquisa_id_valor1.Location = new System.Drawing.Point(1570, 80);
            this.txt_pesquisa_id_valor1.Name = "txt_pesquisa_id_valor1";
            this.txt_pesquisa_id_valor1.Size = new System.Drawing.Size(69, 22);
            this.txt_pesquisa_id_valor1.TabIndex = 33;
            this.txt_pesquisa_id_valor1.TextChanged += new System.EventHandler(this.txt_pesquisa_id_valor1_TextChanged);
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 819);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pesquisa_id_valor2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_pesquisa_id_valor1);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pesquisa_nome);
            this.Controls.Add(this.check_pesquisa_nome);
            this.Controls.Add(this.check_pesquisa_id);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgdados);
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
        private System.Windows.Forms.CheckBox check_pesquisa_id;
        private System.Windows.Forms.CheckBox check_pesquisa_nome;
        private System.Windows.Forms.TextBox txt_pesquisa_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pesquisa_id_valor2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_pesquisa_id_valor1;
    }
}