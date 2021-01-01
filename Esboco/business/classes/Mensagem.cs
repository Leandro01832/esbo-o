using business.database;
using business.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace business.classes
{
    [Table("Mensagem")]
    public class Mensagem : modelocrud
    {
        public Mensagem() : base()
        {
        }

        public Mensagem(int? id, bool recuperaLista) : base(id, recuperaLista)
        {
            this.Fonte = new List<Fonte>();
            if (recuperaLista)
            {
                var fontes = buscarFontes(id);
                foreach (var item in fontes)
                {
                    this.Fonte.Add((Fonte)item);
                }
            }
        }
        public List<Fonte> Fonte { get; set; }
        public string Tipo { get; set; }

        public override string alterar(int id)
        {
            Update_padrao = $"update {this.GetType().Name} set Tipo='{Tipo}' where Id='{id}'";

            bd.Editar(this);
            return Update_padrao;
        }

        public override string excluir(int id)
        {
            Delete_padrao = $"Delete from {this.GetType().Name} where Id='{id}'";

            bd.Excluir(this);
            return Delete_padrao;
        }

        public override List<modelocrud> recuperar(int? id)
        {
            Select_padrao = $"select * from {this.GetType().Name} ";
            if (id != null) Select_padrao += $" where Id='{id}' ";

            var conecta = bd.obterconexao();
            conecta.Open();
            SqlCommand comando = new SqlCommand(Select_padrao, conecta);
            SqlDataReader reader = comando.ExecuteReader();
            List<modelocrud> modelos = new List<modelocrud>();
            
            if(reader.HasRows == false)
            {
                bd.obterconexao().Close();
                return modelos;
            }

            if(id != null)
            {
                try
                {
                    reader.Read();
                    this.Id = int.Parse(reader["Id"].ToString());
                    this.Tipo = reader["Tipo"].ToString();
                    reader.Close();
                    modelos.Add(this);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Aconteceu um erro: " + ex.Message);
                }
                return modelos;
            }
            else
            {
                try
                {
                    while (reader.Read())
                    {
                        Mensagem msm = new Mensagem();
                        msm.Id = int.Parse(reader["Id"].ToString());
                        msm.Tipo = reader["Tipo"].ToString();
                        modelos.Add(msm);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aconteceu um erro: " + ex.Message);
                }
                return modelos;
            }
            
        }

        public override string salvar()
        {
            Insert_padrao = $"insert into {this.GetType().Name} (Tipo) values ('{Tipo}') ";

            bd.SalvarModelo(this);
            return Insert_padrao;
        }

        public List<modelocrud> buscarFontes(int? id)
        {
            Select_padrao = $"select * from Fonte where MensagemId='{id}' ";

            var conecta = bd.obterconexao();
            conecta.Open();
            SqlCommand comando = new SqlCommand(Select_padrao, conecta);
            SqlDataReader reader = comando.ExecuteReader();
            List<modelocrud> modelos = new List<modelocrud>();

            if (reader.HasRows == false)
            {
                bd.obterconexao().Close();
                return modelos;
            }

            try
            {
                while (reader.Read())
                {
                    Fonte f = (Fonte) new Fonte(int.Parse(reader["Id"].ToString()), false)
                    .recuperar(int.Parse(reader["Id"].ToString()))[0];
                    modelos.Add(f);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }
            return modelos;
        }
    }
}
