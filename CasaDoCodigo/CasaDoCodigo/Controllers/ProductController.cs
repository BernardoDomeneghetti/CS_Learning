using CasaDoCodigo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Controllers
{
    public class ProductController: Controller
    {
        private readonly IProductService _productService;
        public ProductController(ProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult ProductsList()
        {
            var response = _productService.ListProducts();  
            return View(response.Products);
        }
    }
}
