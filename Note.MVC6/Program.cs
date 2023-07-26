using Microsoft.EntityFrameworkCore;
using Note.BLL;
using Note.DAL;
using Note.DAL.DataContext;
using Note.IDAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//appsettings.json의 ConnectionStrings을 사용할 수 있게 전역으로 선언
//builder.Services.AddSingleton<IConfiguration>();

builder.Services.AddDbContext<NoteDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//의존성 주입
builder.Services.AddTransient<NoticeBll>();
builder.Services.AddTransient<INoticeDal, NoticeDal>();

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
