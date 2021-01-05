using business.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFEsboco.DdataGridViews
{
   public class Pesquisar : modelocrud, IPesquisar
    {
        public List<modelocrud> BuscarPorRestricao(modelocrud modelo, string tipo, string comando)
        {
            var comand = "";
            var innerjoin = "";
            DataTable dtable = new DataTable();

            if (modelo is business.classes.Mensagem)
                innerjoin = " inner join Membro as MEM  on M.Id=MEM.Id inner join Pessoa as P on MEM.Id=P.Id";

           else if (modelo is business.classes.Mensagem)
                innerjoin = " inner join Pessoa as P on M.Id=P.Id";

            if (modelo != null)
                comand = $"select * from {modelo.GetType().Name} as M {innerjoin} ";

            if (modelo == null)
                comand = $"select * from {tipo} as M {innerjoin} ";

            if (comando != "")
                comand += $" where {comando} ";

            SqlCommand c = new SqlCommand(comand, bd.obterconexao());
            SqlDataAdapter objadp = new SqlDataAdapter(c);
            objadp.Fill(dtable);

            if (modelo == null )
            {
                List<modelocrud> lista = new List<modelocrud>();
                foreach (var item in dtable.Select(""))
                {
                }
                return lista;
            }

            if (modelo == null )
            {
                List<modelocrud> lista = new List<modelocrud>();
                foreach (var item in dtable.Select(""))
                {
                }
                return lista;
            }

            if (modelo == null )
            {
                List<modelocrud> lista = new List<modelocrud>();
                foreach (var item in dtable.Select(""))
                {
                }
                return lista;
            }

            if ( modelo is business.classes.Abstrato.Fonte)
            {
                List<modelocrud> lista = new List<modelocrud>();
                foreach (var item in dtable.Select(""))
                {
                }
                return lista;
            }

            if (modelo is business.classes.Fontes.Versiculo)
            {
                List<modelocrud> lista = new List<modelocrud>();
                foreach (var item in dtable.Select(""))
                {
                }
                return lista;
            }

            if (modelo is business.classes.Fontes.Versiculo)
            {
                List<modelocrud> lista = new List<modelocrud>();
                foreach (var item in dtable.Select(""))
                {
                }
                return lista;
            }

            return null;
        }


        public override string alterar(int id)
        {
            throw new NotImplementedException();
        }       

        public override string excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override List<modelocrud> recuperar(int? id)
        {
            throw new NotImplementedException();
        }

        public override string salvar()
        {
            throw new NotImplementedException();
        }
    }
}
