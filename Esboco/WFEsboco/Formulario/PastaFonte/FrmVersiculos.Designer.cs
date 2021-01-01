namespace WFEsboco.Formulario.PastaFonte
{
    partial class FrmVersiculos
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
            this.lbl_versiculos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_versiculos
            // 
            this.lbl_versiculos.AutoSize = true;
            this.lbl_versiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versiculos.Location = new System.Drawing.Point(22, 102);
            this.lbl_versiculos.Name = "lbl_versiculos";
            this.lbl_versiculos.Size = new System.Drawing.Size(0, 29);
            this.lbl_versiculos.TabIndex = 0;
            // 
            // FrmVersiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_versiculos);
            this.Name = "FrmVersiculos";
            this.Text = "FrmVersiculos";
            this.Load += new System.EventHandler(this.FrmVersiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_versiculos;
    }
}