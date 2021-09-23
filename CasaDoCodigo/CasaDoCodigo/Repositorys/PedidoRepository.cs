using CasaDoCodigo.Models.Entities;
using Microsoft.AspNetCore.Http;

namespace CasaDoCodigo.Repositorys
{
    public class PedidoRepository :BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor _acessor;
        public PedidoRepository(ApplicationContext dbContext, IHttpContextAccessor acessor) : base(dbContext)
        {
            _acessor = acessor;
        }

        public int GetPedidoId()
        {
            return (int)_acessor.HttpContext.Session.GetInt32("pedidoId");            
        }
        public void SetPedidoId(int pedidoId)
        {
            _acessor.HttpContext.Session.SetInt32("pedidoId",pedidoId);
        }
    }
}
