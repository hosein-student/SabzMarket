using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SabzMarket.BLL;
using SabzMarket.DAL;
using SabzMarket.DAL.Logging;

var builder = WebApplication.CreateBuilder(args);
var connectionString = Environment.GetEnvironmentVariable("SABZMARKET_DB");

if (string.IsNullOrEmpty(connectionString))
{
    throw new Exception("? Connection string not found. Please set environment variable: SABZMARKET_DB");
}
//builder.Services.AddDbContext<SabzMarketDbContext>(options =>
//    options.UseSqlServer(connectionString));

//builder.Services.AddDbContextFactory<SabzMarketDbContext>(options =>
//    options.UseSqlServer(connectionString));

builder.Services.AddDbContextFactory<SabzMarketDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<SabzMarketDbContext>(sp =>
    sp.GetRequiredService<IDbContextFactory<SabzMarketDbContext>>().CreateDbContext());



builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IErrorRepository, ErrorRepository>();
builder.Services.AddScoped<IErrorService, ErrorService>();
builder.Services.AddScoped<ISellerRepository, SellerRepository>();
builder.Services.AddScoped<ISellerService, SellerService>();
builder.Services.AddScoped<ICategorieRepository, CategorieRepository>();    
builder.Services.AddScoped<ICategoriService, CategoriService>();
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ILogServiceRepository, LogServiceRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
builder.Services.AddScoped<IProductOrderDetailHelperService, ProductOrderDetailHelperService>();
builder.Services.AddScoped<IFarmerRepository,FarmerRepository>();
builder.Services.AddScoped<IFarmerService, FarmerService>();
builder.Services.AddScoped<IFeaturedSellerSevice, FeaturedSellerSevice>();
builder.Services.AddScoped<IFeaturedSellerRepository, FeaturedSellerRepository>();
builder.Services.AddScoped<ICartItemRepository, CartItemRepository>();
builder.Services.AddScoped<ICartItemService, CartItemService>();


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
