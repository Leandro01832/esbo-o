using business.database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace business.classes
{
    [Table("Fonte")]
    public class Fonte : modelocrud
    {
        public Fonte() : base()
        {

        }

        public Fonte(int? id, bool recuperaLista) : base(id, recuperaLista)
        {
            this.Versiculo = new List<Versiculo>();
            if (recuperaLista)
            {
                var versiculos = buscarVersiculos(id);
                foreach(var v in versiculos)
                {
                    this.Versiculo.Add((Versiculo)v);
                }
            }
            
        }
        public string Autor { get; set; }
        public string Livro { get; set; }

        public List<Versiculo> Versiculo { get; set; }

        public int MensagemId { get; set; }
        [ForeignKey("MensagemId")]
        public virtual Mensagem Mensagem { get; set; }

        public override string alterar(int id)
        {
            Update_padrao = $" update {this.GetType().Name} set Autor='{Autor}', Livro='{Livro}', " +
            $"  MensagemId='{MensagemId}'  where Id='{id}'";
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
            Select_padrao = $"select * from {this.GetType().Name}";
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
                    this.Autor = reader["Autor"].ToString();
                    this.Livro = reader["Livro"].ToString();
                    this.MensagemId = int.Parse(reader["MensagemId"].ToString());
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
                        Fonte f = new Fonte();
                        f.Id = int.Parse(reader["Id"].ToString());
                        f.Autor = reader["Autor"].ToString();
                        f.Livro = reader["Livro"].ToString();
                        f.MensagemId = int.Parse(reader["MensagemId"].ToString());
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

        public override string salvar()
        {
            Insert_padrao = $"insert into {this.GetType().Name} (Livro, Autor, MensagemId) " +
                $" values ('{Livro}', '{Autor}', '{MensagemId}')";

            bd.SalvarModelo(this);
            return Insert_padrao;
        }

        public List<modelocrud> buscarVersiculos(int? id)
        {
            Select_padrao += $" select * from Versiculo where FonteId='{id}' ";

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
                    Versiculo f = (Versiculo)new Versiculo().recuperar(int.Parse(reader["Id"].ToString()))[0];
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