namespace DependencyInjection.Services;

public class ExampleSingletonService : IExampleSingletonService
{
    private readonly Guid Id;

    public ExampleSingletonService()
    {
        Id = Guid.NewGuid();
    }
    public string GetGuid()
    {
        return Id.ToString();
    }
}