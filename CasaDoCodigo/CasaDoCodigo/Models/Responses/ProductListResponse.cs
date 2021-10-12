using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Responses
{
    public class ProductListResponse:BaseResponse
    {
        public List<Product> Products { get; private set; }
        public ProductListResponse(bool success, string message, List<Product> products) : base(success, message)
        {
            Products = products;
        }
    }
}
