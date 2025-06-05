using Domain.Models;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Services;

public class ApiCustomerService(HttpClient http) : ICustomerService
{
    public Task<List<Customer>?> GetAll() => http.GetFromJsonAsync<List<Customer>>("api/customers");
}
