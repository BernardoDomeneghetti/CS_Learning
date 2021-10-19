using CasaDoCodigo.Models.Entities;
using CasaDoCodigo.Models.Responses;

namespace CasaDoCodigo.Repositorys
{
    public interface IPedidoRepository : IBaseRepository<Pedido>
    {
        RepositoryGetInstanceByID<Pedido> GetPedidoById(int idPedido);
    }
}
