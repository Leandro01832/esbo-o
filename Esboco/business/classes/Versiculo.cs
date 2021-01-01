using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Windows.Forms;
using business.database;

namespace business.classes
{
    public class Versiculo : modelocrud
    {
        public Versiculo() : base()
        {

        }

        public string Texto { get; set; }
        public int Capitulo { get; set; }
        public int FonteId { get; set; }
        [ForeignKey("FonteId")]
        public virtual Fonte Fonte { get; set; }

        public override string alterar(int id)
        {
            Update_padrao = $"update {this.GetType().Name} where Id='{id}' ";
            bd.Editar(this);
            return Update_padrao;
        }

        public override string excluir(int id)
        {
            Delete_padrao = $"delete from {this.GetType().Name} where Id='{id}' ";
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

            if (reader.HasRows == false)
            {
                bd.obterconexao().Close();
                return modelos;
            }

            if (id != null)
            {
                try
                {
                    reader.Read();
                    this.Id = int.Parse(reader["Id"].ToString());
                    this.Capitulo = int.Parse(reader["Capitulo"].ToString());
                    this.FonteId = int.Parse(reader["FonteId"].ToString());
                    this.Texto = reader["Texto"].ToString();
                    reader.Close();
                    modelos.Add(this);
                }
                catch (Exception ex)
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
                        Versiculo v = new Versiculo();
                        v.Id = int.Parse(reader["Id"].ToString());
                        v.Capitulo = int.Parse(reader["Id"].ToString());
                        v.FonteId = int.Parse(reader["FonteId"].ToString());
                        v.Texto = reader["Texto"].ToString();
                        modelos.Add(v);
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
            Insert_padrao = $"insert into {this.GetType().Name} (Capitulo, FonteId, Texto) " +
                $" values ('{Capitulo}', '{FonteId}', '{Texto}')";
            bd.SalvarModelo(this);
            return Insert_padrao;
        }
    }
}