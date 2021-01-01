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
using WFEsboco.ListViews;

namespace WFEsboco.Formulario.Mensagem
{
    public partial class FrmMensagem : FormularioListView
    {
        

        public FrmMensagem()
        : base(new ListViewMensagem(new business.classes.Mensagem(),""))
        {
            InitializeComponent();
        }

        private void FrmMensagem_Load(object sender, EventArgs e)
        {

        }
    }
}
