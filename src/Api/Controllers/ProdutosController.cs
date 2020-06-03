using Api.Daos;
using Api.Models;
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

        // GET: api/Produtos/5
        public async Task<IHttpActionResult> Get(int id)
        {
            var produto = await new ProdutosDao().Buscar(id);

            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        // POST: api/Produtos
        public async Task<IHttpActionResult> Post([FromBody]Produto produto)
        {
            try
            {
                await new ProdutosDao().Salvar(produto);
                return Ok(new { mensagem = "Produto cadastrado com Sucesso" });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // PUT: api/Produtos/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] Produto produto)
        {
            try
            {
                if (id != produto.Id)
                {
                    return NotFound();
                }

                await new ProdutosDao().Alterar(produto);
                return Ok(new { mensagem = "Produto alterado com sucesso!" });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/Produtos/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                await new ProdutosDao().Remover(id);
                return Ok(new { message = "Produto removido com sucesso" });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}