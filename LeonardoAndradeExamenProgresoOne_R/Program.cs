using LeonardoAndradeExamenProgresoOne_R.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LeonardoAndradeExamenProgresoOne_RContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LeonardoAndradeExamenProgresoOne_RContext") ?? throw new InvalidOperationException("Connection string 'LeonardoAndradeExamenProgresoOne_RContext' not found.")));

builder.Services.AddControllersWithViews();

var app = builder.Build();




if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
