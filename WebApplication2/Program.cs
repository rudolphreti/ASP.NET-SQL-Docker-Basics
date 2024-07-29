using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;


var builder = WebApplication.CreateBuilder(args);

// Füge den DbContext hinzu
builder.Services.AddDbContext<TestDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Weitere Konfigurationen für Services und Middleware
builder.Services.AddControllersWithViews();

// Ensure logging to console is enabled
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug(); // Dodaje logowanie do debugera

var app = builder.Build();

// Konfiguriere Middleware
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
