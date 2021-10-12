using CasaDoCodigo.Models.Entities;
using Microsoft.AspNetCore.Http;
using CasaDoCodigo.Models.Responses;

namespace CasaDoCodigo.Repositorys
{
    public class PedidoRepository :BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
