using Linx.API.Data;
using Linx.API.Models;
using Linx.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linx.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        private readonly IClienteRepository _repository;

        public ClientesController(IClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> ListarClientesAsync()
        {
            var clientes = await _repository.ListarAsync();
            return Ok(clientes);
        }

        [HttpGet("{clienteId}")]
        public async Task<ActionResult<Cliente>> ObterClientesAsync([FromRoute] int clienteId)
        {
            Cliente cliente = await _repository.ObterAsync(clienteId);
            if (cliente == null)
                return NotFound("Cliente não encontrado");

            return cliente;
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> SalvarClientesAsync([FromBody] Cliente cliente)
        {
            await _repository.Adicionar(cliente);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarClientesAsync([FromBody] Cliente cliente)
        {
            await _repository.Atualizar(cliente);
            return Ok();
        }

        [HttpDelete("{clienteId}")]
        public async Task<ActionResult> ExcluirClientesAsync([FromRoute] int clienteId)
        {
            Cliente cliente = await _repository.ObterAsync(clienteId);
            if (cliente == null)
                return NotFound("Cliente não encontrado");

            await _repository.Excluir(cliente);

            return Ok();
        }
    }
}