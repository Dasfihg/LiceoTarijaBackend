using AutoMapper;
using LiceoTarijaBackend.Infrastructure.Data;
using LiceoTarijaBackend.Api.Controllers.Dto._Base;
using LiceoTarijaBackend.Domain.Entities;
using LiceoTarijaBackend.Application.DTOs.CursoAreaProfesores;
using Microsoft.AspNetCore.Mvc;

namespace LiceoTarijaBackend.Api.Controllers.Dto;

[ApiController]
[Route("api/[controller]")]
public sealed class CursoAreaProfesorsController : CrudDtoController<CursoAreaProfesor, CursoAreaProfesorReadDto, CursoAreaProfesorCreateDto, CursoAreaProfesorUpdateDto, int>
{
    public CursoAreaProfesorsController(LiceoTarijaDbContext db, IMapper mapper) : base(db, mapper) {}
}



