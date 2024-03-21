using frontorigins.Application.services;
using frontorigins.Domain.common;
using Microsoft.EntityFrameworkCore;
using frontorigins.Infrastructure.configuation;
using Microsoft.OpenApi.Models;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using frontorigins.Application.configuration;
using frontorigins.Infrastructure.database;
using frontorigins.Infrastructure.database;
using FluentValidation;

using Microsoft.EntityFrameworkCore;
using frontorigins.Application.Validators;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder = AddValidators(builder);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "FrontOrigins.API", Version = "v1" });
});
builder.Services.AddScoped<DbContext, ApplicationDbContext>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddRepositoryConnector(builder.Configuration, connectionString );
builder.Services.AddServiceConnector();



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


static WebApplicationBuilder AddValidators(WebApplicationBuilder builder)
{
    builder.Services.AddValidatorsFromAssemblyContaining<UserValidator>();
    builder.Services.AddValidatorsFromAssemblyContaining<AddressValidation>();
    builder.Services.AddValidatorsFromAssemblyContaining<ClientValidator>();
    builder.Services.AddValidatorsFromAssemblyContaining<CompanyValidator>();
    builder.Services.AddValidatorsFromAssemblyContaining<DegreeValidator>();
    builder.Services.AddValidatorsFromAssemblyContaining<EmployeeValidator>();
    builder.Services.AddValidatorsFromAssemblyContaining<DepartmentValidator>();
    builder.Services.AddValidatorsFromAssemblyContaining<WorkExperienceValidator>();
    builder.Services.AddValidatorsFromAssemblyContaining<BusinessEquipementValidator>();

    return builder;

}