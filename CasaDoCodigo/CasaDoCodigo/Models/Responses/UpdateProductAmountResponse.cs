using CasaDoCodigo.Models.Entities;
using System.Collections.Generic;

namespace CasaDoCodigo.Models.Responses
{
    public class UpdateProductAmountResponse : BaseResponse
    {
        public Pedido Pedido { get;}
        public List<ItemPedido> Items { get;}
        public UpdateProductAmountResponse(bool success, string message, Pedido pedido, List<ItemPedido> items) : base(success, message)
        {
            Pedido = pedido;
            Items = items;
        }
    }
}
