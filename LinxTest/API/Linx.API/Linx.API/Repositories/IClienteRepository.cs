using Linx.API.Data;
using Linx.API.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Linx.API.Models;

namespace Linx.API.Repositories
{
    public interface IClienteRepository : IBaseRepository
    {
        Task<IEnumerable<Cliente>> ListarAsync();
        Task<Cliente> ObterAsync(int id);
        Task Adicionar(Cliente cliente);
        Task Atualizar(Cliente cliente);
        Task Excluir(Cliente cliente);
    }
}
