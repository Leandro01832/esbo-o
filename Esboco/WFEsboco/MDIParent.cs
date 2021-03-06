﻿using business.classes.Fontes;
using System;
using System.Windows.Forms;
using WFEsboco.Formulario.Mensagem;
using WFEsboco.Formulario.PastaFonte;

namespace WFEsboco
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mensagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarMensagem frm = new FrmCadastrarMensagem(new business.classes.Mensagem(),
            false, false, false);
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void mensagemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMensagem frm = new FrmMensagem();
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();
        }

        private void fonteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFonte frm = new FrmFonte();
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();
        }

        private void versiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVersiculo frm = new FrmVersiculo();
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();
        }

        private void versiculoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmDadoFonte frm = new FrmDadoFonte(new business.classes.Fontes.Versiculo(),
            false, false, false);
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();
        }

        private void versiculoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmCanalTv frm = new FrmCanalTv();
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();

        }

        private void canalDeTvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVersiculo frm = new FrmVersiculo();
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();
        }

        private void canalDeTvToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDadoFonte frm = new FrmDadoFonte(new CanalTv(), false, false, false);
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDadoFonte frm = new FrmDadoFonte(new Livro(), false, false, false);
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();
        }

        private void livroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLivro frm = new FrmLivro();
            frm.MdiParent = this;
            frm.Text = "Janela " + childFormNumber++;
            frm.Show();
        }
    }
}
