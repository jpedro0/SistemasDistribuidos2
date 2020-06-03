using Loja.Daos;
using Loja.Models;
using Loja.Services;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Loja.Controllers
{
    public class PedidosController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var pedidos = await new PedidosDao().Listar();

            return View(pedidos);
        }

        public async Task<ActionResult> Detalhes(int id)
        {
            var pedidos = await new PedidosDao().Buscar(id);

            return View(pedidos);
        }

        public async Task<ActionResult> FazerPedido()
        {
            var pedido = new Pedido
            {
                ItensDoPedido = CarrinhoService.ObterCarrinho().Select(x => new ItensDoPedido(x.Key, x.Value))
            };

            await new PedidosDao().FazerPedido(pedido);

            return RedirectToAction("Index", "Home");
        }
    }
}