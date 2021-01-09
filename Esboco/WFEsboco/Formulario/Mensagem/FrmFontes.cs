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
    public partial class FrmFontes : FrmCrudMensagem
    {
        public FrmFontes(modelocrud modelo, bool deletar, bool atualizar, bool detalhes) 
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmFontes_Load(object sender, EventArgs e)
        {
            var m = (business.classes.Mensagem)modelo;
            lbl_fontes.Text = "As fontes da mensagem: ";

            foreach(var f in m.Fontes)
            {
                lbl_fontes.Text += f.Id.ToString() + ", ";
            }
        }
    }
}
