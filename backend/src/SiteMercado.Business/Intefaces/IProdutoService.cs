using System;
using System.Threading.Tasks;
using SiteMercado.Business.Models;

namespace SiteMercado.Business.Intefaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}