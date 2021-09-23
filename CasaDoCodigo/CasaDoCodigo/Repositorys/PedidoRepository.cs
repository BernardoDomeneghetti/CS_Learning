using CasaDoCodigo.Models.Entities;
using Microsoft.AspNetCore.Http;
using CasaDoCodigo.Models.Responses;

namespace CasaDoCodigo.Repositorys
{
    public class PedidoRepository :BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor _acessor;
        public PedidoRepository(ApplicationContext dbContext, IHttpContextAccessor acessor) : base(dbContext)
        {
            _acessor = acessor;
        }

    }
}
