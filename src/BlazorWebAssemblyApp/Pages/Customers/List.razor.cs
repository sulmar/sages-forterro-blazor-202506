using BlazorWebAssemblyApp.Services;
using Domain.Models;
using Microsoft.JSInterop;

namespace BlazorWebAssemblyApp.Pages.Customers;


public partial class List(ICustomerService Api) // Primary Constructor
{
    private string message = "Hello Customers!";

    private List<Customer>? customers;

    private bool isLoading => customers is null;

    // [Inject] // Atrybut pozwalający na wstrzykiwanie zależności
    // private readonly ICustomerService Api { get; set; } // Property

    protected override async Task OnInitializedAsync()
    {        
        customers = await Api.GetAll();

        var theme = await JS.InvokeAsync<string>("localStorage.getItem", "theme");

        isChecked = theme == "dark";
    }

    
}


