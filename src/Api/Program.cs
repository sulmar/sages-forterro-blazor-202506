using Api.Extensions;
using Bogus;
using Domain.Abstractions;
using Domain.Models;
using Infrastructure.Fakers;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddFakeEntities<Customer, CustomerFaker>(20);
builder.Services.AddSingleton<ICustomerRepository, InMemoryCustomerRepository>();

builder.Services.AddFakeEntities<Product, ProductFaker>(10);
builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();

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
app.MapGet("api/customers/{id}", async (ICustomerRepository repository, int id) => await repository.GetByIdAsync(id));
app.MapGet("api/products", async (IProductRepository repository) => await repository.GetAllAsync());

app.Run();

