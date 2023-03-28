using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class ProdutoNotaEntrada
    {
        public Guid Id { get; set; }
        public Produto ProdutoNota { get; set; }
        public string PrecoCustoCompra { get; set; }
        public string QuantidadeComprada { get; set; }
        
        protected bool Equals(ProdutoNotaEntrada Other)
        {
            return Id.Equals(Other.Id);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType()
                    != typeof(ProdutoNotaEntrada))
                return false;
            return Equals((ProdutoNotaEntrada)obj);
        }

        public override int GetHashCode()
        {
            return ProdutoNota.GetHashCode();
        }
    }
}
