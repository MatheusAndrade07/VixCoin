﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VixCoin.Core.Dtos.Response
{
    public class ProdutoResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
