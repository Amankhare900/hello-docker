var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello DOCKER!");


app.MapGet("/hello", () => "Hello World!");


app.Run();