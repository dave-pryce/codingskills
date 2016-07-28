using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hwapp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var name = "Dot Net";
      return View("Index", name);
    }
  }
}
