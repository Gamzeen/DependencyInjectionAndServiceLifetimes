using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IExampleSingletonService,ExampleSingletonService>();
builder.Services.AddScoped<IExampleScopedService,ExampleScopedService>();
builder.Services.AddTransient<IExampleTransientService,ExampleTransientService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();