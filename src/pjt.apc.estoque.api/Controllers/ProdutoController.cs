using Microsoft.AspNetCore.Mvc;
using pjt.apc.estoque.domain.Interfaces;
using pjt.apc.estoque.domain.Models;
using pjt.apc.estoque.domain.Results;

namespace pjt.apc.estoque.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoDispatcher _produtoDispatcher;

        public ProdutoController(IProdutoDispatcher produtoDispatcher)
        {
            _produtoDispatcher = produtoDispatcher;
        }

        Response result = new();

        [HttpGet]
        [Route("GetProdutos")] 
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllProdutosAsync()
        {
            var result = await _produtoDispatcher.GetAllProdutosAsync();

            if (result.Resultado != null)
                return Ok(result.Resultado.Objeto);          

            return BadRequest(result.Resultado.Mensagem); 
        }        

        [HttpGet]
        [Route("GetProdutoMasculino")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProdutosMasculino()
        {
            var result = await _produtoDispatcher.GetProdutosMasculino();

            if (result.Resultado != null)
                return Ok(result.Resultado.Objeto);

            return BadRequest(result.Resultado.Mensagem);
        }

        [HttpGet]
        [Route("GetProdutoFeminino")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProdutosFeminino()
        {
            var result = await _produtoDispatcher.GetProdutosFeminino();

            if (result.Resultado != null)
                return Ok(result.Resultado.Objeto);

            return BadRequest(result.Resultado.Mensagem);
        }

        [HttpGet]   
        [Route("GetProdutoById")] 
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProdutoById(int id)
        {
            var result = await _produtoDispatcher.GetProdutoById(id);

            if (result.Resultado.Objeto != null)
                return Ok(result.Resultado.Objeto);

            return BadRequest(result.Resultado.Mensagem);
        }

        [HttpGet]
        [Route("GetProdutoByName")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProdutoByName(string nome)
        {
            var result = await _produtoDispatcher.GetProdutoByName(nome);

            if (result.Resultado == null)
                return Ok(result.Resultado);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB.");
        }

        [HttpPost]
        [Route("AddProduto")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> InsertProdutoAsync(Produto produto)
        {
            var result = await _produtoDispatcher.InsertProdutoAsync(produto);

            if (result.Resultado != null)
                return Ok(result.Resultado.Mensagem);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB.");
        }

        [HttpPut]
        [Route("UpdateProduto{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateProdutoAsync(Produto produto)
        {
            var result = await _produtoDispatcher.UpdateProdutoAsync(produto);

            if (result.Resultado == null)
                return Ok(result.Resultado);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB.");
        }

        [HttpDelete]
        [Route("DeleteProduto{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProdutoAsync(int id)
        {
            var result = await _produtoDispatcher.DeleteProdutoAsync(id);

            if (result.Resultado == null)
                return Ok(result.Resultado);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB.");
        }
    }
} 