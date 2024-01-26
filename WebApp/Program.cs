using WebApp.Services;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
using WebApp.Services.PowerUseService;
using Microsoft.Extensions.Configuration;
using WebApp.Services.Interfaces;
using WebApp.Services;
using WebApp.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IDeviceService, DeviceService>();

builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddTransient<IPowerUseService, PowerUseService>();


builder.Services.AddDbContext<DbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BOSJ"));
});

var app = builder.Build();

//builder.Services.AddRazorPages();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();