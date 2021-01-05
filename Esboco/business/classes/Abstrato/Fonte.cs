using business.classes.Fontes;
using business.database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace business.classes.Abstrato
{
    [Table("Fonte")]
    public abstract class Fonte : modelocrud
    {
        public Fonte() : base()
        {

        }

        public Fonte(int? id, bool recuperaLista) : base(id, recuperaLista)
        {
            recuperarFonte(id);          
        }
        
        public int MensagemId { get; set; }
        [ForeignKey("MensagemId")]
        public virtual Mensagem Mensagem { get; set; }

        public override string alterar(int id)
        {
            Update_padrao = $" update Fonte set  " +
            $"  MensagemId='{MensagemId}'  where Id='{id}'";
           // bd.Editar(null);
            return Update_padrao;
        }

        public override string excluir(int id)
        {
            Delete_padrao = $"delete from Fonte where Id='{id}' ";
            //bd.Excluir(null);
            return Delete_padrao;
        }

        public abstract override List<modelocrud> recuperar(int? id);

        public void recuperarFonte(int? id)
        {
            Select_padrao = $"select * from Fonte ";
            if (id != null) Select_padrao += $" where Id='{id}' ";

            var conecta = bd.obterconexao();
            conecta.Open();
            SqlCommand comando = new SqlCommand(Select_padrao, conecta);
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows == false)
            {
                bd.obterconexao().Close();
            }

            try
            {
                reader.Read();
                this.Id = int.Parse(reader["Id"].ToString());
                this.MensagemId = int.Parse(reader["MensagemId"].ToString());
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }
        }

        public static List<modelocrud> recuperarTodasFontes()
        {
            List<modelocrud> lista = new List<modelocrud>();
            Task<List<modelocrud>> t = Task.Factory.StartNew(() =>
            {
                var p = new Versiculo().recuperar(null);
                if (p != null)
                    lista.AddRange(p);
                return lista;
            });
            Task<List<modelocrud>> t2 = t.ContinueWith((task) =>
            {
                var p = new CanalTv().recuperar(null);
                if (p != null)
                task.Result.AddRange(p);
                return task.Result;
            });

            return t2.Result;
        }

        public override string salvar()
        {
            Insert_padrao = $"insert into Fonte (MensagemId) " +
                $" values ('{MensagemId}') ";

           // bd.SalvarModelo(null);
            return Insert_padrao;
        }
        
    }
}