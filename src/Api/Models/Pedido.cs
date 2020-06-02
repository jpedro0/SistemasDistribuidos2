using System;
using System.Collections.Generic;

namespace Api.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public IEnumerable<ItensDoPedido> ItensDoPedido { get; set; }
    }
}