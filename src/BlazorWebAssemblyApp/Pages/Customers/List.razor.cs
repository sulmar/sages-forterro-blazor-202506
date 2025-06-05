using BlazorWebAssemblyApp.Services;
using Domain.Models;

namespace BlazorWebAssemblyApp.Pages.Customers;


public partial class List(ICustomerService Api) // Primary Constructor
{
    private string message = "Hello Customers!";

    private List<Customer>? customers;

    // [Inject] // Atrybut pozwalający na wstrzykiwanie zależności
    // private readonly ICustomerService Api { get; set; } // Property

    protected override async Task OnInitializedAsync()
    {        
        customers = await Api.GetAll();
    }

    
}


