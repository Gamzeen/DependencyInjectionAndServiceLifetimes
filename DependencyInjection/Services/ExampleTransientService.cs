namespace DependencyInjection.Services;

public class ExampleTransientService :IExampleTransientService
{
    private readonly Guid Id;

    public ExampleTransientService()
    {
        Id = Guid.NewGuid();
    }
    public string GetGuid()
    {
        return Id.ToString();
    }
}