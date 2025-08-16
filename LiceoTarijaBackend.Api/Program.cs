using LiceoTarijaBackend.Infrastructure.Validators;
using LiceoTarijaBackend.Application.Validators;
using LiceoTarijaBackend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using LiceoTarijaBackend.Domain.Interfaces;
using LiceoTarijaBackend.Infrastructure.Repositories;

// AutoMapper & FluentValidation
using LiceoTarijaBackend.Application.Mapping; // MappingProfile
using FluentValidation;
using FluentValidation.AspNetCore;

// Json converters
using LiceoTarijaBackend.Api.Json;

var builder = WebApplication.CreateBuilder(args);

// 1) DbContext (Npgsql)
builder.Services.AddDbContext<LiceoTarijaDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2) Repo genérico
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// 3) Controllers + JSON (DateOnly / TimeOnly)
builder.Services.AddControllers().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
    o.JsonSerializerOptions.Converters.Add(new NullableDateOnlyJsonConverter());
    o.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
    o.JsonSerializerOptions.Converters.Add(new NullableTimeOnlyJsonConverter());
});

// 4) AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

// 5) FluentValidation
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<ApoderadoEstudianteCreateValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<NotaCreateValidator>();

// 6) CORS para el front
builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173", "http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// 7) Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 8) Swagger en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// CORS antes de MapControllers
app.UseCors("Frontend");

app.UseAuthorization();

app.MapControllers();
app.Run();

// Habilita "Program" como tipo visible para tests de integración, etc.
namespace LiceoTarijaBackend.Api { public partial class Program { } }
