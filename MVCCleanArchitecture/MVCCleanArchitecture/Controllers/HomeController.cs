using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCCleanArchitecture.Domain.Interfaces.Services.Base;
using MVCCleanArchitecture.Models;

namespace MVCCleanArchitecture.Controllers
{
    public class HomeController(ILogger<HomeController> logger,
                                ITransacaoService transacaoService) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly ITransacaoService _transacaoService = transacaoService;

        public async Task<IActionResult> Index()
        {
            var transactions = await _transacaoService.GetAllAsync();
            return View(transactions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
