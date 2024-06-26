using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VixCoin.Core.Dtos
{
    public class ProdutoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int QuantidadeProdutosVinculados { get; set; }
    }
}
