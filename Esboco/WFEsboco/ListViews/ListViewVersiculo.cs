using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business.database;

namespace WFEsboco.ListViews
{
    public class ListViewVersiculo : TodosListViews
    {
        public ListViewVersiculo(modelocrud modelo, string tipo) : base(modelo, tipo)
        {
        }
    }
}
