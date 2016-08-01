using Microsoft.AspNetCore.Mvc;
using codingskills.Models;

namespace codingskills.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
        return View(Language.GetAll());
    }

    public IActionResult Create(string LanguageName)
    {
      Language.Create(LanguageName);
      return RedirectToAction("Index");
    }
  }
}
