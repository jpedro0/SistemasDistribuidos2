namespace Loja.Models
{
    public class ItensDoPedido
    {
        public ItensDoPedido(int produtoId, int quantidade)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
        }

        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int Quantidade { get; set; }
        public string Descricao { get; set; }
    }
}