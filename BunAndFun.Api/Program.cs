using BunAndFun.Api.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore; // Add this

var builder = WebApplication.CreateBuilder(args);

// 1. Database & Controllers
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

// 2. Native .NET 9 OpenAPI support
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// 3. Configure the Pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // Generates the JSON spec
    app.MapScalarApiReference(); // This gives you a beautiful UI at /scalar/v1
}

app.UseHttpsRedirection();
app.UseCors("AllowAngular");
app.UseAuthorization();
app.MapControllers();

app.Run();