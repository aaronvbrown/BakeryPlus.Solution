using Microsoft.AspNetCore.Mvc;
using BakeryPlus.Models;
using System.Collections.Generic;
using System.Linq;

namespace BakeryPlus.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryPlusContext _db;

    public HomeController(BakeryPlusContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Treat[] treats = _db.Treats.ToArray();
      Flavor[] flavors = _db.Flavors.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("treats", treats);
      model.Add("flavors", flavors);
      return View(model);
    }
  }
}