using Linx.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linx.API.Repositories.Base
{
    public class BaseRepository : IBaseRepository
    {
        private readonly Contexto _contexto;

        public BaseRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
        public void Atualizar<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }
        public bool SaveChanges()
        {
            _contexto.SaveChanges();
            return true;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
