using Api.Daos;
using Api.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class PedidosController :  ApiController
    {
        // GET: Pedidos
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var pedidos = await new PedidosDao().Listar();
                return Ok(pedidos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Pedidos/5
        public async Task<IHttpActionResult> Get(int id)
        {
            var pedido = await new PedidosDao().Buscar(id);

            if (pedido == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                pedido.Id,
                pedido.Data,
                itensDoPedido = pedido.ItensDoPedido.Select(x => new
                {
                    x.ProdutoId,
                    x.Quantidade,
                    x.Produto?.Descricao
                }).ToList()
            });
        }

        // POST: Pedidos
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