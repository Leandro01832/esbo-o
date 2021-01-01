
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Interface
{
    interface IAddNalista
    {
        void AdicionarNaLista(string NomeTabela, string modeloQRecebe, string modeloQPreenche, string numeros);
        void RemoverDaLista(string NomeTabela, string modeloQRecebe, string modeloQPreenche, string numeros, int id);
    }
}
