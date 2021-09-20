using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Responses
{
    public class ProductListResponse:BaseResponse
    {
        public List<Produto> Products { get; private set; }
        public ProductListResponse(bool success, string message, List<Produto> products) : base(success, message)
        {
            Products = products;
        }
    }
}
