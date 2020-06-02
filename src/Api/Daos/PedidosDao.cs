using Api.Contextos;
using Api.Models;
using System.Threading.Tasks;

namespace Api.Daos
{
    public class PedidosDao
    {
        private readonly ApiContexto contexto;

        public PedidosDao()
        {
            this.contexto = new ApiContexto();
        }

        public async Task Salvar(Pedido pedido)
        {
            this.contexto.Pedidos.Add(pedido);
            await this.contexto.SaveChangesAsync();
        }
    }
}