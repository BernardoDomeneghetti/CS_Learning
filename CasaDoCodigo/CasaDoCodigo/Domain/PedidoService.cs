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
using CasaDoCodigo.Models.Requests;

namespace CasaDoCodigo.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IItemPedidoRepository _itemPedidoRepository;
        private readonly IProductRepository _productRepository;
        private readonly IHttpContextAccessor _accessor;

        public PedidoService(IPedidoRepository pedidoRepository, IHttpContextAccessor accessor, IItemPedidoRepository itemPedidoRepository, IProductRepository productRepository)
        {
            _pedidoRepository = pedidoRepository;
            _accessor = accessor;
            _itemPedidoRepository = itemPedidoRepository;
            _productRepository = productRepository;
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
            var teste = _accessor.HttpContext.Session.GetInt32("PedidoId");
            if ( teste != null)
                return teste.Value;
            else
                return RegisterPedidoInSession(GetNewPedidoInstance().Instance);
        }

        public int RegisterPedidoInSession(Pedido pedido)
        {
            _accessor.HttpContext.Session.SetInt32("PedidoId", pedido.Id);
            return pedido.Id;
        }

        public RepositoryGetInstanceByID<Pedido> GetPedidoById(int IdPedido)
        {
                return _pedidoRepository.GetPedidoById(IdPedido);
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

        public UpdateProductAmountResponse IncreaseProductAmount(UpdateProductAmountRequest request)
        {
            var product = _productRepository.GetProductByCode(request.ProductCode).Instance;
            var item = _itemPedidoRepository.GetItemByPedidoAndProduct(request.PedidoId, product.Id).Item;

            request.Amount = item.Quantidade--;

            return UpdateProductAmount(request);

        }
        public UpdateProductAmountResponse DecreaseProductAmount(UpdateProductAmountRequest request)
        {
            var product = _productRepository.GetProductByCode(request.ProductCode).Instance;
            var item = _itemPedidoRepository.GetItemByPedidoAndProduct(request.PedidoId, product.Id).Item;

            request.Amount = item.Quantidade--;

            return UpdateProductAmount(request);
        }
        

        public UpdateProductAmountResponse UpdateProductAmount(UpdateProductAmountRequest request)
        {
            try
            {
                var product = _productRepository.GetProductByCode(request.ProductCode).Instance;
                var item = _itemPedidoRepository.GetItemByPedidoAndProduct(request.PedidoId, product.Id).Item;
                var pedido = _pedidoRepository.GetInstanceById(request.PedidoId).Instance;

                if (item != null)
                {

                    item.Quantidade = request.Amount;
                    _itemPedidoRepository.UpdateEntity(item);
                }
                else
                    item = _itemPedidoRepository.InsertNewInstance(new ItemPedido(pedido, product, request.Amount, product.Preco)).Instance;

                return new
                    UpdateProductAmountResponse(
                        true,
                        "Cart item update successfully!",
                        pedido,
                        new List<ItemPedido> { item }
                    );
            }
            catch(Exception e)
            {
                return new
                    UpdateProductAmountResponse(
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
