using Api.Daos;
using Api.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class PedidosController :  ApiController
    {
        // POST: Pedido
        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] Pedido pedido)
        {
            try
            {
                await new PedidosDao().Salvar(pedido);
                return Ok(new { mensagem = "Pedido salvo com sucesso!" });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}