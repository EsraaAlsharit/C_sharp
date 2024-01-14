var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//new

var app = builder.Build();

//new
app.UseStaticFiles();//for the images {wwwroot}
app.UseRouting();
app.UseAuthorization();

//new
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
