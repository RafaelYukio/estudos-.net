using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCCleanArchitecture.Application.Interfaces;
using MVCCleanArchitecture.Models;

namespace MVCCleanArchitecture.Controllers
{
    public class HomeController(ILogger<HomeController> logger,
                                IDataItemService dataItemService) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly IDataItemService _dataItemService = dataItemService;

        public async Task<IActionResult> Index(string searchTerm)
        {
            if (searchTerm != null )
            {
                var data = await _dataItemService.GetDataItemByTransacaoIdAsync(Convert.ToInt32(searchTerm));

                ViewBag.SearchTerm = searchTerm;  // Envia o termo de busca para a view
                return View(data);   // Retorna a lista de produtos filtrados para a view
            }

            return View();   // Retorna a lista de produtos filtrados para a view
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
