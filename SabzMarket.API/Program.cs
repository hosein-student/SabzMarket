using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SabzMarket.API.DependencyInjection;
using SabzMarket.BLL;
using SabzMarket.DAL;
using SabzMarket.DAL.Logging;

var builder = WebApplication.CreateBuilder(args);
var connectionString = Environment.GetEnvironmentVariable("SABZMARKET_DB");

if (string.IsNullOrEmpty(connectionString))
{
    throw new Exception("? Connection string not found. Please set environment variable: SABZMARKET_DB");
}
builder.Services
    .AddDatabase(connectionString)
    .AddRepositories()
    .AddApplicationServices()
    .AddUnitOfWork();
//builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
// Add services to the container.
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

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
