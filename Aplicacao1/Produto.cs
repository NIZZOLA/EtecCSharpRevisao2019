using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao1
{
    class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal Custo { get; set; }
        public decimal Margem { get; set; }
        public decimal ValorVenda { get; set; }

        public decimal Estoque { get; set; }

        public bool PodeVender( decimal quantidade )
        {
            if (Estoque >= quantidade)
                return true;
            else
                return false;
        }
    }
}
