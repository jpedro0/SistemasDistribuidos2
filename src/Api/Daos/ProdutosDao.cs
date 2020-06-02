using Api.Contextos;
using Api.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Api.Daos
{
    public class ProdutosDao
    {
        private readonly ApiContexto contexto;

        public ProdutosDao()
        {
            this.contexto = new ApiContexto();
        }

        public async Task<IEnumerable<Produto>> Listar() =>
            await this.contexto.Produtos.ToListAsync();
    }
}