using Domain.Models;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Services;

public interface ICustomerService
{
    Task<List<Customer>?> GetAll();
}

public class ApiCustomerService : ICustomerService
{
    private readonly HttpClient _http;

    public ApiCustomerService(HttpClient http)
    {
        _http = http;
    }

    public Task<List<Customer>?> GetAll()
    {
        return _http.GetFromJsonAsync<List<Customer>>("/api/customers");
    }
}
