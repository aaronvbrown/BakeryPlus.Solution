using Microsoft.AspNetCore.Mvc;
using BakeryPlus.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace BakeryPlus.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryPlusContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, BakeryPlusContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [HttpGet("/")]
    public async Task<ActionResult> Index()
    {
      // Treats Logic
      Treat[] treats = _db.Treats.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("treats", treats);
      
      // Flavor Logic
      Flavor[] flavors = _db.Flavors.ToArray();
      model.Add("flavors", flavors);
    
      return View(model);
    }
  }
}