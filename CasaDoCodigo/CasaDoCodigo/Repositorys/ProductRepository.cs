using CasaDoCodigo.Models.Entities;
using CasaDoCodigo.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositorys
{
    public class ProductRepository : BaseRepository<Produto>, IProductRepository
    {
        public ProductRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }

        public GetProductByCodeResponse GetProductByCode(int productCode)
        {
            try
            {
                var instance = _dbContext.Set<Produto>().Where(p => p.Codigo == productCode ).SingleOrDefault();
                
                return new GetProductByCodeResponse(true, "Instância capturada com sucesso", instance);
            }
            catch
            {
                return new GetProductByCodeResponse(false, "Falha ao capturar instância", null);
            }

        }
    }
}
