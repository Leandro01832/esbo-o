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

namespace WFEsboco.Formulario.PastaVersiculo
{
    public partial class FrmCadastrarVersiculo : FrmCrudVersiculo
    {
        public FrmCadastrarVersiculo(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarVersiculo_Load(object sender, EventArgs e)
        {
            if(modelo.Id != 0)
            {
                var v = (business.classes.Versiculo)modelo;
                txt_id_fonte.Text = v.FonteId.ToString();
                txt_capitulo.Text = v.Capitulo.ToString();
                txt_texto.Text = v.Texto;
            }
        }

        private void txt_id_fonte_TextChanged(object sender, EventArgs e)
        {
            var v = (business.classes.Versiculo)modelo;
            try
            {
                v.FonteId = int.Parse(txt_id_fonte.Text);
            }
            catch { MessageBox.Show("Informe qual é a fonte deste versiculo."); txt_id_fonte.Text = ""; }
        }

        private void txt_texto_TextChanged(object sender, EventArgs e)
        {
            var v = (business.classes.Versiculo)modelo;
            v.Texto = txt_texto.Text;
        }

        private void txt_capitulo_TextChanged(object sender, EventArgs e)
        {
            var v = (business.classes.Versiculo)modelo;
            try
            {
                v.Capitulo = int.Parse(txt_capitulo.Text);
            }
            catch { MessageBox.Show("Informe o numero do capitulo."); txt_capitulo.Text = ""; }
        }
    }
}
