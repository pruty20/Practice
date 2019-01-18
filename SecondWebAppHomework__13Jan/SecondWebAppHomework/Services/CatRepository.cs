using SecondWebAppHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebAppHomework.Services
{
    public class CatRepository
    {
        static List<Cat> cats = new List<Cat>();
        private static CatRepository instance;

        public CatRepository()
        {

        }

        public static CatRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CatRepository();
                    cats = InitializeList();
                }
                return instance;
            }
        }

        private static List<Cat> InitializeList()
        {
            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat()
            {
                Id = 1,
                Age = 30,
                FirstName = "Cathy",
                LastName = "Missy",
                NickName = "Pisi",
                EmailAddress = "gigi@emai.com",
                FullName = "Marcel Popa"
            });

            cats.Add(new Cat()
            {
                Id = 2,
                Age = 22,
                FirstName = "Lilly",
                LastName = "Caty",
                NickName = "Chisi",
                EmailAddress = "vasf@gemai.com",
                FullName = "Adelin Porcusor"
            });

            cats.Add(new Cat()
            {
                Id = 3,
                Age = 9,
                FirstName = "Mimi",
                LastName = "Vivi",
                EmailAddress = "costuluta@emai.com",
                FullName = "Michel Dragnea"
            });

            return cats;
        }

        public List<Cat> GetCats()
        {
            return cats;
        }

        public void AddCat(Cat catToAdd)
        {
            cats.Add(catToAdd);
        }

        public void RemoveCat(Cat catToRemove)
        {
            cats.Remove(catToRemove);
        }

    }
}
