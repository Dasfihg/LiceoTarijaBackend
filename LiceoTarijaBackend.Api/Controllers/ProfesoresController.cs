using AutoMapper;
using LiceoTarijaBackend.Infrastructure.Data;
using LiceoTarijaBackend.Api.Controllers.Dto._Base;
using LiceoTarijaBackend.Domain.Entities;
using LiceoTarijaBackend.Application.DTOs.Profesores;
using Microsoft.AspNetCore.Mvc;

namespace LiceoTarijaBackend.Api.Controllers.Dto;

[ApiController]
[Route("api/[controller]")]
public sealed class ProfesorsController : CrudDtoController<Profesor, ProfesorReadDto, ProfesorCreateDto, ProfesorUpdateDto, int>
{
    public ProfesorsController(LiceoTarijaDbContext db, IMapper mapper) : base(db, mapper) {}
}



