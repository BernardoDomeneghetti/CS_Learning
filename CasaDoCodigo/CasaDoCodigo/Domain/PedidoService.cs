using CasaDoCodigo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Repositorys;
using CasaDoCodigo.Models.Responses;
using CasaDoCodigo.Models.Entities;
using CasaDoCodigo.Models.Exceptions;
using Microsoft.AspNetCore.Http;

namespace CasaDoCodigo.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IItemPedidoRepository _itemPedidoRepository;
        private readonly IProductRepository _productRepository;
        private readonly IHttpContextAccessor _accessor;

        public PedidoService(IPedidoRepository repository, IHttpContextAccessor accessor)
        {
            _pedidoRepository = repository;
            _accessor = accessor;
        }

        public RepositoryImportResponse<Pedido> PedidoJsonImport(string jsonString)
        {
            var pedidos = JsonConvert.DeserializeObject<List<Pedido>>(jsonString);
            return _pedidoRepository.ImportDataFromList(pedidos);
        }

        public RepositoryListResponse<Pedido> ListProducts()
        {
            return _pedidoRepository.ListDataFromEntity();
        }

        public int GetIdPedidoFromSession()
        {
            return _accessor.HttpContext.Session.GetInt32("PedidoId")??
                        RegisterPedidoInSession(GetNewPedidoInstance().Instance);
        }

        public int RegisterPedidoInSession(Pedido pedido)
        {
            _accessor.HttpContext.Session.SetInt32("PedidoId", pedido.Id);
            return pedido.Id;
        }

        public RepositoryGetInstanceByID<Pedido> GetPedidoById(int IdPedido)
        {
            try
            {
                return _pedidoRepository.GetInstanceById(IdPedido);
            }
            catch (DbObjectInstanceNotFoundException e)
            {
                return new RepositoryGetInstanceByID<Pedido>(false, $"ERRO: Falha ao buscar o pedido: {e.Message}", null);
            }
        }

        public RepositorySetInstance<Pedido> GetNewPedidoInstance()
        {
            try
            {
                var newInstance = _pedidoRepository.InsertNewInstance(new Pedido());
                if (newInstance.Success)
                    return new RepositorySetInstance<Pedido>(true, "Uma nova instância de pedido foi inserida", newInstance.Instance);

                return new RepositorySetInstance<Pedido>(false, "Não foi possível criar o pedido!", null);

            }
            catch (DbObjectInstanceNotFoundException e)
            {
                return new RepositorySetInstance<Pedido>(false, $"ERRO: Falha ao buscar o pedido: {e.Message}", null);
            }
        }

        public AddProductToCartResponse AddProductToPedido(int pedidoId, int productId)
        {
            try
            {
                var item = _itemPedidoRepository.GetItemByPedidoAndProduct(pedidoId, productId).Item;
                var pedido = _pedidoRepository.GetInstanceById(pedidoId).Instance;

                if (item != null)
                {
                    _itemPedidoRepository.IncreaseAmount(item);
                }
                else
                {
                    var product = _productRepository.GetInstanceById(productId).Instance;
                    item = _itemPedidoRepository.InsertNewInstance(new ItemPedido(pedido, product, 1, product.Preco)).Instance;
                }
                return new
                    AddProductToCartResponse(
                        true,
                        "Item added to Cart successfully!",
                        pedido,
                        new List<ItemPedido> { item }
                    );
            }
            catch(Exception e)
            {
                return new
                    AddProductToCartResponse(
                        false,
                        $"ERROR: Failed while trying to insert a new item to the cart" +
                            $"EXECEPTION TYPE: {e.GetType()}" +
                            $"EXCEPTION MESSAGE: {e.Message}",
                        null,
                        null
                    );
            }
        }
    }
}
