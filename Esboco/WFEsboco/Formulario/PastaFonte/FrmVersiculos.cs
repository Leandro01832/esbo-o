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
    public partial class FrmVersiculos : FrmCrudFonte
    {
        public FrmVersiculos(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmVersiculos_Load(object sender, EventArgs e)
        {
            var f = (business.classes.Fonte)modelo;
            lbl_versiculos.Text = "Versiculos da fonte: ";

            foreach(var v in f.Versiculo)
            {
                lbl_versiculos.Text += v.Id.ToString() + ", ";
            }
        }
    }
}
