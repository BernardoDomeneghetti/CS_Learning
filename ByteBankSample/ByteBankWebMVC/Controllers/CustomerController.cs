using ByteBankLib.Domain.Service;
using ByteBankWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ByteBankLib.Models.Entities;
using ByteBankLib.Factories;
using ByteBankLib.Models.Enums;

namespace ByteBankWebMVC.Controllers
{
    public class CustomerController: Controller
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegisterNewCustomer([FromQuery]string name, int cpf, int customerLevel, string status)
        {               
            _customerService.RegisterNewCustomer(name, cpf, (CustomerLevelEnum)customerLevel, status );
            
            return View("CustomerRegisterSuccessfulll");
        }
    }
}
