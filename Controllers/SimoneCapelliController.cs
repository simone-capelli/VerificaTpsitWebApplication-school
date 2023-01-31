using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMvcSimoneCapelli.Models;

namespace WebAppMvcSimoneCapelli.Controllers
{
    public class SimoneCapelliController : Controller
    {
        private readonly ILogger<SimoneCapelliController> _logger;

        public SimoneCapelliController(ILogger<SimoneCapelliController> logger)
        {
            _logger = logger;
        }

        public IActionResult SimoneCapelliPage(string name="", string msg="", int numRipetizioni=0)
        {
            try
            {
                ViewData["name"] = name;
                _logger.LogInformation("Questo è un information log");
            }
            catch (Exception ex)
            {
                _logger.LogError("Questo è un errore: " + ex.Message);
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}