﻿using System;
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
    public partial class FrmFonte : FormularioListView
    {
        public FrmFonte() : base(new ListViewFonte(null,"Fonte"))
        {
            InitializeComponent();
        }

        private void FrmFonte_Load(object sender, EventArgs e)
        {

        }
    }
}
