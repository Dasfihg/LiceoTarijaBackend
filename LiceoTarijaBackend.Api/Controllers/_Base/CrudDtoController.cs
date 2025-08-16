using AutoMapper;
using AutoMapper.QueryableExtensions;
using LiceoTarijaBackend.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LiceoTarijaBackend.Api.Controllers.Dto._Base;

public abstract class CrudDtoController<TEntity, TReadDto, TCreateDto, TUpdateDto, TKey> : ControllerBase
    where TEntity : class
{
    protected readonly LiceoTarijaDbContext _db;
    protected readonly IMapper _mapper;
    private readonly string _keyName;

    protected CrudDtoController(LiceoTarijaDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
        var et = _db.Model.FindEntityType(typeof(TEntity))
                 ?? throw new InvalidOperationException($"Tipo {typeof(TEntity).Name} no está en el DbContext.");
        var pk = et.FindPrimaryKey() ?? throw new InvalidOperationException($"{typeof(TEntity).Name} no tiene PK.");
        if (pk.Properties.Count != 1)
            throw new InvalidOperationException($"{typeof(TEntity).Name} tiene PK compuesta; usar controller manual.");
        _keyName = pk.Properties[0].Name;
    }

    protected IQueryable<TEntity> Query => _db.Set<TEntity>().AsQueryable();

    private static Expression<Func<TEntity, bool>> KeyEquals(string keyName, TKey id)
    {
        var p = Expression.Parameter(typeof(TEntity), "e");
        var prop = Expression.Property(p, keyName);
        var idConst = Expression.Constant(id, typeof(TKey));
        var eq = Expression.Equal(prop, idConst);
        return Expression.Lambda<Func<TEntity, bool>>(eq, p);
    }

    [HttpGet]
    public virtual async Task<ActionResult<IEnumerable<TReadDto>>> GetAll(CancellationToken ct)
    {
        var list = await Query.AsNoTracking()
            .ProjectTo<TReadDto>(_mapper.ConfigurationProvider)
            .ToListAsync(ct);
        return Ok(list);
    }

    [HttpGet("{id}")]
    public virtual async Task<ActionResult<TReadDto>> GetById([FromRoute] TKey id, CancellationToken ct)
    {
        var dto = await Query.AsNoTracking()
            .Where(KeyEquals(_keyName, id))
            .ProjectTo<TReadDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(ct);
        return dto is null ? NotFound() : Ok(dto);
    }

    [HttpPost]
    public virtual async Task<ActionResult<TReadDto>> Create([FromBody] TCreateDto dto, CancellationToken ct)
    {
        var entity = _mapper.Map<TEntity>(dto);
        _db.Set<TEntity>().Add(entity);
        await _db.SaveChangesAsync(ct);

        var keyProp = typeof(TEntity).GetProperty(_keyName)
                     ?? throw new InvalidOperationException($"No encuentro la PK {_keyName} en {typeof(TEntity).Name}");
        var keyVal = keyProp.GetValue(entity);

        var read = _mapper.Map<TReadDto>(entity);
        return CreatedAtAction(nameof(GetById), new { id = keyVal }, read);
    }

    [HttpPut("{id}")]
    public virtual async Task<IActionResult> Update([FromRoute] TKey id, [FromBody] TUpdateDto dto, CancellationToken ct)
    {
        var entity = await _db.Set<TEntity>().FirstOrDefaultAsync(KeyEquals(_keyName, id), ct);
        if (entity is null) return NotFound();
        _mapper.Map(dto, entity);
        await _db.SaveChangesAsync(ct);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public virtual async Task<IActionResult> Delete([FromRoute] TKey id, CancellationToken ct)
    {
        var entity = await _db.Set<TEntity>().FirstOrDefaultAsync(KeyEquals(_keyName, id), ct);
        if (entity is null) return NotFound();
        _db.Remove(entity);
        await _db.SaveChangesAsync(ct);
        return NoContent();
    }
}
