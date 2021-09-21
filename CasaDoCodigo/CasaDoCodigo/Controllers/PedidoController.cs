using CasaDoCodigo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        //--------------------------------------CORRIGIR

        private readonly IProductService _productService;
        public PedidoController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult ProductsList()
        {
            var response = _productService.ListProducts();
            return View(response.Products);
        }

        //--------------------------------------CORRIGIR


        public IActionResult Carrinho(int codigo)
        {
            var teste = codigo;
            return View();
        }

        public IActionResult Carrossel ()
        {
            var response = _productService.ListProducts();
            return View(response.Products);
        }

        public IActionResult Resumo()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
