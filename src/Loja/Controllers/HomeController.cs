using Loja.Daos;
using Loja.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Loja.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var produtos = await new ProdutosDao().ListarProdutos();
            return View(produtos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}