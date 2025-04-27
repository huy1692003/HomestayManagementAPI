using HomestayManagementAPI.Data;
using HomestayManagementAPI.Repositories.Interfaces;
using HomestayManagementAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using HomestayManagementAPI.Services;
using HomestayManagementAPI.Services.Interfaces;
using HomestayManagementAPI.Repositories.Intefaces;
using HomestayManagementAPI.Services.Interface;
using HomestayManagementAPI.Repositories.Interfaces;
using HomestayManagementAPI.Repositories;
using HomestayManagementAPI.Services.Interface;
using HomestayManagementAPI.Services;
using HomestayManagementAPI.Repositories.Interfaces;
using HomestayManagementAPI.Repositories;
using HomestayManagementAPI.Services.Interface;
using HomestayManagementAPI.Services;
using HomestayManagementAPI.Repositories.Intefaces;
using HomestayManagementAPI.Repositories;
using HomestayManagementAPI.Services.Interface;
using HomestayManagementAPI.Services;
using HomestayManagementAPI.Repositories.Intefaces;
using HomestayManagementAPI.Repositories;
using HomestayManagementAPI.Services.Interface;
using HomestayManagementAPI.Services;

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
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IAmenitiesRepository, AmenitiesRepository>();
builder.Services.AddScoped<IAmenitiesService, AmenitiesService>();
builder.Services.AddScoped<IFAQRepository, FAQRepository>();
builder.Services.AddScoped<IFAQService, FAQService>();
builder.Services.AddScoped<IFavoritesRepository, FavoritesRepository>();
builder.Services.AddScoped<IFavoritesService, FavoritesService>();
builder.Services.AddScoped<IHomeStayRepository, HomeStayRepository>();
builder.Services.AddScoped<IHomeStayService, HomeStayService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
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
