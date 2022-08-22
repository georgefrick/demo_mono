using Microsoft.AspNetCore.Mvc;

var webApplication = WebApplication.CreateBuilder(args).Build();
webApplication.MapGet("/", () => "Hello World!");
webApplication.MapGet("/echo/{id}", (string id) => $"{id}");
webApplication.MapGet("/echo-body", ([FromBody] string id) => $"{id}");
webApplication.Run();