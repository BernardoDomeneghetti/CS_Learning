using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models.Entities;
using CasaDoCodigo.Models.Responses;

namespace CasaDoCodigo.Repositorys
{
    public interface IItemPedidoRepository: IBaseRepository<ItemPedido>
    {
        GetItemByPedidoAndProductResponse GetItemByPedidoAndProduct(int pedidoId, int productId);
        IncreaseAmountItemResponse IncreaseAmount(ItemPedido item, int amount);
        IncreaseAmountItemResponse IncreaseOne(ItemPedido item);
    }
}
