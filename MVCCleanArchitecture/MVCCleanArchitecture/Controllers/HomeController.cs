using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCCleanArchitecture.Application.Interfaces;
using MVCCleanArchitecture.Domain.Interfaces.Services;
using MVCCleanArchitecture.Models;

namespace MVCCleanArchitecture.Controllers
{
    public class HomeController(ILogger<HomeController> logger,
                                IDataItemService dataItemService) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly IDataItemService _dataItemService = dataItemService;

        public async Task<IActionResult> Index()
        {
            var data = await _dataItemService.GetDataItemsAsync();
            return View(data);
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
