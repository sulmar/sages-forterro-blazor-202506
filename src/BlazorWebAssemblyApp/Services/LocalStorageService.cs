using BlazorWebAssemblyApp.Pages;
using Microsoft.JSInterop;

namespace BlazorWebAssemblyApp.Services;

public class LocalStorageService(IJSRuntime JS) : IStorageService
{   
    public async Task Set(string key, string value)
    {
        await JS.InvokeVoidAsync("localStorage.setItem", key, value);
    }

    public async Task<string> Get(string key)
    {
        return await JS.InvokeAsync<string>("localStorage.getItem", key);
    }

}
