var app = WebApplication.Create(args);

app.MapGet("/swagger", () => "Hello World!");

app.Run();