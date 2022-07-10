using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linx.API.Repositories.Base
{
    public interface IBaseRepository
    {
        void Adicionar<T>(T entity) where T : class;
        void Atualizar<T>(T entity) where T : class;
        void Excluir(int id);

        bool SaveChanges();
        void Dispose();
    }
}
