using Linx.API.Data;
using Linx.API.Models;
using Linx.API.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linx.API.Repositories
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        private readonly Contexto _contexto;
        public ClienteRepository(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<IEnumerable<Cliente>> ListarAsync()
        {
            return await _contexto.Clientes.ToListAsync();
        }

        public async Task<Cliente> ObterAsync(int id)
        {
            return await _contexto.Clientes.FindAsync(id);
        }

        

        public async Task Adicionar(Cliente cliente)
        {
            await _contexto.Clientes.AddAsync(cliente);
            await _contexto.SaveChangesAsync();
        }

        public async Task Atualizar(Cliente cliente)
        {
            _contexto.Clientes.Update(cliente);
            await _contexto.SaveChangesAsync();
        }

        public async Task Excluir(Cliente cliente)
        {
            _contexto.Remove(cliente);
            await _contexto.SaveChangesAsync();
        }


        public async Task SaveChanges()
        {
            await _contexto.SaveChangesAsync();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
