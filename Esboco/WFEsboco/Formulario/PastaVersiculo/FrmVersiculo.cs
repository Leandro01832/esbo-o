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

namespace WFEsboco.Formulario.PastaVersiculo
{
    public partial class FrmVersiculo : FormularioListView
    {
        public FrmVersiculo() : base(new ListViewVersiculo(new business.classes.Versiculo(), ""))
        {
            InitializeComponent();
        }

        private void FrmVersiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
