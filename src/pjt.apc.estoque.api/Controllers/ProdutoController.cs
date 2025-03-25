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
        [Route("ListaPorId")] 
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllProdutosOrderByIdAsync()
        {
            var result = await _produtoDispatcher.GetAllProdutosOrderByIdAsync();

            if (result.Resultado == null)
                return Ok(result.Resultado);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB."); 
        }

        [HttpGet]
        [Route("ListaPorNome")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllProdutosOrderByNameAsync()
        {
            var result = await _produtoDispatcher.GetAllProdutosOrderByNameAsync();

            if (result.Resultado == null)
                return Ok(result.Resultado);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB.");
        }

        [HttpGet]
        [Route("Masculino")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProdutosOrderByGeneroMasculino()
        {
            var result = await _produtoDispatcher.GetProdutosOrderByGeneroMasculino();

            if (result.Resultado == null)
                return Ok(result.Resultado);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB.");
        }

        [HttpGet]
        [Route("Feminino")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProdutosOrderByGeneroFeminino()
        {
            var result = await _produtoDispatcher.GetProdutosOrderByGeneroFeminino();

            if (result.Resultado == null)
                return Ok(result.Resultado);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB.");
        }

        [HttpGet]   
        [Route("{id}")] 
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProdutoById(int id)
        {
            var result = await _produtoDispatcher.GetProdutoById(id);

            if (result.Resultado == null)
                return Ok(result.Resultado);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB.");
        }

        [HttpGet]
        [Route("{nome}")]
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
        [Route("")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(Produto[]))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(Erro))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> InsertProdutoAsync(Produto produto)
        {
            var result = await _produtoDispatcher.InsertProdutoAsync(produto);

            if (result.Resultado == null)
                return Ok(result.Resultado);

            //if (result.StatusCode == StatusCodes.Status404NotFound)
            //    return NotFound();

            return BadRequest("Não foi possível conectar ao DB.");
        }

        [HttpPut]
        [Route("{id}")]
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
        [Route("{id}")]
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