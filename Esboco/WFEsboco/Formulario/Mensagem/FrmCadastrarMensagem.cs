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

namespace WFEsboco.Formulario.Mensagem
{
    public partial class FrmCadastrarMensagem : FrmCrudMensagem
    {
        public FrmCadastrarMensagem(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
        : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmMensagem_Load(object sender, EventArgs e)
        {
            if(modelo.Id != 0)
            {
                var m = (business.classes.Mensagem)modelo;
                txt_tipo.Text = m.Tipo;
            }
        }

        private void txt_tipo_TextChanged(object sender, EventArgs e)
        {
            var m = (business.classes.Mensagem)modelo;
            m.Tipo = txt_tipo.Text;
        }
    }
}
