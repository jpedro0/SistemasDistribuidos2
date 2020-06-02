using Loja.Models;
using Loja.Services;
using System.Threading.Tasks;

namespace Loja.Daos
{
    public class PedidosDao
    {
        public async Task FazerPedido(Pedido pedido) =>
            await ConsumirApi.Post("api/Pedidos", pedido);
    }
}