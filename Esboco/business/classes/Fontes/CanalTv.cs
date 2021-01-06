using business.classes.Abstrato;
using business.database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace business.classes.Fontes
{
    [Table("CanalTv")]
   public class CanalTv : Fonte
    {
        public string NomeCanal { get; set; }
        public string NomePrograma { get; set; }

        [Display(Name = "Horário")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan? Horario { get; set; }


        public override List<modelocrud> recuperar(int? id)
        {
            Select_padrao = $" select * from {this.GetType().Name} as M inner join Fonte as F on M.Id=F.Id ";
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
                    this.NomeCanal = reader["NomeCanal"].ToString();
                    this.NomePrograma = reader["NomePrograma"].ToString();
                    this.Horario = TimeSpan.Parse(reader["Horario"].ToString());
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
                        CanalTv v = new CanalTv();
                        v.Id = int.Parse(reader["Id"].ToString());
                        v.MensagemId = int.Parse(reader["MensagemId"].ToString());
                        v.NomeCanal = reader["NomeCanal"].ToString();
                        v.NomePrograma = reader["NomePrograma"].ToString();
                        v.Horario = TimeSpan.Parse(reader["Horario"].ToString());
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
            Insert_padrao += $"insert into {this.GetType().Name} (NomeCanal, NomePrograma, Horario, Id) " +
                $" values ('{NomeCanal}', '{NomePrograma}', '{Horario}', IDENT_CURRENT('Fonte'))";

            bd.SalvarModelo(this);
            return Insert_padrao;
        }

        public override string excluir(int id)
        {
            Delete_padrao = $"Delete from {this.GetType().Name} where Id='{id}' " + base.excluir(id);

            bd.Excluir(this);
            return Delete_padrao;
        }

        public override string alterar(int id)
        {
            Update_padrao = base.alterar(id);
            Update_padrao += $"update {this.GetType().Name} set NomeCanal='{NomeCanal}', " +
                $" NomePrograma={NomePrograma}', Horario='{Horario}'";

            bd.Editar(this);
            return Update_padrao;
        }
    }
}
