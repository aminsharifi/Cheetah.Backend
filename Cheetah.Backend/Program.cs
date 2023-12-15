using Cheetah.Backend.Entity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<Context>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
