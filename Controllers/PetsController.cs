using Microsoft.AspNetCore.Mvc;
using Pets.Models;
using System.Collections.Generic;

namespace Pets.Controllers
{
    public class PetsController : Controller
    {

        [HttpGet("/pets")]
        public ActionResult Index()
        {
          List<Pet> model = Pet.GetAll();
            return View(model);
        }

        [HttpGet("pets/new")]
        public ActionResult Form()
        {
          return View();
        }

        [HttpPost("/pets")]
        public ActionResult Create()
        {
          Pet newPet = new Pet(
          Request.Form["petName"],
          Request.Form["petDescript"],
          Request.Query["newHunger"]);

          List<Pet> model = Pet.GetAll();
          return View("Index", model);
        }

        [HttpGet("/pets/{id}")]
        public ActionResult Details(int id)
        {
          Pet pet = Pet.Find(id);
          return View(pet);
        }
    }
}
