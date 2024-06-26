﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VixCoin.Core.Dtos.Request
{
    public record ProdutoAtualizarRequest
    {
        [Required]
        public Guid Id { get; set; }

        [MaxLength(25, ErrorMessage = "Produto pode ter no máximo 25 letras")]
        [MinLength(3, ErrorMessage = "Produto deve ter no mínimo 3 letras")]
        public string Nome { get; set; }

        public bool Status { get; set; }
    }
}
