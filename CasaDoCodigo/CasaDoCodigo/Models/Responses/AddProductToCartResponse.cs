using CasaDoCodigo.Models.Entities;
using System.Collections.Generic;

namespace CasaDoCodigo.Models.Responses
{
    public class AddProductToCartResponse : BaseResponse
    {
        public Pedido Pedido { get;}
        public List<ItemPedido> Items { get;}
        public AddProductToCartResponse(bool success, string message, Pedido pedido, List<ItemPedido> items) : base(success, message)
        {
            Pedido = pedido;
            Items = items;
        }
    }
}
