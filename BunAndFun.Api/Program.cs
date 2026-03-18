using BunAndFun.Api.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using BunAndFun.Api.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Database & Controllers
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddControllers();

// Native .NET 9 OpenAPI support
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configuring the Pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); //Generates the JSON spec
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseCors("AllowAngular");
app.UseAuthorization();
app.MapControllers();

app.Run();