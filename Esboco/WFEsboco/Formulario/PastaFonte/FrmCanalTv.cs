﻿using business.classes.Fontes;
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
    public partial class FrmCanalTv : FormularioListView
    {
        public FrmCanalTv() : base(new ListViewCanalTv(new CanalTv(),""))
        {
            InitializeComponent();
        }

        private void FrmCanalTv_Load(object sender, EventArgs e)
        {

        }
    }
}
