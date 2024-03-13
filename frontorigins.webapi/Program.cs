using frontorigins.Infrastructure.database;
using FluentValidation;

using Microsoft.EntityFrameworkCore;
using frontorigins.Application.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder = AddValidators(builder);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

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