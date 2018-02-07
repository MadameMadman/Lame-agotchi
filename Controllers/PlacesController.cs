using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
    public class PlacesController : Controller
    {

        [HttpGet("/places")]
        public ActionResult Index()
        {
          List<Place> model = Place.GetAll();
            return View(model);
        }

        [HttpGet("places/new")]
        public ActionResult Form()
        {
          return View();
        }

        [HttpPost("/places")]
        public ActionResult Create()
        {
          Place newPlace = new Place(
          Request.Form["placeName"],
          Request.Form["placeDescript"]);

          List<Place> model = Place.GetAll();
          return View("Index", model);
        }

        [HttpGet("/places/{id}")]
        public ActionResult Details(int id)
        {
          Place place = Place.Find(id);
          return View(place);
        }
    }
}
