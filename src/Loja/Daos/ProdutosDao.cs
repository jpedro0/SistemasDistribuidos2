using Loja.Models;
using Loja.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loja.Daos
{
    public class ProdutosDao
    {
        public async Task<IEnumerable<Produto>> Listar() =>
            await ConsumirApi.Get<IEnumerable<Produto>>("api/Produtos");
    }
}