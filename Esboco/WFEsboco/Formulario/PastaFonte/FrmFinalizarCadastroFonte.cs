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
    public partial class FrmFinalizarCadastroFonte : FrmCrudFonte
    {
        public FrmFinalizarCadastroFonte(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            :base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmFinalizarCadastroFonte_Load(object sender, EventArgs e)
        {

        }
    }
}
