using CasaDoCodigo.Models.Responses;
using CasaDoCodigo.Models.Requests;
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
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public IActionResult Cart()
        {
            var pedidoId = _pedidoService.GetIdPedidoFromSession();
            return View("Carrinho", _pedidoService.GetPedidoById(pedidoId).Instance);
        }

        [HttpPost]
        public JsonResult AddProductToCart(AddProductToCartRequest request)
        {
            request.PedidoId = _pedidoService.GetIdPedidoFromSession();
            var response = _pedidoService.AddProductToPedido(request);
            
            return Json(response);
        }

        public IActionResult Resumo()
        {
            var pedidoId = _pedidoService.GetIdPedidoFromSession();
            var pedido = _pedidoService.GetPedidoById(pedidoId);

            return View(pedido);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
