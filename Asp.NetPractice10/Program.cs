using Asp.NetPractice10.Data;
using Asp.NetPractice10.Repositories;
using Asp.NetPractice10.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ITimeService, TimeService>();
builder.Services.AddSingleton<GameScoreRepository>();

// получаем строку подключения из файла конфигурации
IConfigurationRoot _confString = new ConfigurationBuilder().
    SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();

// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
