using TimeToRun.Interfaces;
using TimeToRun.Repositories;
using TimeToRun.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IWeatherRespository, WeatherRespository>();
builder.Services.AddScoped<IWeatherService, WeatherService>();

builder.Services.AddHttpClient("OpenMeteo", httpClient =>
{
    httpClient.BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast");
});

var app = builder.Build();

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
