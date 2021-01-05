
using business.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFEsboco.Formulario.Mensagem;
using WFEsboco.Formulario.PastaFonte;
using WFEsboco.ListViews;

namespace WFEsboco.Formulario
{
    public partial class FormularioListView : Form
    {
        public FormularioListView()
        {

        }

        List<modelocrud> lista;

        public FormularioListView(TodosListViews ListView)
        {
            this.Modelo = ListView.Modelo;
            this.Tipo = ListView.Tipo;

            botaoDeletar = new Button();
            botaoDeletar.Location = new System.Drawing.Point(570, 120);
            botaoDeletar.Size = new System.Drawing.Size(100, 50);
            botaoDeletar.Text = "Excluir";
            botaoDeletar.Click += botaoExcluir_Click;
            botaoDeletar.Dock = DockStyle.Right;

            botaoAtualizar = new Button();
            botaoAtualizar.Location = new System.Drawing.Point(570, 200);
            botaoAtualizar.Size = new System.Drawing.Size(100, 50);
            botaoAtualizar.Text = "Atualizar";
            botaoAtualizar.Click += botaoAtualizar_Click;
            botaoAtualizar.Dock = DockStyle.Right;

            botaoDetalhes = new Button();
            botaoDetalhes.Location = new System.Drawing.Point(570, 280);
            botaoDetalhes.Size = new System.Drawing.Size(100, 50);
            botaoDetalhes.Text = "Detalhes";
            botaoDetalhes.Click += BotaoDetalhes_Click;
            botaoDetalhes.Dock = DockStyle.Right;

            Controls.Add(ListView);
            Controls.Add(botaoDetalhes);
            Controls.Add(botaoAtualizar);
            Controls.Add(botaoDeletar);
            this.ListView = ListView;

            InitializeComponent();
        }

        private Button botaoDetalhes { get; }
        private Button botaoAtualizar { get; }
        private Button botaoDeletar { get; }
        public modelocrud Modelo { get; set; }
        public TodosListViews ListView { get; }

        public string Tipo { get; set; }

        private void BotaoDetalhes_Click(object sender, EventArgs e)
        {
            if (ListView.numero == 0)
            {
                MessageBox.Show("Escolha um item da lista.");
                return;
            }
            if (ListView is ListViewMensagem)
            {
                Modelo = new business.classes.Mensagem(ListView.numero, true).recuperar(ListView.numero)[0];

                FrmFinalizarCadastroMensagem frm = new FrmFinalizarCadastroMensagem(Modelo, false, false, true);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            if (ListView is ListViewFonte)
            {
                List<business.classes.Abstrato.Fonte> lista2 = new List<business.classes.Abstrato.Fonte>();
                foreach (var item in lista)
                 lista2.Add((business.classes.Abstrato.Fonte)item);
                Modelo = lista2.First(i => i.Id == ListView.numero);

                FrmFinalizarCadastroFonte frm = new FrmFinalizarCadastroFonte(Modelo, false, false, true);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            if (ListView is ListViewVersiculo)
            {
                Modelo = new business.classes.Fontes.Versiculo().recuperar(ListView.numero)[0];
                FrmFinalizarCadastroFonte frm = new FrmFinalizarCadastroFonte(Modelo, false, false, true);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            if(ListView.numero == 0)
            {
                MessageBox.Show("Escolha um item da lista.");
                return;
            }
            if (ListView is ListViewMensagem)
            {
                Modelo = new business.classes.Mensagem(ListView.numero, true).recuperar(ListView.numero)[0];

                FrmFinalizarCadastroMensagem frm = new FrmFinalizarCadastroMensagem(Modelo, false, true, false);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            if (ListView is ListViewFonte)
            {
                List<business.classes.Abstrato.Fonte> lista2 = new List<business.classes.Abstrato.Fonte>();
                foreach (var item in lista)
                    lista2.Add((business.classes.Abstrato.Fonte)item);
                Modelo = lista2.First(i => i.Id == ListView.numero);

                FrmFinalizarCadastroFonte frm = new FrmFinalizarCadastroFonte(Modelo, false, true, false);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            if (ListView is ListViewVersiculo)
            {
                Modelo = new business.classes.Fontes.Versiculo().recuperar(ListView.numero)[0];

                FrmFinalizarCadastroFonte frm = new FrmFinalizarCadastroFonte(Modelo, false, true, false);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

        }        

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            if (ListView.numero == 0)
            {
                MessageBox.Show("Escolha um item da lista.");
                return;
            }
            if (ListView is ListViewMensagem)
            {
                    Modelo = new business.classes.Mensagem(ListView.numero, true).recuperar(ListView.numero)[0];
                    FrmFinalizarCadastroMensagem frm = new FrmFinalizarCadastroMensagem(Modelo, true, false, false);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            if (ListView is ListViewFonte)
            {
                List<business.classes.Abstrato.Fonte> lista2 = new List<business.classes.Abstrato.Fonte>();
                foreach (var item in lista)
                lista2.Add((business.classes.Abstrato.Fonte)item);
                Modelo = lista2.First(i => i.Id == ListView.numero);
                FrmFinalizarCadastroFonte frm = new FrmFinalizarCadastroFonte(Modelo, true, false, false);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

        }
        
        private async void FormularioListView_Load(object sender, EventArgs e)
        {
             lista = new List<modelocrud>();
            if (Modelo != null)
            lista = await Task.Run(() => Modelo.recuperar(null));

            ListView.Dock = DockStyle.Left;

            if (lista != null)
                foreach (var v in lista)
                {
                    if (v is business.classes.Mensagem)
                    {
                        business.classes.Mensagem p;
                        p = (business.classes.Mensagem)v;
                        ListView.Items.Add(p.Id.ToString() + " - " + p.Tipo);
                       
                    }
                    else
                    if (v is business.classes.Abstrato.Fonte)
                    {
                        business.classes.Abstrato.Fonte m;
                        m = (business.classes.Abstrato.Fonte)v;
                        ListView.Items.Add(m.Id.ToString() + " - ");
                        
                    }
                }
        }
    }
}
