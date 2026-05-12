using Microsoft.EntityFrameworkCore;
using WorkoutLog.Data;

var builder = WebApplication.CreateBuilder(args);

// Используйте InMemory базу данных (не требует миграций)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("WorkoutLogDB"));

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
    pattern: "{controller=Workouts}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "workoutsByDay",
    pattern: "Workouts/Day/{date}",
    defaults: new { controller = "Workouts", action = "Day" });

app.Run();