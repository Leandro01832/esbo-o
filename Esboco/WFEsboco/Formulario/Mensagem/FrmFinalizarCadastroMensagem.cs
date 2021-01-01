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
    public partial class FrmFinalizarCadastroMensagem : FrmCrudMensagem
    {
        public FrmFinalizarCadastroMensagem(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
           : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmFinalizarCadastroMensagem_Load(object sender, EventArgs e)
        {

        }
    }
}
