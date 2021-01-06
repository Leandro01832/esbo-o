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
    public partial class FrmCadastrarCanalTv : FrmCrudFonte
    {
        public FrmCadastrarCanalTv(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarCanalTv_Load(object sender, EventArgs e)
        {
            if(modelo != null)
            {
                var fonte = (CanalTv)modelo;
                txt_nome_canal.Text = fonte.NomeCanal;
                txt_nome_programa.Text = fonte.NomePrograma;
                mask_horario.Text = fonte.Horario.ToString();
            }
        }

        private void txt_nome_canal_TextChanged(object sender, EventArgs e)
        {
            var fonte = (CanalTv)modelo;
            fonte.NomeCanal = txt_nome_canal.Text;
        }

        private void txt_nome_programa_TextChanged(object sender, EventArgs e)
        {
            var fonte = (CanalTv)modelo;
            fonte.NomePrograma = txt_nome_programa.Text;
        }

        private void mask_horario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mask_horario.Text = "";
        }

        private void mask_horario_TextChanged(object sender, EventArgs e)
        {
            var fonte = (CanalTv)modelo;
            try
            {
                fonte.Horario = TimeSpan.Parse(mask_horario.Text);
            }
            catch (Exception)
            {
            }
        }
    }
}
