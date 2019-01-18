using SecondWebAppHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebAppHomework.Services
{
    public class DogRepository
    {
        static List<Dog> dogs = new List<Dog>();
        private static DogRepository instance;

        public DogRepository()
        {

        }

        public static DogRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DogRepository();
                    dogs = InitializeList();
                }
                return instance;
            }
        }

        private static List<Dog> InitializeList()
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog()
            {
                Id = 1,
                Age = 30,
                FirstName = "Lilly",
                LastName = "Kitten"
            });

            dogs.Add(new Dog()
            {
                Id = 2,
                Age = 9,
                FirstName = "Mimi",
                LastName = "Vivi",
                EmailAddress = "costuluta@emai.com",
                FullName = "Michel Dragnea"
            });

            return dogs;
        }

        public List<Dog> GetDogs()
        {
            return dogs;
        }

        public void AddDog(Dog dogToAdd)
        {
            dogs.Add(dogToAdd);
        }

        public void RemoveCat(Dog dogToRemove)
        {
            dogs.Remove(dogToRemove);
        }

    }
}
