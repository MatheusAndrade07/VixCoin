using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VixCoin.Core.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<Produto> BuscarPorNome(string nome);
    }
}
