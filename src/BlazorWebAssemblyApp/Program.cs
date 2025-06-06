using BlazorWebAssemblyApp;
using BlazorWebAssemblyApp.Models;
using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// dotnet add package Microsoft.Extensions.Http
// Typed HttpClient (Typowany klient http)
builder.Services.AddHttpClient<ICustomerService, ApiCustomerService>(http => http.BaseAddress = new Uri("https://localhost:7162"));
builder.Services.AddHttpClient<IProductService, ApiProductService>(http => http.BaseAddress = new Uri("https://localhost:7162"));



builder.Services.AddCascadingValue<ApplicationContext>(sp => new ApplicationContext { Count = 10, Mode = true });
builder.Services.AddCascadingValue<string>("lvl", sp => "a");


builder.Services.AddScoped<IStorageService, LocalStorageService>();

await builder.Build().RunAsync();
