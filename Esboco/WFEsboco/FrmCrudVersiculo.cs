﻿using business.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEsboco
{
    public partial class FrmCrudVersiculo : WFCrud
    {

        public FrmCrudVersiculo()
        {
                
        }
        public FrmCrudVersiculo(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCrudVersiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
