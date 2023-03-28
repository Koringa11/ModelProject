using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string PrecoDeCusto { get; set; }
        public string PrecoDeVenda { get; set; }
        public string Estoque { get; set; }
    }
}
