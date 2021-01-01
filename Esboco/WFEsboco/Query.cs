using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEsboco
{
   public partial class Pesquisar
    {
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void check_pesquisa_nome_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pesquisa_nome.Checked)
            {
                MessageBox.Show("Digite um nome parecido com o que lembra para ser feito pesquisa.");
                txt_pesquisa_nome.Enabled = true;
                txt_pesquisa_nome.Focus();
            }
        }

        private void txt_pesquisa_nome_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void check_pesquisa_id_CheckedChanged(object sender, EventArgs e)
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

        private void txt_pesquisa_id_valor1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var v = int.Parse(txt_pesquisa_id_valor1.Text);
                var v2 = int.Parse(txt_pesquisa_id_valor2.Text);
            }
            catch
            {
                MessageBox.Show("Informe um numero de identificação");
                txt_pesquisa_id_valor1.Text = "";
                txt_pesquisa_id_valor2.Text = "";
            }
        }

        private void txt_pesquisa_id_valor2_TextChanged(object sender, EventArgs e)
        {
            if (comando != "") comando += " and ";
            try
            {
                var v = int.Parse(txt_pesquisa_id_valor1.Text);
                var v2 = int.Parse(txt_pesquisa_id_valor2.Text);
            }
            catch
            {
                MessageBox.Show("Informe um numero de identificação");
                txt_pesquisa_id_valor1.Text = "";
                txt_pesquisa_id_valor2.Text = "";
            }
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            comando = "";
            ModificaDataGridView(modelo, tipo, comando);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            ModificaDataGridView(modelo, tipo, comando);
        }
    }
}
