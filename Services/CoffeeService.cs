using MinimalApp.Models;
using MinimalApp.Repositories;

namespace MinimalApp.Services
{
    public class CoffeeService : ICoffeeService
    {
        public CoffeeModel Create(CoffeeModel coffee)
        {
            coffee.Id = CoffeeRepository.Coffees.Count + 1;
            CoffeeRepository.Coffees.Add(coffee);

            return coffee;
        }

        public CoffeeModel? Get(int id)
        {
            var coffee = CoffeeRepository.Coffees.FirstOrDefault(o => o.Id == id);

            if (coffee is null) return null;

            return coffee;
        }

        public List<CoffeeModel> List()
        {
            var coffees = CoffeeRepository.Coffees;

            return coffees;
        }

        public CoffeeModel? Update(CoffeeModel newCoffee)
        {
            var oldCoffee = CoffeeRepository.Coffees.FirstOrDefault(o => o.Id == newCoffee.Id);

            if (oldCoffee is null) return null;

            oldCoffee.Name = newCoffee.Name;
            oldCoffee.Description = newCoffee.Description;

            return newCoffee;
        }

        public bool Delete(int id)
        {
            var oldCoffee = CoffeeRepository.Coffees.FirstOrDefault(o => o.Id == id);

            if (oldCoffee is null) return false;

            CoffeeRepository.Coffees.Remove(oldCoffee);

            return true;
        }
    }
}
