using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteMercado.Business.Intefaces;
using SiteMercado.Business.Models;
using SiteMercado.Data.Context;

namespace SiteMercado.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ApplicationDataDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}