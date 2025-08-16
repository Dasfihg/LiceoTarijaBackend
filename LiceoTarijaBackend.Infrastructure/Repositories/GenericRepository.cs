using LiceoTarijaBackend.Domain.Interfaces;
using LiceoTarijaBackend.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace LiceoTarijaBackend.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly LiceoTarijaDbContext _ctx;
        public GenericRepository(LiceoTarijaDbContext ctx) => _ctx = ctx;

        public async Task<IEnumerable<T>> GetAllAsync() =>
          await _ctx.Set<T>().ToListAsync();

        public async Task<T?> GetByIdAsync(int id) =>
          await _ctx.Set<T>().FindAsync(id);

        public async Task AddAsync(T entity) =>
          await _ctx.Set<T>().AddAsync(entity);

        public void Update(T entity) =>
          _ctx.Set<T>().Update(entity);

        public void Remove(T entity) =>
          _ctx.Set<T>().Remove(entity);

        public async Task SaveChangesAsync() =>
          await _ctx.SaveChangesAsync();
    }
}


