using business.classes.Fontes;
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

namespace WFEsboco.Formulario.PastaFonte
{
    public partial class FrmLivro : FormularioListView
    {
        public FrmLivro() : base(new ListViewLivro(new Livro(), ""))
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {

        }
    }
}
