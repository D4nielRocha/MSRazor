using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMS.Data;
using RazorPagesMS.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

#pragma warning disable CS8604 // Possible null reference argument.
builder.Services.AddDbContext<RazorPagesMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDbConnection") ?? throw new InvalidOperationException("Connection string 'RazorPagesMSContext' not found.")));
#pragma warning restore CS8604 // Possible null reference argument.

var app = builder.Build();



using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
