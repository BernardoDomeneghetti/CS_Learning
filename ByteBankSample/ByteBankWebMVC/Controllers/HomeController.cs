using ByteBankLib.Domain.Service;
using ByteBankWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using ByteBankLib.Factories;
using ByteBankLib.Models.Entities;


namespace ByteBankWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICurrentAccountService _currentAccountService;
        private ICustomerFactory _customerFactory;

        public HomeController(
            ILogger<HomeController> logger,
            ICurrentAccountService currentAccountService,
            ICustomerFactory customerFactory)
        {
            _logger = logger;
            _currentAccountService = currentAccountService;
            _customerFactory = customerFactory;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {

            var AccountCreation = _currentAccountService.RegisterNewAccount(_customerFactory.GetNew("Bernardo", 123, 0, "ATIVO"),100);
            var teste = _currentAccountService.Deposit(AccountCreation.Account.AccountNumber, 10);

            return View(AccountCreation);           
        }

        public IActionResult Teste()
        {
            var AccountCreation = _currentAccountService.RegisterNewAccount(_customerFactory.GetNew("Bernardo", 123, 0, "ATIVO"), 100);
            var teste = _currentAccountService.Deposit(AccountCreation.Account.AccountNumber, 10);
     
            return View(teste);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
