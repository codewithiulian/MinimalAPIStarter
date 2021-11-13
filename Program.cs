using Microsoft.AspNetCore.Mvc;
using MinimalApp.Models;
using MinimalApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ICoffeeService, CoffeeService>();

var app = builder.Build();

app.MapPost("/create",
    (CoffeeModel coffee, ICoffeeService service) =>
    {
        var result = service.Create(coffee);
        return Results.Ok(result);
    });

app.MapGet("/get",
    (int id, ICoffeeService service) =>
    {
        var coffee = service.Get(id);

        if (coffee is null) return Results.NotFound("Coffee not found");

        return Results.Ok(coffee);
    });

app.MapGet("/list",
    (ICoffeeService service) =>
    {
        var coffees = service.List();

        return Results.Ok(coffees);
    });

app.MapPut("/update",
    (CoffeeModel newCoffee, ICoffeeService service) =>
    {
        var updatedCoffee = service.Update(newCoffee);

        if (updatedCoffee is null) Results.NotFound("Coffee not found");

        return Results.Ok(updatedCoffee);
    });

app.MapDelete("/delete",
    (int id, ICoffeeService service) =>
    {
        var result = service.Delete(id);

        if (!result) Results.BadRequest("Something went wrong");

        return Results.Ok(result);
    });

app.Run();
