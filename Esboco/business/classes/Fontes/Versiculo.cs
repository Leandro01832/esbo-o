using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Windows.Forms;
using business.classes.Abstrato;
using business.database;

namespace business.classes.Fontes
{
    [Table("Versiculo")]
    public class Versiculo : Fonte
    {
        public Versiculo() : base()
        {

        }
        public string Livro { get; set; }
        public string Texto { get; set; }
        public int Capitulo { get; set; }

        public override string alterar(int id)
        {
            Update_padrao = base.alterar(id);
            Update_padrao += $"update {this.GetType().Name} set Livro={Livro}, Texto={Texto}, " +
            $" Capitulo={Capitulo} where Id='{id}' ";
            bd.Editar(this);
            return Update_padrao;
        }

        public override string excluir(int id)
        {
            Delete_padrao = $"delete from {this.GetType().Name} where Id='{id}' " + base.excluir(id);
            bd.Excluir(this);
            return Delete_padrao;
        }

        public override List<modelocrud> recuperar(int? id)
        {
            Select_padrao = $"select * from {this.GetType().Name} as M inner join Fonte as F on M.Id=F.Id ";
            if (id != null) Select_padrao += $" where M.Id='{id}' ";

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
                base.recuperar(id);
                try
                {
                    reader.Read();
                    this.Id = int.Parse(reader["Id"].ToString());
                    this.MensagemId = int.Parse(reader["MensagemId"].ToString());
                    this.Capitulo = int.Parse(reader["Capitulo"].ToString());
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
                        v.MensagemId = int.Parse(reader["MensagemId"].ToString());
                        v.Capitulo = int.Parse(reader["Capitulo"].ToString());
                        v.Texto = reader["Texto"].ToString();
                        v.Livro = reader["Livro"].ToString();
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
            Insert_padrao = base.salvar();
            Insert_padrao += $" insert into {this.GetType().Name} (Capitulo, Texto, Livro, Id) " +
            $" values ('{Capitulo}', '{Texto}', '{Livro}', IDENT_CURRENT('Fonte'))";
            bd.SalvarModelo(this);
            return Insert_padrao;
        }

        
    }
}