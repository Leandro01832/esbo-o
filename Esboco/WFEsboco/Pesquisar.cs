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

        

        private void FormataDataGrid(bool Pessoa, bool Ministerio,
        bool Celula, bool Chamada, bool Reuniao, bool Historico)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            check_pesquisa_id.Enabled = true;
            check_pesquisa_nome.Enabled = false;

            if (Pessoa)
            {
                tipo = "Pessoa";
                dgdados.Columns.Clear();
                dgdados.Columns.Add("Id", "Id");
                dgdados.Columns.Add("Email", "Email");
                dgdados.Columns.Add("celula_", "Celula");
                dgdados.Columns.Add("Falta", "Falta");
                dgdados.Columns.Add("Img", "Imagem");
                dgdados.Columns[1].Width = 300;
                
                comboBox1.Items.Add("Visitante");
                comboBox1.Items.Add("Criança");
                comboBox1.Items.Add("Membro por aclamação");
                comboBox1.Items.Add("Membro por batismo");
                comboBox1.Items.Add("Membro por reconciliação");
                comboBox1.Items.Add("Membro por trandferência");
            }

            if (Ministerio)
            {
                tipo = "Ministerio";
                check_pesquisa_nome.Enabled = true;
                dgdados.Columns.Clear();
                dgdados.Columns.Add("Id", "Id");
                dgdados.Columns.Add("Nome", "Nome");
                dgdados.Columns.Add("Maximo_pessoa", "Maximo de pessoas");
                dgdados.Columns.Add("Ministro_", "Ministro");
                dgdados.Columns.Add("Proposito", "Proposito");
                dgdados.Columns[2].Width = 300;
                
                comboBox1.Items.Add("Lider de celula");
                comboBox1.Items.Add("Lider em treinamento de celula");
                comboBox1.Items.Add("Lider de ministério");
                comboBox1.Items.Add("Lider em treinamento de ministério");
                comboBox1.Items.Add("Supervisor de celula");
                comboBox1.Items.Add("Supervisor em treinamento de celula");
                comboBox1.Items.Add("Supervisor de ministério");
                comboBox1.Items.Add("Supervisor em treinamento de ministério");
            }

            if (Celula)
            {
                tipo = "Celula";
                check_pesquisa_nome.Enabled = true;
                dgdados.Columns.Clear();
                dgdados.Columns.Add("Id", "Id");
                dgdados.Columns.Add("Nome", "Nome");
                dgdados.Columns.Add("Maximo_pessoa", "Maximo de pessoas");
                dgdados.Columns.Add("Dia_semana", "Dia da semana");
                dgdados.Columns.Add("Horario", "Horário");
                dgdados.Columns[2].Width = 300;
                dgdados.Columns[4].Width = 150;
                
                comboBox1.Items.Add("Celula para adolescentes");
                comboBox1.Items.Add("Celula para adultos");
                comboBox1.Items.Add("Celula para jovens");
                comboBox1.Items.Add("Celula para crianças");
                comboBox1.Items.Add("Celula para casados");
            }

            if (Chamada)
            {
                dgdados.Columns.Clear();
                dgdados.Columns.Add("Id", "Id");
                dgdados.Columns.Add("Data_inicio", "Data de início");
                dgdados.Columns.Add("Numero_chamada", "numero da chamada");
                dgdados.Columns[1].Width = 300;
                dgdados.Columns[2].Width = 300;
            }

            if (Reuniao)
            {
                dgdados.Columns.Clear();
                dgdados.Columns.Add("Id", "Id");
                dgdados.Columns.Add("Data_reuniao", "Data da reunião");
                dgdados.Columns.Add("Horario_inicio", "Horário que inicia");
                dgdados.Columns.Add("Horario_fim", "Horário que termina");
                dgdados.Columns[1].Width = 300;
                dgdados.Columns[2].Width = 300;
            }

            if (Historico)
            {
                dgdados.Columns.Clear();
                dgdados.Columns.Add("Id", "Id");
                dgdados.Columns.Add("Data_inicio", "Data de inicio do semestre");
                dgdados.Columns.Add("Falta", "Faltas");
                dgdados.Columns.Add("pessoaid", "Identificação da pessoa");
                dgdados.Columns[1].Width = 400;
                dgdados.Columns[3].Width = 400;
            }


        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            dgdados.Font = new Font("Arial", 18);
            
        }

        private void ModificaDataGridView(modelocrud m, string tipo, string comando)
        {
            if(m == null && tipo == "Pessoa")
            {
                FormataDataGrid(true, false, false, false, false, false);
            }

            if (m == null && tipo == "Ministerio")
            {
                FormataDataGrid(false, true, false, false, false, false);
            }

            if (m == null && tipo == "Celula")
            {
                FormataDataGrid(false, false, true, false, false, false);
            }

            if(m is business.classes.Mensagem)
            {
            }

            foreach (var item in pesquisa.BuscarPorRestricao(m, tipo, comando))
            {
            }
        }

        
    }
}
