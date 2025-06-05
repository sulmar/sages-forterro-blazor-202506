using Domain.Models;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Services;

public class ApiProductService(HttpClient http) : IProductService
{
    public Task<Product?> Get(int id) => http.GetFromJsonAsync<Product>($"api/products/{id}");
    public Task<List<Product>?> GetAll() => http.GetFromJsonAsync<List<Product>>("api/products");
}
