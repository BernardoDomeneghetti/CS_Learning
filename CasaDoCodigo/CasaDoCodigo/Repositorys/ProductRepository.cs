using CasaDoCodigo.Models.Entities;
using CasaDoCodigo.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorys
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }

        public ProductJsonImportResponse ImportProductsJson(List<Produto> produtos)
        {
            try
            {
                foreach (var produto in produtos)
                {
                    _dbContext.Set<Produto>().Add(new Produto(produto.Codigo, produto.Nome, produto.Preco));
                }
                _dbContext.SaveChanges();

                return new ProductJsonImportResponse(true, "Produtos inseridos no banco de dados com sucesso!", produtos);
            }
            catch (Exception e)
            {
                return new ProductJsonImportResponse(false, $"ERROR: Products inserting failed: {e.Message}", null);
            }
        }

        public ProductListResponse ListProducts()
        {
            try
            {
                var produtos = new List<Produto>();
                produtos = _dbContext.Set<Produto>().ToList();
                return new ProductListResponse(true, "Produtos listados com sucesso!", produtos);
            }catch(Exception e)
            {
                return new ProductListResponse(false, $"ERRO: Products listing failed: {e.Message}", null);
            }
        }
    }
}
