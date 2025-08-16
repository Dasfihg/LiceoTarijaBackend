using AutoMapper;
using LiceoTarijaBackend.Infrastructure.Data;
using LiceoTarijaBackend.Api.Controllers.Dto._Base;
using LiceoTarijaBackend.Domain.Entities;
using LiceoTarijaBackend.Application.DTOs.Evaluaciones;
using Microsoft.AspNetCore.Mvc;

namespace LiceoTarijaBackend.Api.Controllers.Dto;

[ApiController]
[Route("api/[controller]")]
public sealed class EvaluacionsController : CrudDtoController<Evaluacion, EvaluacionReadDto, EvaluacionCreateDto, EvaluacionUpdateDto, int>
{
    public EvaluacionsController(LiceoTarijaDbContext db, IMapper mapper) : base(db, mapper) {}
}



