using AutoMapper;
using LiceoTarijaBackend.Infrastructure.Data;
using LiceoTarijaBackend.Api.Controllers.Dto._Base;
using LiceoTarijaBackend.Domain.Entities;
using LiceoTarijaBackend.Application.DTOs.BloqueHorarios;
using Microsoft.AspNetCore.Mvc;

namespace LiceoTarijaBackend.Api.Controllers.Dto;

[ApiController]
[Route("api/[controller]")]
public sealed class BloqueHorariosController : CrudDtoController<BloqueHorario, BloqueHorarioReadDto, BloqueHorarioCreateDto, BloqueHorarioUpdateDto, int>
{
    public BloqueHorariosController(LiceoTarijaDbContext db, IMapper mapper) : base(db, mapper) {}
}



