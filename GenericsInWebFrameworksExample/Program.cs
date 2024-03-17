//The File Name is Program.cs
using GenericsInWebFrameworksExample.Controllers;
using GenericsInWebFrameworksExample;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Example usage of generics in web frameworks
var routeHandler = new Route<HomeController>();

// Define routes
routeHandler.AddRoute("/", HomeController.Index);
routeHandler.AddRoute("/about", HomeController.About);
routeHandler.AddRoute("/contact", HomeController.Contact);

// Simulate incoming requests
Extended.SimulateRequest(routeHandler, "/");
Extended.SimulateRequest(routeHandler, "/about");
Extended.SimulateRequest(routeHandler, "/contact");
Extended.SimulateRequest(routeHandler, "/nonexistent");

Console.ReadLine();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

