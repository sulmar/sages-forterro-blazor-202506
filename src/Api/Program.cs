using Bogus;
using Domain.Abstractions;
using Domain.Models;
using Infrastructure.Fakers;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<Faker<Customer>, CustomerFaker>();
builder.Services.AddSingleton<ICustomerRepository, InMemoryCustomerRepository>();
builder.Services.AddSingleton<IEnumerable<Customer>>(sp =>
{
    var faker = sp.GetRequiredService<Faker<Customer>>();

    var customers = faker.Generate(20);

    return customers;

});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello Api!");
app.MapGet("api/customers", async (ICustomerRepository repository) => await repository.GetAllAsync());

app.Run();

