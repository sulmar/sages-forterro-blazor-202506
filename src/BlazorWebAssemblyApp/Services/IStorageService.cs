namespace BlazorWebAssemblyApp.Services;

public interface IStorageService
{
    Task Set(string key, string value);
    Task<string> Get(string key);
}
