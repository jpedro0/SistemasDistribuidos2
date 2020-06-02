using System.Collections.Generic;
using System.Linq;

namespace Loja.Services
{
    public class CarrinhoService
    {
        private static readonly Dictionary<int, int> Carrinho = new Dictionary<int, int>();

        public static void Adicionar(int id, int quantidade) => Carrinho.Add(id, quantidade);

        public static void Remover(int id) => Carrinho.Remove(id);

        public static IList<int> ObterIds() => Carrinho.Select(x => x.Key).ToList();

        public static Dictionary<int, int> ObterCarrinho() => Carrinho;
    }
}