
using business.classes.Fontes;
using business.database;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFEsboco.Formulario.Mensagem;
using WFEsboco.Formulario.PastaFonte;

namespace WFEsboco
{
    public partial class WFCrud : Form
    {
        public WFCrud()
        {
            InitializeComponent();
        }

        private Label InfoForm;

        // botões para crud
        private Button proximo;
        private Button Deletar;
        private Button atualizar;
        private Button FinalizarCadastro;

        // Botões para Mensagem
        private Button BtnFontes;
        private Button BtnDadoMensagem;

        //Botões para Fontes
        private Button BtnDadoClasse;
        private Button BtnDadoFonte;
        

        public modelocrud modelo { get; set; }
        public bool CondicaoDeletar { get => condicaoDeletar; set => condicaoDeletar = value; }
        public bool CondicaoAtualizar { get => condicaoAtualizar; set => condicaoAtualizar = value; }
        public bool CondicaoDetalhes { get => condicaoDetalhes; set => condicaoDetalhes = value; }
        
        public Button Proximo { get => proximo; set => proximo = value; }
        public Button Atualizar { get => atualizar; set => atualizar = value; }

        private bool condicaoDeletar;
        private bool condicaoAtualizar;
        private bool condicaoDetalhes;
        

        public WFCrud(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
        {
            condicaoDeletar = deletar;
            condicaoAtualizar = atualizar;
            condicaoDetalhes = detalhes;

            this.modelo = modelo;
            InfoForm = new Label();
            InfoForm.Location = new System.Drawing.Point(10, 10);
            InfoForm.Width = 1200;
            InfoForm.Font = new Font("Arial", 12);

            BtnFontes = new Button();
            BtnFontes.Location = new System.Drawing.Point(50, 50);
            BtnFontes.Size = new System.Drawing.Size(100, 50);
            BtnFontes.Text = "Fontes da mensagem";
            BtnFontes.Click += BtnFontes_Click;
            BtnFontes.Visible = false;

            BtnDadoMensagem = new Button();
            BtnDadoMensagem.Location = new System.Drawing.Point(200, 50);
            BtnDadoMensagem.Size = new System.Drawing.Size(100, 50);
            BtnDadoMensagem.Text = "dados da mensagem";
            BtnDadoMensagem.Click += BtnDadoMensagem_Click;
            BtnDadoMensagem.Visible = false;

            BtnDadoClasse = new Button();
            BtnDadoClasse.Location = new System.Drawing.Point(50, 50);
            BtnDadoClasse.Size = new System.Drawing.Size(100, 50);
            BtnDadoClasse.Text = "Dados da classe";
            BtnDadoClasse.Click += BtnDadoClasse_Click;
            BtnDadoClasse.Visible = false;

            BtnDadoFonte = new Button();
            BtnDadoFonte.Location = new System.Drawing.Point(200, 50);
            BtnDadoFonte.Size = new System.Drawing.Size(100, 50);
            BtnDadoFonte.Text = "dados da fonte";
            BtnDadoFonte.Click += BtnDadoFonte_Click;
            BtnDadoFonte.Visible = false;

            Proximo = new Button();
            Proximo.Click += Proximo_Click;
            Proximo.Text = "Proximo";
            Proximo.Location = new Point(650, 150);
            Proximo.Size = new System.Drawing.Size(100, 50);

            Deletar = new Button();
            Deletar.Click += Deletar_Click;
            Deletar.Text = "Deletar";
            Deletar.Location = new Point(650, 250);
            Deletar.Size = new System.Drawing.Size(100, 50);
            Deletar.Visible = false;

            Atualizar = new Button();
            Atualizar.Click += Atualizar_Click;
            Atualizar.Text = "Atualizar";
            Atualizar.Location = new Point(650, 350);
            Atualizar.Size = new System.Drawing.Size(100, 50);
            Atualizar.Visible = false;

            FinalizarCadastro = new Button();
            FinalizarCadastro.Click +=  FinalizarCadastro_Click;
            FinalizarCadastro.Text = "Finalizar Cadastro";
            FinalizarCadastro.Location = new Point(650, 250);
            FinalizarCadastro.Size = new System.Drawing.Size(100, 50);
            FinalizarCadastro.Visible = false;

            this.Controls.Add(Proximo);
            this.Controls.Add(Deletar);
            this.Controls.Add(Atualizar);

            this.Controls.Add(BtnFontes);
            this.Controls.Add(BtnDadoMensagem);

            this.Controls.Add(BtnDadoFonte);
            this.Controls.Add(BtnDadoClasse);

            this.Controls.Add(FinalizarCadastro);

            InfoForm.Visible = false;
            this.Controls.Add(InfoForm);

            if (modelo is business.classes.Mensagem &&
            this.GetType().Name == "FrmFinalizarCadastroMensagem")
            {
                BtnFontes.Visible = true;
                BtnDadoMensagem.Visible = true;
            }

            if (modelo is business.classes.Abstrato.Fonte &&
            this is FrmFinalizarCadastroFonte)
            {
                BtnDadoClasse.Visible = true;
                BtnDadoFonte.Visible = true;
            }

            if (modelo is business.classes.Fontes.Versiculo &&
            this is FrmFinalizarCadastroFonte)
            {
                BtnDadoClasse.Visible = true;
                BtnDadoFonte.Visible = true;
            }


            if (condicaoAtualizar || condicaoDeletar || condicaoDetalhes)
            {
                InfoForm.Visible = true;
                Proximo.Visible = false;
                FinalizarCadastro.Visible = false;

                
                InfoForm.Text = "Identificação: " + modelo.Id.ToString() + " - ";

                if (modelo is business.classes.Mensagem)
                {
                    var m = (business.classes.Mensagem)modelo;
                    InfoForm.Text += m.Tipo;
                    
                }

                if (modelo is business.classes.Abstrato.Fonte)
                {
                    var m = (business.classes.Abstrato.Fonte)modelo;
                  //  InfoForm.Text += m.Livro;
                }

                if (modelo is business.classes.Fontes.Versiculo)
                {
                    var m = (business.classes.Fontes.Versiculo)modelo;
                    InfoForm.Text += "Capitulo: " + m.Capitulo;
                }

            }

            if(!condicaoAtualizar && !condicaoDeletar && !condicaoDetalhes)
                Proximo.Visible = true;

            if (!condicaoAtualizar && !condicaoDeletar && !condicaoDetalhes
                && this.GetType().Name == "FrmFinalizarCadastroMensagem" ||
                !condicaoAtualizar && !condicaoDeletar && !condicaoDetalhes
                && this.GetType().Name == "FrmFinalizarCadastroFonte" ||
                !condicaoAtualizar && !condicaoDeletar && !condicaoDetalhes
                && this.GetType().Name == "FrmFinalizarCadastroVersiculo")
            {
                Proximo.Visible = false;
                FinalizarCadastro.Visible = true;
            }                

            if (this.GetType().Name != "FinalizarCadastro" && condicaoAtualizar)
                Atualizar.Visible = true;


            if (this.GetType().Name != "FinalizarCadastro" && condicaoDeletar)
                Deletar.Visible = true;
        }

        private void BtnDadoClasse_Click(object sender, EventArgs e)
        {
            if(modelo is CanalTv)
            {
                FrmCadastrarCanalTv frm =
                new FrmCadastrarCanalTv(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            if(modelo is Versiculo)
            {
                FrmCadastrarVersiculo frm = 
                new FrmCadastrarVersiculo(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            if (modelo is Livro)
            {
                FrmCadastrarLivro frm =
                new FrmCadastrarLivro(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

       

        private void BtnDadoFonte_Click(object sender, EventArgs e)
        {
            FrmDadoFonte frm = 
            new FrmDadoFonte(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        

        private void BtnDadoMensagem_Click(object sender, EventArgs e)
        {
            FrmCadastrarMensagem frm =
            new FrmCadastrarMensagem(modelo, condicaoDeletar, condicaoAtualizar, condicaoDetalhes);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void BtnFontes_Click(object sender, EventArgs e)
        {
            FrmFontes frm =
            new FrmFontes(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private  void FinalizarCadastro_Click(object sender, EventArgs e)
        {
            FinalizarCadastro.Enabled = false;

            modelo.salvar();            

            MessageBox.Show("Cadastro realiado com sucesso.");
            this.Close();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

            modelo.alterar(modelo.Id);
            MessageBox.Show("Informação atualizada com sucesso.");
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            modelo.excluir(modelo.Id);
        }

        private void Proximo_Click(object sender, EventArgs e)
        {
            if(this is FrmCrudMensagem)
            {
                if(this is FrmCadastrarMensagem)
                {
                    FrmFinalizarCadastroMensagem frm =
                    new FrmFinalizarCadastroMensagem(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
                    frm.MdiParent = this.MdiParent;
                    this.Close();
                    frm.Show();
                }

            }

            if(this is FrmCrudFonte)
            {
                if(this is FrmDadoFonte)
                {
                    if (modelo is Versiculo)
                    {
                        FrmCadastrarVersiculo frm =
                        new FrmCadastrarVersiculo(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
                        frm.MdiParent = this.MdiParent;
                        this.Close();
                        frm.Show();
                    }

                    if (modelo is CanalTv)
                    {
                        FrmCadastrarCanalTv frm =
                        new FrmCadastrarCanalTv(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
                        frm.MdiParent = this.MdiParent;
                        this.Close();
                        frm.Show();
                    }

                    if (modelo is Livro)
                    {
                        FrmCadastrarLivro frm =
                        new FrmCadastrarLivro(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
                        frm.MdiParent = this.MdiParent;
                        this.Close();
                        frm.Show();
                    }
                }

                if (this is FrmCadastrarVersiculo || this is FrmCadastrarCanalTv || this is FrmCadastrarLivro)
                {
                    FrmFinalizarCadastroFonte frm =
                    new FrmFinalizarCadastroFonte(modelo, CondicaoDeletar, CondicaoAtualizar, CondicaoDetalhes);
                    frm.MdiParent = this.MdiParent;
                    this.Close();
                    frm.Show();
                }
            }
            
        }

        private void WFCrud_Load(object sender, EventArgs e)
        {

        }
    }
}
