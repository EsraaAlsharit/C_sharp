// Add this using statement
using Microsoft.EntityFrameworkCore;
// You will need access to your models for your context file
using E_Commerce.Models;
// Builder code from before

var builder = WebApplication.CreateBuilder(args);

// Create a variable to hold your connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// All your builder.services go here
// And we will add one more service
// Make sure this is BEFORE var app = builder.Build()!!
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
// The rest of the code below
// var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();  
builder.Services.AddSession();   

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );


app.Run();
