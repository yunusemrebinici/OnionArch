using Application.Features.CQRS.Handlers.AboutHandlers;
using Application.Features.CQRS.Handlers.BannerHandlers;
using Application.Features.CQRS.Handlers.BrandHandlers;
using Application.Features.CQRS.Handlers.CarHandlers;
using Application.Features.CQRS.Handlers.CategoryHandlers;
using Application.Features.CQRS.Handlers.ContactHandlers;
using Application.Interfaces;
using Application.Interfaces.IAppUserRepositories;
using Application.Interfaces.IBlogRepositories;
using Application.Interfaces.ICarDescriptionRepositories;
using Application.Interfaces.ICarFeatureRepositories;
using Application.Interfaces.ICarPricingRepositories;
using Application.Interfaces.ICarRepositories;
using Application.Interfaces.ICommentRepositories;
using Application.Interfaces.IRentAcarRepositories;
using Application.Interfaces.IStatisticRepositories;
using Application.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Persistance.Context;
using Persistance.Repositories;
using Persistance.Repositories.AppUserRepositories;
using Persistance.Repositories.BlogRepositories;
using Persistance.Repositories.CarDescriptionRepositories;
using Persistance.Repositories.CarFeatureRepositories;
using Persistance.Repositories.CarPricingRepositories;
using Persistance.Repositories.CarRepositories;
using Persistance.Repositories.CommentRepositories;
using Persistance.Repositories.RentAcarRepositories;
using Persistance.Repositories.StatisticRepositories;
using Persistance.Repositories.TagRepositories;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped<IBlogRepository,BlogRepository>();
builder.Services.AddScoped<ITagRepository,TagRepository>();
builder.Services.AddScoped<ICommentRepository,CommentRepository>();
builder.Services.AddScoped<IStatisticRepository,StatistsicRepository>();
builder.Services.AddScoped<IRentAcarRepository,RentAcarRepository>();
builder.Services.AddScoped<ICarPricingRepository,CarPricingRepository>();
builder.Services.AddScoped<ICarFeatureRepository,CarFeatureRepository>();
builder.Services.AddScoped<ICarDescriptionRepository,CarDescriptionRepository>();
builder.Services.AddScoped<IAppUserRepository,AppUserRepository>();


builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();

builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();

builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommendHandler>();

builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandAndPriceQueryHandler>();
builder.Services.AddScoped<GetLast5CarsWithBrandQueryHandler>();
builder.Services.AddScoped<GetLastCarByIdQueryHandler>();

builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<GetCategoryByIdQuaryHandler>();
builder.Services.AddScoped<GetCategoryQuaryHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();

builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();

builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
	opt.RequireHttpsMetadata = false;
	opt.TokenValidationParameters = new TokenValidationParameters
	{
		ValidAudience = "https://localhost",
		ValidIssuer = "https://localhost",
		ClockSkew = TimeSpan.Zero,
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("carbookcarbookcarbookcarbook")),
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,
	};
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
