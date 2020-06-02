using Api.Daos;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class ProdutosController : ApiController
    {
        // GET: Produtos
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var produtos = await new ProdutosDao().Listar();
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}