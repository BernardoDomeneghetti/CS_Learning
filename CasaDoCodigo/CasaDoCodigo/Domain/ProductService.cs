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
    public class ProductService: IProductService
    {
        private IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public RepositoryImportResponse<Produto> ProductJsonImport(string jsonString)
        {
            var produtos = JsonConvert.DeserializeObject<List<Produto>>(jsonString);
            return _repository.ImportDataFromList(produtos);
        }

        public RepositoryListResponse<Produto> ListProducts()
        {
            return _repository.ListDataFromEntity();
        }
    }
}
