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
using business.classes.Fontes;
using business.classes;

namespace WFEsboco
{
    

    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            pesquisa = new WFEsboco.DdataGridViews.Pesquisar();
            modelo = null;
            
            InitializeComponent();
        }

       WFEsboco.DdataGridViews.Pesquisar pesquisa;
        modelocrud modelo;
        string comando = "";
        string tipo = "";

        private void FormataDataGrid(bool Mensagem, bool Fonte)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            check_pesquisa_id.Enabled = true;

            if (Mensagem)
            {
                tipo = "Mensagem";
                dgdados.Columns.Clear();
                dgdados.Columns.Add("Id", "Id");
                
            }

            if (Fonte)
            {
                tipo = "Fonte";
                dgdados.Columns.Clear();
                dgdados.Columns.Add("Id", "Id");
                dgdados.Columns.Add("MensagemId", "Id da mensagem");

                comboBox1.Items.Add("Canal de tv");
                comboBox1.Items.Add("Versiculo");
            }
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            dgdados.Font = new Font("Arial", 18);
            
        }

        private void ModificaDataGridView(modelocrud m, string tipo, string comando)
        {
            if(m == null && tipo == "Fonte")
            {
                FormataDataGrid(false, true);
            }

            if(m is Mensagem)
            FormataDataGrid(true, false);

            if (m is Versiculo)
            {
                dgdados.Columns.Add("Livro", "Livro");
                dgdados.Columns.Add("Capitulo", "Capitulo");
                dgdados.Columns.Add("Texto", "Texto");
            }

            if (m is CanalTv)
            {
                dgdados.Columns.Add("NomeCanal", "NomeCanal");
                dgdados.Columns.Add("NomePrograma", "NomePrograma");
                dgdados.Columns.Add("Horario", "Horario");
            }

            foreach (var item in pesquisa.BuscarPorRestricao(m, tipo, comando))
            {
                if (m is business.classes.Abstrato.Fonte)
                {
                    if (m is CanalTv)
                    {
                        CanalTv info = (CanalTv)item;
                        dgdados.Rows.Add(info.Id, info.MensagemId, info.NomeCanal, info.NomePrograma,
                        info.Horario);
                    }

                    if (m is Versiculo)
                    {
                        Versiculo info = (Versiculo)item;
                        dgdados.Rows.Add(info.Id, info.MensagemId, info.Livro,
                        info.Capitulo, info.Texto);
                    }
                }
            }
        }

        private void radio_fonte_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "Escolha o tipo se necessário.";
            comando = "";
            FormataDataGrid(false, true);
            if (radio_fonte.Checked)
                MessageBox.Show("Você esta vendo informações de fontes.");

            foreach (var item in pesquisa.BuscarPorRestricao(modelo, tipo, comando))
            {
                var dado = (business.classes.Abstrato.Fonte)item;
                dgdados.Rows.Add(dado.Id, dado.MensagemId);
            }

        }

        private void radio_mensagem_CheckedChanged(object sender, EventArgs e)
        {
            comando = "";
            modelo = new Mensagem();
            FormataDataGrid(true, false);
            if (radio_fonte.Checked)
                MessageBox.Show("Você esta vendo informações de Mensagens.");

            foreach (var item in pesquisa.BuscarPorRestricao(modelo, tipo, comando))
            {
                var dado = (business.classes.Mensagem)item;
                dgdados.Rows.Add(dado.Id, dado.Tipo);
            }
        }

        private void check_pesquisa_id_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check_pesquisa_nome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check_pesquisa_texto_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void check_pesquisa_tipo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check_pesquisa_id_CheckedChanged_1(object sender, EventArgs e)
        {
            if (check_pesquisa_id.Checked)
            {
                MessageBox.Show("Digite dois valores e o resultado da pesquisa será entre esses dois valores.");
                txt_pesquisa_id_valor1.Enabled = true;
                txt_pesquisa_id_valor2.Enabled = true;
                if (comando != "") comando += " and ";
                comando += $" Id>='@pesquisaid1' " +
                        $" and Id<='@pesquisaid2' ";
                txt_pesquisa_id_valor1.Focus();
            }
        }
    }
}
