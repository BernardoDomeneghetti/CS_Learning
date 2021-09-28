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

namespace CasaDoCodigo.Services
{
    public class PedidoService: IPedidoService
    {
        private IPedidoRepository _repository;

        public PedidoService(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public RepositoryImportResponse<Pedido> PedidoJsonImport(string jsonString)
        {
            var pedidos = JsonConvert.DeserializeObject<List<Pedido>>(jsonString);
            return _repository.ImportDataFromList(pedidos);
        }

        public RepositoryListResponse<Pedido> ListProducts()
        {
            return _repository.ListDataFromEntity();
        }

        public RepositoryGetInstanceByID<Pedido> GetPedido(int IdPedido)
        {
            try
            {
                return _repository.GetInstanceById(IdPedido);
            }
            catch (DbObjectInstanceNotFoundException e)
            {
                try
                {
                    var newInstance = _repository.InsertNewInstance(new Pedido());
                    if (newInstance.Success)
                    {
                        return new RepositoryGetInstanceByID<Pedido>(true, "Uma nova instância de pedido foi inserida", newInstance.Instance);
                    }
                    else
                        throw e;
                }
                catch (DbObjectInstanceNotFoundException)
                {
                    return new RepositoryGetInstanceByID<Pedido>(false, $"ERRO: Falha ao buscar o pedido: {e.Message}", null);
                }
            }
        }
    }
}
