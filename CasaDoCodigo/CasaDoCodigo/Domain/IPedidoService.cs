using CasaDoCodigo.Models.Entities;
using CasaDoCodigo.Models.Responses;

namespace CasaDoCodigo.Services
{
    public interface IPedidoService
    {
        int GetIdPedidoFromSession();
        RepositorySetInstance<Pedido> GetNewPedidoInstance();
        RepositoryGetInstanceByID<Pedido> GetPedidoById(int IdPedido);
        RepositoryListResponse<Pedido> ListProducts();
        RepositoryImportResponse<Pedido> PedidoJsonImport(string jsonString);
        int RegisterPedidoInSession(Pedido pedido);
        AddProductToCartResponse UpdateProductAmount(int PedidoId, int productCode, int amount);
    }
}