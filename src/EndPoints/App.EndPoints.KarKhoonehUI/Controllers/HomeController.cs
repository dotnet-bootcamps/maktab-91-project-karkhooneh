using App.EndPoints.KarKhoonehUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using App.Domain.Core.AppServices.Customers.Commands;

namespace App.EndPoints.KarKhoonehUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAddOrderAppService _addOrderAppService;

        public HomeController(ILogger<HomeController> logger,
            IAddOrderAppService addOrderAppService)
        {
            _logger = logger;
            _addOrderAppService = addOrderAppService;
        }

        public IActionResult Index()
        {
            return View();
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