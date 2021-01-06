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
        

        private void txt_pesquisa_nome_TextChanged(object sender, EventArgs e)
        {
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
