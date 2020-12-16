using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Parcel newParcel  = new Parcel(length, width, height, weight);
      double volume = newParcel.Volume(); 
      newParcel.Height = height;
      double cost = newParcel.CostToShip(volume);
      return RedirectToAction("Index");
    }
  }
}