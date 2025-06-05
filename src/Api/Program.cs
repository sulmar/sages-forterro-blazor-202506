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

builder.Services.AddSingleton<Faker<Product>, ProductFaker>();
builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();
builder.Services.AddSingleton<IEnumerable<Product>>(sp => sp.GetRequiredService<Faker<Product>>().Generate(20));

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
{
    policy.WithOrigins("https://localhost:7291", "http://localhost:5076").WithMethods("GET").AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors();

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello Api!");
app.MapGet("api/customers", async (ICustomerRepository repository) => await repository.GetAllAsync());
app.MapGet("api/products", async (IProductRepository repository) => await repository.GetAllAsync());

app.Run();

