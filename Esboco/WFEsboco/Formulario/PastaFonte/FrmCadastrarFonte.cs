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

namespace WFEsboco.Formulario.PastaFonte
{
    public partial class FrmCadastrarFonte : FrmCrudFonte
    {
        public FrmCadastrarFonte(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarFonte_Load(object sender, EventArgs e)
        {

        }

        private void txt_mensagem_id_TextChanged(object sender, EventArgs e)
        {
            var f = (business.classes.Fonte)modelo;
            try
            {
                f.MensagemId = int.Parse(txt_mensagem_id.Text);
            }
            catch { MessageBox.Show("Informe qual é a fonte deste versiculo.");
            txt_mensagem_id.Text = ""; }
        }

        private void txt_livro_TextChanged(object sender, EventArgs e)
        {
            var f = (business.classes.Fonte)modelo;
            f.Livro = txt_livro.Text;
        }

        private void txt_autor_TextChanged(object sender, EventArgs e)
        {
            var f = (business.classes.Fonte)modelo;
            f.Autor = txt_autor.Text;
        }
    }
}
