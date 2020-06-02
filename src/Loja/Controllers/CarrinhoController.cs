using Loja.Daos;
using Loja.Services;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Loja.Controllers
{
    public class CarrinhoController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var produtos = await new ProdutosDao().ListarProdutos();
            var produtosDoCarrinho = produtos.Where(x => CarrinhoService.ObterIds().Contains(x.Id));
            return View(produtosDoCarrinho);
        }

        [HttpPost]
        public ActionResult Adicionar(int id, int quantidade)
        {
            CarrinhoService.Adicionar(id, quantidade);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Remover(int id)
        {
            CarrinhoService.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}