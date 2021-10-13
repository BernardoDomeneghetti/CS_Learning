using CasaDoCodigo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class ProductController: Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult Carrossel()
        {
            var response = _productService.ListProducts();
            return View(response.Items);
        }
    }
}
