using Microsoft.AspNetCore.Mvc;

namespace Maintenance.Controllers;

public class MaintenanceController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}