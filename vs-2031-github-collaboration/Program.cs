var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "<h1>Hello World</h1><br>!\nWelcome to my site!");
app.MapGet("/", () => @"Hello World!
Welcome to my site");

app.Run();
