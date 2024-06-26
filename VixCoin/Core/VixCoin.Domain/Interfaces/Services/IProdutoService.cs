using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VixCoin.Core.Dtos.Request;
using VixCoin.Core.Dtos.Response;

namespace VixCoin.Core.Interfaces.Services
{
    public interface IProdutoService 
    { 
        Task<ProdutoResponse> CadastrarProduto(ProdutoCadastrarRequest produto);
        Task<ProdutoResponse> AtualizarProduto(ProdutoAtualizarRequest produto);
        Task<bool> DeletarProduto(Guid id);
    }
}
