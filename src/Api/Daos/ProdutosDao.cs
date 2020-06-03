using Api.Contextos;
using Api.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace Api.Daos
{
    public class ProdutosDao
    {
        private readonly ApiContexto contexto;

        public ProdutosDao()
        {
            this.contexto = new ApiContexto();
        }

        public async Task<IEnumerable<Produto>> Listar() =>
            await this.contexto.Produtos.ToListAsync();

        public async Task<Produto> Buscar(int id) =>
            await this.contexto.Produtos.FindAsync(id);

        public async Task Salvar(Produto produto)
        {
            this.contexto.Produtos.Add(produto);
            await this.contexto.SaveChangesAsync();
        }

        public async Task Remover(int id)
        {
            var produto = await this.Buscar(id);
            this.contexto.Produtos.Remove(produto);
            await this.contexto.SaveChangesAsync();
        }

        public async Task Alterar(Produto produto)
        {
            this.contexto.Produtos.AddOrUpdate(produto);
            await this.contexto.SaveChangesAsync();
        }
    }
}