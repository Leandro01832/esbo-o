using business.classes.Abstrato;
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
    public partial class FrmDadoFonte : FrmCrudFonte
    {
        public FrmDadoFonte(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmDadoFonte_Load(object sender, EventArgs e)
        {
            if(modelo != null)
            {
                var fonte = (Fonte)modelo;
                txt_id_mensagem.Text = fonte.MensagemId.ToString();
            }
        }

        private void txt_id_mensagem_TextChanged(object sender, EventArgs e)
        {
            var fonte = (Fonte)modelo;
            try
            {
                fonte.MensagemId = int.Parse(txt_id_mensagem.Text);
            }
            catch { MessageBox.Show("Informe o numero de identificação da mensagem da fonte."); }
        }
    }
}
