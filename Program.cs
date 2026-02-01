using backend.Data;
using backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Controllers සහ API සේවාවන් ඇතුළත් කිරීම
builder.Services.AddControllers();

// 2. MySQL Connection එක සැකසීම (Pomelo පාවිච්චි කර ඇත)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// 3. AuthService එක Dependency Injection හරහා ඇතුළත් කිරීම
builder.Services.AddScoped<IAuthService, AuthService>();

// 4. CORS Policy (React Frontend එකට API එක පාවිච්චි කරන්න ඉඩ දීම)
builder.Services.AddCors(options => {
    options.AddPolicy("AllowReactApp", policy => {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();
app.UseCors("AllowReactApp");


// Middleware Pipeline එක සැකසීම

// Cors පාවිච්චි කිරීම (Authorization වලට කලින් මෙය තිබිය යු

app.UseAuthorization();

app.MapControllers();

app.Run();
