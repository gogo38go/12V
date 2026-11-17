using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using WebDogApp.Infrastructure.Data;
using WebDogApp.Infrastructure.Data.Domain;

namespace WebDogApp.Core.Services
{
    public class DogService : IDogService
    {
        private readonly ApplicationDbContext _context;

        public DogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Create(string name, int age, int breedId, string picture)
        {
            Dog item = new Dog
            {
                Name = name,
                Age = age,
                Breed = _context.Breeds.Find(breedId),
                Picture = picture,
            };

            _context.Dogs.Add(item);
            return _context.SaveChanges() != 0;
        }

        public Dog GetDogById(int dogId)
        {
            return _context.Dogs
                .Include(d => d.Breed)
                .FirstOrDefault(d => d.Id == dogId);
        }

        public List<Dog> GetDogs()
        {
            List<Dog> dogs = _context.Dogs
                .Include(d => d.Breed)
                .ToList();

            return dogs;
        }

        public List<Dog> GetDogs(string searchStringBreed, string searchStringName)
        {
            var dogs = _context.Dogs
                .Include(d => d.Breed)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchStringBreed))
            {
                dogs = dogs.Where(d =>
                    d.Breed.Name.Contains(searchStringBreed));
            }

            if (!string.IsNullOrEmpty(searchStringName))
            {
                dogs = dogs.Where(d =>
                    d.Name.Contains(searchStringName));
            }

            return dogs.ToList();
        }

        public bool RemoveById(int dogId)
        {
            Dog dog = _context.Dogs.Find(dogId);

            if (dog == null)
            {
                return false;
            }

            _context.Dogs.Remove(dog);

            return _context.SaveChanges() != 0;
        }

        public bool UpdateDog(int dogId, string name, int age, int breedId, string picture)
        {
            Dog dog = _context.Dogs.Find(dogId);

            if (dog == null)
            {
                return false;
            }

            dog.Name = name;
            dog.Age = age;
            dog.Breed = _context.Breeds.Find(breedId);
            dog.Picture = picture;

            _context.Dogs.Update(dog);

            return _context.SaveChanges() != 0;
        }
    }
}