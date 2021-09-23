using CasaDoCodigo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Repositorys;
using CasaDoCodigo.Models.Responses;
using CasaDoCodigo.Models.Entities;

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
    }
}
