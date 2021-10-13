using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CasaDoCodigo.Models.Responses
{
    public class ProductJsonImportResponse : BaseResponse
    {
        public List<Produto> ImportedProducts { get; private set; }
        public ProductJsonImportResponse(bool success, string message, List<Produto> importedProducts) : base(success, message)
        {
            ImportedProducts = importedProducts;
        }
    }
}
