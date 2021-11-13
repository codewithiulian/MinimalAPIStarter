using MinimalApp.Models;

namespace MinimalApp.Services
{
    public interface ICoffeeService
    {
        public CoffeeModel Create(CoffeeModel coffee);
        public CoffeeModel? Get(int id);
        public List<CoffeeModel> List();
        public CoffeeModel? Update(CoffeeModel coffee);
        public bool Delete(int id);
    }
}
