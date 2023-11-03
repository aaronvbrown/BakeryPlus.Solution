using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BakeryPlus.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BakeryPlus.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly BakeryPlusContext _db;

    public FlavorsController(BakeryPlusContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      if (!ModelState.IsValid)
      {
        return View(flavor);
      }
      else
      {
        _db.Flavors.Add(flavor);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }
    // public ActionResult Details (int id)
    // {
    //   Flavor thisFlavor = _db.Flavors
    //                           .Include(flavor => flavor.JoinEntities)
    //                           .ThenInclude(join => join.Treat)
    //                           .FirstOrDefault(flavor => flavor.FlavorId == id);
    // }
  }
}