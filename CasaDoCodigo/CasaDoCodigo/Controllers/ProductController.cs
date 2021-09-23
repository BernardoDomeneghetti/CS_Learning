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
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult Index()
        {            
            return View("Carrossel");
        }

        public IActionResult Carrossel()
        {
            var response = _productService.ListProducts();
            return View(response);
        }
    }
}
