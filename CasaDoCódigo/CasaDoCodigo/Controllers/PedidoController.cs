﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Carrossel ()
        {
            return View();
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
