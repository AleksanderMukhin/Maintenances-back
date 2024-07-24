using Microsoft.AspNetCore.Mvc;

namespace Maintenance.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}