namespace BlazorWebAssemblyApp.Services;

public interface IEntityService<T>
{
    Task<List<T>> GetAll();
    Task<T?> Get(int id);
}
