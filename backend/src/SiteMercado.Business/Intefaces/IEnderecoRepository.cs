using System;
using System.Threading.Tasks;
using SiteMercado.Business.Models;

namespace SiteMercado.Business.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}