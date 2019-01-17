using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondWebAppHomework.Models;
using SecondWebAppHomework.Services;

namespace SecondWebAppHomework.Controllers
{
    public class CatsController : Controller
    {
        private CatRepository catRepository;

        public CatsController()
        {
            catRepository = CatRepository.Instance;
        }

        // GET: /Cats/List
        public IActionResult List()
        {
            return View(catRepository.GetCats());
        }

        // Get: /Cats/Edit?id
        [HttpGet]  // Atribut
        public IActionResult Edit(int id)
        {
            Cat catToEdit = catRepository.GetCats().Find(x => x.Id == id);


            return View(catToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Cat model)
        {
            if (ModelState.IsValid)
            {
                var myCat = catRepository.GetCats().Find(x => x.Id == model.Id);
                TryUpdateModelAsync(myCat);

                return RedirectToAction("List");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Cat());
        }

        [HttpPost]
        public IActionResult Create(Cat model)
        {
            if (ModelState.IsValid)
            {
                var maxId = catRepository.GetCats().Max(x => x.Id) + 1;
                model.Id = maxId;
                catRepository.AddCat(model);

                return RedirectToAction("List");
            }
            return View(model);
            
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {

            Cat catToDelete = catRepository.GetCats().Find(x => x.Id == id);

            catRepository.RemoveCat(catToDelete);

            //return RedirectToAction("List");

            return View("List");

        }


    }

}