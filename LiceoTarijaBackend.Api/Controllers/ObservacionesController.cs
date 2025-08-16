using AutoMapper;
using LiceoTarijaBackend.Infrastructure.Data;
using LiceoTarijaBackend.Api.Controllers.Dto._Base;
using LiceoTarijaBackend.Domain.Entities;
using LiceoTarijaBackend.Application.DTOs.Observaciones;
using Microsoft.AspNetCore.Mvc;

namespace LiceoTarijaBackend.Api.Controllers.Dto;

[ApiController]
[Route("api/[controller]")]
public sealed class ObservacionsController : CrudDtoController<Observacion, ObservacionReadDto, ObservacionCreateDto, ObservacionUpdateDto, int>
{
    public ObservacionsController(LiceoTarijaDbContext db, IMapper mapper) : base(db, mapper) {}
}



