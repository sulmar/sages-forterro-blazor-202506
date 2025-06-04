using Domain.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Pages.Customers;

public partial class List
{
    private string message = "Hello Customers!";

    private List<Customer>? customers;

    [Inject] // Atrybut pozwalający na wstrzykiwanie zależności
    private HttpClient http { get; set; } // Property

    protected override async Task OnInitializedAsync()
    {
        customers = await http.GetFromJsonAsync<List<Customer>>("https://localhost:7162/api/customers");
    }
}


