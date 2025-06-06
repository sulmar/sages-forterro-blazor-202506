using BlazorWebAssemblyApp.Services;
using Domain.Models;

namespace BlazorWebAssemblyApp.Pages.Customers;


public partial class List(ICustomerService Api, IStorageService storageService) // Primary Constructor
{
    private string message = "Hello Customers!";

    private List<Customer>? customers;

    private bool isLoading => customers is null;

    // [Inject] // Atrybut pozwalający na wstrzykiwanie zależności
    // private readonly ICustomerService Api { get; set; } // Property

    protected override async Task OnInitializedAsync()
    {        
        customers = await Api.GetAll();

        var theme = await storageService.Get("theme");

        isChecked = theme == "dark";
    }

    
}


