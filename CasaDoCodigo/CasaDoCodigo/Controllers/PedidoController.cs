using CasaDoCodigo.Models.Responses;
using CasaDoCodigo.Models.Requests;
using CasaDoCodigo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models.ViewModels;

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
        public JsonResult UpdateProductAmount(UpdateProductAmountRequest request)
        {
            request.PedidoId = _pedidoService.GetIdPedidoFromSession();
            var response = _pedidoService.UpdateProductAmount(request);
            
            return Json(response);
        }

        [HttpPost]
        public JsonResult IncreaseProductAmount(UpdateProductAmountRequest request)
        {
            request.PedidoId = _pedidoService.GetIdPedidoFromSession();
            var response = _pedidoService.IncreaseProductAmount(request);

            return Json( new { success = true });
        }

        [HttpPost]
        public JsonResult DecreaseProductAmount(UpdateProductAmountRequest request)
        {
            request.PedidoId = _pedidoService.GetIdPedidoFromSession();
            var response = _pedidoService.DecreaseProductAmount(request);

            return Json(new { success = true});
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
