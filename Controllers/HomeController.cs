using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_smn_roberto.Controllers;

public class HomeController : Controller
{
      public IActionResult Index()
    {
        return View();
    }

   
}
