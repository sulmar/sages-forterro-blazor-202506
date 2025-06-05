using BlazorWebAssemblyApp;
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

await builder.Build().RunAsync();
