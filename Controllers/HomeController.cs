using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace codingskills.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create(string languageName)
    {
      var model = new codingskills.Models.Language();
      model.Name = languageName;
      return View("Index",model);
    }
  }
}
