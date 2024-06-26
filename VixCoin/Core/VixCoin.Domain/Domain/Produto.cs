using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VixCoin.Core.Abstracts;

namespace VixCoin.Core.Domain
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }       
        public bool Ativo { get; set; }
        /* EF Relation */
        public Guid FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
