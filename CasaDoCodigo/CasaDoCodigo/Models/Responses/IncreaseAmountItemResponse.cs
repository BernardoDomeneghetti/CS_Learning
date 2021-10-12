using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Responses
{
    public class IncreaseAmountItemResponse : BaseResponse
    {
        public ItemPedido Item { get; set; }
        public IncreaseAmountItemResponse(bool success, string message, ItemPedido item) : base(success, message)
        {
            Item = item;
        }
    }
}
