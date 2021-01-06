using business.classes.Abstrato;
using business.database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace business.classes.Fontes
{
    [Table("Livro")]
    public class Livro : Fonte
    {
        public string NomeLivro { get; set; }
        public string NomeAutor { get; set; }

        public Livro() : base()
        {

        }

        public Livro(int? id, bool recuperaLista) : base(id, recuperaLista)
        {

        }

        public override List<modelocrud> recuperar(int? id)
        {
            Select_padrao = $"select * from {this.GetType().Name} as M inner join Fonte as F on M.Id=F.Id ";
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
                    this.MensagemId = int.Parse(reader["MensagemId"].ToString());
                    this.NomeAutor = reader["NomeAutor"].ToString();
                    this.NomeLivro = reader["NomeLivro"].ToString();
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
                        Livro livro = new Livro();
                        livro.Id = int.Parse(reader["Id"].ToString());
                        livro.MensagemId = int.Parse(reader["MensagemId"].ToString());
                        livro.NomeAutor = reader["NomeAutor"].ToString();
                        livro.NomeLivro = reader["NomeLivro"].ToString();
                        modelos.Add(livro);
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
            Insert_padrao =  base.salvar();
            Insert_padrao += $"insert into {this.GetType().Name} " +
                $" (NomeAutor, NomeLivro, Id) values ('{NomeAutor}', '{NomeLivro}', IDENT_CURRENT('Fonte'))";

            bd.SalvarModelo(this);
            return Insert_padrao;
        }

        public override string excluir(int id)
        {
            Delete_padrao = $"delete from {this.GetType().Name} where Id='{id}' " + base.excluir(id);
            return Delete_padrao;
        }

        public override string alterar(int id)
        {
            Update_padrao = base.alterar(id);
            Update_padrao += $" update {this.GetType().Name} " +
            $" set NomeAutor={NomeAutor}, NomeLivro={NomeLivro} where Id='{id}' ";

            return Update_padrao;
        }
    }
}
