using HomestayManagementAPI.Data;
using HomestayManagementAPI.Repositories.Interfaces;
using HomestayManagementAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using HomestayManagementAPI.Services;
using HomestayManagementAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Thêm Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add DI cho các repository và service
builder.Services.AddScoped<ICategoryArticleRepository, CategoryArticleRepository>();
builder.Services.AddScoped<ICategoryArticleService, CategoryArticleService>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<IArticleService, ArticleService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "HomestayManagementAPI v1");
        c.RoutePrefix = string.Empty; // Ð?t Swagger UI làm trang m?c ð?nh
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
