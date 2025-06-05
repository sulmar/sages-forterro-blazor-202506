using Domain.Models;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Services;

public class ApiCustomerService(HttpClient http) : ICustomerService
{
    public Task<Customer?> Get(int id) => http.GetFromJsonAsync<Customer>($"api/customers/{id}");
    public Task<List<Customer>?> GetAll() => http.GetFromJsonAsync<List<Customer>>("api/customers");
}
