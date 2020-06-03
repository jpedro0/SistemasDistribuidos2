using Loja.Models;
using Loja.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loja.Daos
{
    public class PedidosDao
    {
        public async Task FazerPedido(Pedido pedido) =>
            await ConsumirApi.Post("api/Pedidos", pedido);

        public async Task<IEnumerable<Pedido>> Listar() =>
            await ConsumirApi.Get<IEnumerable<Pedido>>("api/Pedidos");

        public async Task<Pedido> Buscar(int id) =>
            await ConsumirApi.Get<Pedido>($"api/Pedidos/{id}");
    }
}