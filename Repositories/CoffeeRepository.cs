using MinimalApp.Models;

namespace MinimalApp.Repositories
{
    public static class CoffeeRepository
    {
        public static List<CoffeeModel> Coffees = new()
        {
            new() { Id = 1, Name = "Affogato", Description = "Espresso poured on a vanilla ice cream" },
            new() { Id = 2, Name = "Americano", Description = "Espresso with added hot water" },
            new() { Id = 3, Name = "Latte", Description = "A tall, mild 'milk coffee'. An espresso with steamed milk and only a little milk foam poured over it" },
            new() { Id = 4, Name = "Mocha", Description = "A caffe latte with chocolate and whipped cream, made by pouring about 2 cl of chocolate sauce into the glass, followed by an espresso shot and steamed milk." },
            new() { Id = 5, Name = "Cappuccino", Description = "A coffee drink consisting of espresso and a milk foam mixture" }
        };
    }
}
