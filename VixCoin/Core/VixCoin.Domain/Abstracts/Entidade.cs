﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VixCoin.Core.Abstracts
{
    public abstract class Entidade
    {
        public Guid Id { get; set; }

        protected Entidade()
        {
            Id = Guid.NewGuid();
        }
    }
}
