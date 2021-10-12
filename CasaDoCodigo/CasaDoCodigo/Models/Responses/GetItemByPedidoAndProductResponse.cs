using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Responses
{
    public class GetItemByPedidoAndProductResponse : BaseResponse
    {
        public ItemPedido Item { get; set; }
        public GetItemByPedidoAndProductResponse(bool success, string message, ItemPedido item) : base(success, message)
        {
            Item = item;
        }
    }
}
