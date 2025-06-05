using Domain.Abstractions;
using Domain.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Pages.Customers;


public partial class List(HttpClient http) // Primary Constructor
{
    private string message = "Hello Customers!";

    private List<Customer>? customers;

   // [Inject] // Atrybut pozwalający na wstrzykiwanie zależności
   // private readonly HttpClient http { get; set; } // Property

    protected override async Task OnInitializedAsync()
    {        
        customers = await http.GetFromJsonAsync<List<Customer>>("https://localhost:7162/api/customers");
    }

    
}


