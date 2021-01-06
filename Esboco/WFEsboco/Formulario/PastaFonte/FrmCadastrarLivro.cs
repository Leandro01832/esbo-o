using business.classes.Abstrato;
using business.classes.Fontes;
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
    public partial class FrmCadastrarLivro : FrmCrudFonte
    {
        public FrmCadastrarLivro(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            :base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarLivro_Load(object sender, EventArgs e)
        {
            if(modelo != null)
            {
                var fonte = (Livro)modelo;
                txt_autor.Text = fonte.NomeAutor;
                txt_livro.Text = fonte.NomeLivro;
            }
        }

        private void txt_autor_TextChanged(object sender, EventArgs e)
        {
            var fonte = (Livro)modelo;
            fonte.NomeAutor = txt_autor.Text;

        }

        private void txt_livro_TextChanged(object sender, EventArgs e)
        {
            var fonte = (Livro)modelo;
            fonte.NomeLivro = txt_livro.Text;
        }
    }
}
