namespace DependencyInjection.Services;

public class ExampleScopedService :IExampleScopedService
{
    private readonly Guid Id;

    public ExampleScopedService()
    {
        Id = Guid.NewGuid();
    }
    public string GetGuid()
    {
        return Id.ToString();
    }
}