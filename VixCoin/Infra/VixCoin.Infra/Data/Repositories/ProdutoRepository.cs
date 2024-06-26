using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VixCoin.Infra.Data.MetalCoin.Infra.Data;

namespace VixCoin.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public async Task<Produto> BuscarPorNome(string nome)
        {
            var resultado = await DbSet.Where(c => c.Nome == nome).FirstOrDefaultAsync();
            return resultado;
        }
    }
}
