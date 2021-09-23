using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models.Entities;

namespace CasaDoCodigo.Repositorys
{
    public class ItemPedidoRepository :BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
