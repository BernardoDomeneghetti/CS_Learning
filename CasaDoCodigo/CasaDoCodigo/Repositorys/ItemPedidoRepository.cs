using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models.Entities;
using CasaDoCodigo.Models.Exceptions;
using CasaDoCodigo.Models.Responses;

namespace CasaDoCodigo.Repositorys
{
    public class ItemPedidoRepository :BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }

        public GetItemByPedidoAndProductResponse GetItemByPedidoAndProduct(int pedidoId, int productCode)
        {
            try
            {
                ItemPedido instance =
                    _dbContext.Set<ItemPedido>()
                        .Where(p => p.Pedido.Id == pedidoId && p.Produto.Id == productCode)
                        .SingleOrDefault();
                
                return new GetItemByPedidoAndProductResponse(true, "Item found successfully", instance);
            }
            catch (Exception e)
            {
                return new
                    GetItemByPedidoAndProductResponse(
                        false,
                        $"ERROR: Failed while trying to search for ItemPedido" +
                            $"EXCEPTION TYPE: {e.GetType()}" +
                            $"EXCEPTION MESSAGE: {e.Message}",
                        null
                    );
            }
        }

        public IncreaseAmountItemResponse IncreaseAmount(ItemPedido item)
        {

            item.Quantidade++;
            try
            {
                ItemPedido instance = _dbContext.Set<ItemPedido>().Update(item).Entity;
                return new IncreaseAmountItemResponse(true, "Item found successfully", instance);
            }
            catch (Exception e)
            {
                return new
                    IncreaseAmountItemResponse(
                        false,
                        $"ERROR: Failed while trying to search for ItemPedido" +
                            $"EXCEPTION TYPE: {e.GetType()}" +
                            $"EXCEPTION MESSAGE: {e.Message}",
                        null
                    );
            }
        }
    }
}
