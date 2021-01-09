
using business.classes.Abstrato;
using business.database;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Modelo = lista.First(m => m.Id == ListView.numero);
                Modelo = Modelo.recuperar(Modelo.Id)[0];

                FrmFinalizarCadastroMensagem frm = new FrmFinalizarCadastroMensagem(Modelo, false, false, true);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            if (ListView is ListViewFonte)
            {
                Modelo = lista.First(m => m.Id == ListView.numero);
                Modelo = Modelo.recuperar(Modelo.Id)[0];

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
                Modelo = lista.First(m => m.Id == ListView.numero);
                Modelo = Modelo.recuperar(Modelo.Id)[0];

                FrmFinalizarCadastroMensagem frm = new FrmFinalizarCadastroMensagem(Modelo, false, true, false);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            if (ListView is ListViewFonte)
            {
                Modelo = lista.First(m => m.Id == ListView.numero);
                Modelo = Modelo.recuperar(Modelo.Id)[0];

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
                Modelo = lista.First(m => m.Id == ListView.numero);
                Modelo = Modelo.recuperar(Modelo.Id)[0];

                FrmFinalizarCadastroMensagem frm = new FrmFinalizarCadastroMensagem(Modelo, true, false, false);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            if (ListView is ListViewFonte)
            {
                Modelo = lista.First(m => m.Id == ListView.numero);
                Modelo = Modelo.recuperar(Modelo.Id)[0];

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
            else
            {
                if (Modelo == null && Tipo == "Fonte")
                    lista =  Fonte.recuperarTodasFontes();
            }

            ListView.Dock = DockStyle.Left;

            if (lista != null)
                foreach (var v in lista)
                {
                    ListView.Items.Add(v.ToString());                    
                }
        }
    }
}
