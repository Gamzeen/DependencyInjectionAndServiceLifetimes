using System.Text;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers;

[ApiController]
[Route("lifetimes")]
public class LifetimeExampleController : ControllerBase
{
    private readonly IExampleSingletonService _exampleSingletonService1;
    private readonly IExampleSingletonService _exampleSingletonService2;

    private readonly IExampleScopedService _exampleScopedService1;
    private readonly IExampleScopedService _exampleScopedService2;

    private readonly IExampleTransientService _exampleTransientService1;
    private readonly IExampleTransientService _exampleTransientService2;
    
    public LifetimeExampleController(IExampleSingletonService exampleSingletonService1,
        IExampleSingletonService exampleSingletonService2,IExampleScopedService exampleScopedService1,
        IExampleScopedService exampleScopedService2, IExampleTransientService exampleTransientService1,
        IExampleTransientService exampleTransientService2)
    {
        _exampleSingletonService1 = exampleSingletonService1;
        _exampleSingletonService2 = exampleSingletonService2;
        _exampleScopedService1 = exampleScopedService1;
        _exampleScopedService2 = exampleScopedService2;
        _exampleTransientService1 = exampleTransientService1;
        _exampleTransientService2 = exampleTransientService2;
    }
    
   [HttpGet]
    public async Task<IActionResult> Get()
    {
        var singletonGuid1 = _exampleSingletonService1.GetGuid();
        var singletonGuid2 = _exampleSingletonService2.GetGuid();

        var scopedGuid1 = _exampleScopedService1.GetGuid();
        var scopedGuid2 = _exampleScopedService2.GetGuid();

        var transientGuid1 = _exampleTransientService1.GetGuid();
        var transientGuid2 = _exampleTransientService2.GetGuid();

        var messages = new StringBuilder();
        messages.Append($"Singleton 1: {singletonGuid1}\n");
        messages.Append($"Singleton 2: {singletonGuid2}\n");

        messages.Append($"Scoped 1: {scopedGuid1}\n");
        messages.Append($"Scoped 2: {scopedGuid2}\n");

        messages.Append($"Transient 1: {transientGuid1}\n");
        messages.Append($"Transient 2: {transientGuid2}\n\n");

        return Ok(messages.ToString());
    }
}