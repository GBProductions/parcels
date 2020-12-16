using Microsoft.AspNetCore.Mvc;
using Shipping.Models;

namespace Shipping.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          double heigth=2.5;
          double length=3.5;
          double width=4.5;
          double weight=5;
          Parcel newParcel= new Parcel(heigth, length, width, weight);
          double volume = Parcel.Volume(heigth, length, width);
          return View(volume);

        }
    }
}