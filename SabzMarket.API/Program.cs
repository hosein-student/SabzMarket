using Microsoft.EntityFrameworkCore;
using SabzMarket.DAL;
using SabzMarket.BLL;
using SabzMarket.Share.Data;
using SabzMarket.Share.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = Environment.GetEnvironmentVariable("SABZMARKET_DB");

if (string.IsNullOrEmpty(connectionString))
{
    throw new Exception("? Connection string not found. Please set environment variable: SABZMARKET_DB");
}
builder.Services.AddDbContext<SabzMarketDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IErrorRepository, ErrorRepository>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
