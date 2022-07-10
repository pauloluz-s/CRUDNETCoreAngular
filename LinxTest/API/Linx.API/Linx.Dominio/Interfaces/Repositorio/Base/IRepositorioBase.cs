using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linx.Dominio.Interfaces.Repositorio.Base
{
    public interface IRepositorioBase<TEntidade> where TEntidade : class
    {
        IEnumerable<TEntidade> Listar();
        TEntidade Obter(int id);
        TEntidade Adicionar(TEntidade entidade);
        TEntidade Atualizar(TEntidade entidade);
        void Excluir(int id);
        void Dispose();
    }
}
