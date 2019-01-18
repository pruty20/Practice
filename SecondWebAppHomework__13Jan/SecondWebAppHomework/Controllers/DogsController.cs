using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondWebAppHomework.Models;
using SecondWebAppHomework.Services;

namespace SecondWebAppHomework.Controllers
{
    public class DogsController : Controller
    {
        private DogRepository dogRepository;

        public DogsController()
        {
            dogRepository = DogRepository.Instance;
        }

        // GET: /Dogs/List
        public IActionResult List()
        {
            return View(dogRepository.GetDogs());
        }

        // Get: /Dogs/Edit?id
        [HttpGet]  // Atribut
        public IActionResult Edit(int id)
        {
            Dog dogToEdit = dogRepository.GetDogs().Find(x => x.Id == id);

            return View(dogToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Dog model)
        {
            if (ModelState.IsValid)
            {
                var myDog = dogRepository.GetDogs().Find(x => x.Id == model.Id);
                TryUpdateModelAsync(myDog);
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Dog());
        }

        [HttpPost]
        public IActionResult Create(Dog model)
        {
            if (ModelState.IsValid)
            {
                var maxId = dogRepository.GetDogs().Max(x => x.Id) + 1;
                model.Id = maxId;
                dogRepository.AddDog(model);

                return RedirectToAction("List");
            }
            return View(model);
            
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Dog dogToDelete = dogRepository.GetDogs().Find(x => x.Id == id);

            dogRepository.RemoveCat(dogToDelete);

            return RedirectToAction("List");

        }


    }

}