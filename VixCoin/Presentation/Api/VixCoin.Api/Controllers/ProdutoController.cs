using Microsoft.AspNetCore.Mvc;
using VixCoin.Core.Dtos.Request;
using VixCoin.Core.Interfaces.Repositories;
using VixCoin.Core.Interfaces.Services;

namespace VixCoin.Api.Controllers
{

    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoRepository produtoRepository, IProdutoService produtoService)
        {
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
        }

        [HttpGet]
        [Route("todos")]
        public async Task<ActionResult> ObterTodasProduto()
        {
            var listaProduto = await _produtoRepository.ObterTodos();

            if (listaProduto.Count == 0) return NoContent();

            return Ok(listaProduto);
        }


        [HttpGet]
        [Route("{id:guid}")]
        public async Task<ActionResult> ObterUmaCategoria(Guid id)
        {
            var produto = await _produtoRepository.ObterPorId(id);
            if (produto == null) return BadRequest("Produto não encontrado");
            return Ok(produto);
        }


        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult> CadastrarProduto([FromBody] ProdutoCadastrarRequest produto)
        {
            if (produto == null) return BadRequest("Informe o nome do produto!");

            var response = await _produtoService.CadastrarProduto(produto);

            if (response == null) return BadRequest("Produto já existe");

            return Created("cadastrar", response);
        }


        [HttpPut]
        [Route("atualizar")]
        public async Task<ActionResult> AtualizarProduto([FromBody] ProdutoAtualizarRequest produto)
        {
            if (produto == null) return BadRequest("Nenhum valor chegou na API");

            var response = await _produtoService.AtualizarProduto(produto);

            return Ok(response);
        }

        [HttpDelete]
        [Route("deletar/{id:guid}")]
        public async Task<ActionResult> RemoverProduto(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("Id não informado");

            var resultado = await _produtoService.DeletarProduto(id);

            if (!resultado) return BadRequest("O Produto que está tentando deletar não existe");

            return Ok("Produto deletada com sucesso");
        }
    }
}
