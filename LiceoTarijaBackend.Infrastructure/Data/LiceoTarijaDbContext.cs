using System;
using System.Collections.Generic;
using LiceoTarijaBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LiceoTarijaBackend.Infrastructure.Data
{
    public class LiceoTarijaDbContext : DbContext
    {
        public LiceoTarijaDbContext(DbContextOptions<LiceoTarijaDbContext> options) : base(options) { }

        // DbSets
        public DbSet<Dimension> Dimensiones { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioRol> UsuariosRoles { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Apoderado> Apoderados { get; set; }
        public DbSet<ApoderadoEstudiante> ApoderadosEstudiantes { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Gestion> Gestiones { get; set; }
        public DbSet<CursoGestion> CursosGestion { get; set; }
        public DbSet<CursoArea> CursosAreas { get; set; }
        public DbSet<CursoAreaProfesor> CursosAreasProfesores { get; set; }
        public DbSet<GestionEstudiante> GestionesEstudiantes { get; set; }
        public DbSet<GestionProfesor> GestionesProfesores { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Observacion> Observaciones { get; set; }
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<BloqueHorario> BloquesHorarios { get; set; }
        public DbSet<AsignacionHoraria> AsignacionesHorarias { get; set; }
        public DbSet<UnidadEducativa> UnidadesEducativas { get; set; }
        public DbSet<CalificacionesVentana> CalificacionesVentanas { get; set; }
        public DbSet<CalificacionesExcepcion> CalificacionesExcepciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // -------- Claves PRIMARIAS simples (por tus nombres IdXxx) --------
            modelBuilder.Entity<Dimension>().HasKey(e => e.IdDimension);
            modelBuilder.Entity<Area>().HasKey(e => e.IdArea);
            modelBuilder.Entity<Periodo>().HasKey(e => e.IdPeriodo);
            modelBuilder.Entity<Domicilio>().HasKey(e => e.IdDomicilio);
            modelBuilder.Entity<Persona>().HasKey(e => e.IdPersona);
            modelBuilder.Entity<Usuario>().HasKey(e => e.IdUsuario);
            modelBuilder.Entity<Estudiante>().HasKey(e => e.IdEstudiante);
            modelBuilder.Entity<Profesor>().HasKey(e => e.IdProfesor);
            modelBuilder.Entity<Apoderado>().HasKey(e => e.IdApoderado);
            modelBuilder.Entity<Personal>().HasKey(e => e.IdPersonal);
            modelBuilder.Entity<Curso>().HasKey(e => e.IdCurso);
            modelBuilder.Entity<Gestion>().HasKey(e => e.IdGestion);
            modelBuilder.Entity<CursoGestion>().HasKey(e => e.IdCursoGestion);
            modelBuilder.Entity<CursoArea>().HasKey(e => e.IdCursoArea);
            modelBuilder.Entity<CursoAreaProfesor>().HasKey(e => e.Id);  // PK es 'Id'
            modelBuilder.Entity<GestionEstudiante>().HasKey(e => e.IdGestionEstudiante);
            modelBuilder.Entity<GestionProfesor>().HasKey(e => e.IdGestionProfesor);
            modelBuilder.Entity<Evaluacion>().HasKey(e => e.IdEvaluacion);
            modelBuilder.Entity<Nota>().HasKey(e => e.IdNota);
            modelBuilder.Entity<Asistencia>().HasKey(e => e.IdAsistencia);
            modelBuilder.Entity<Observacion>().HasKey(e => e.IdObservacion);
            modelBuilder.Entity<Auditoria>().HasKey(e => e.Id);
            modelBuilder.Entity<BloqueHorario>().HasKey(e => e.IdBloque);
            modelBuilder.Entity<AsignacionHoraria>().HasKey(e => e.Id);
            modelBuilder.Entity<UnidadEducativa>().HasKey(e => e.IdUnidad);
            modelBuilder.Entity<CalificacionesVentana>().HasKey(e => e.IdVentana);
            modelBuilder.Entity<CalificacionesExcepcion>().HasKey(e => e.IdExcepcion);

            // -------- Claves compuestas --------
            modelBuilder.Entity<UsuarioRol>()
                .HasKey(x => new { x.IdUsuario, x.Rol, x.FechaDesde });

            modelBuilder.Entity<ApoderadoEstudiante>()
                .HasKey(x => new { x.IdApoderado, x.IdEstudiante, x.FechaDesde });

            // -------- Relaciones explícitas con Usuario (varias FK a la misma entidad) --------
            modelBuilder.Entity<CalificacionesVentana>()
                .HasOne(x => x.AbiertoPor)
                .WithMany(u => u.CalificacionesVentanasAbiertas)
                .HasForeignKey(x => x.AbiertoPorUsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CalificacionesVentana>()
                .HasOne(x => x.CerradoPor)
                .WithMany(u => u.CalificacionesVentanasCerradas)
                .HasForeignKey(x => x.CerradoPorUsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Observacion>()
                .HasOne(o => o.CreadoPor)
                .WithMany(u => u.ObservacionesCreadas)
                .HasForeignKey(o => o.CreadoPorUsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Evaluacion>()
                .HasOne(e => e.CreadoPor)
                .WithMany(u => u.EvaluacionesCreadas)
                .HasForeignKey(e => e.CreadoPorUsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            // (Opcional) Índice único filtrado de titular activo:
            // modelBuilder.Entity<ApoderadoEstudiante>()
            //   .HasIndex(x => x.IdEstudiante)
            //   .HasFilter("titular = TRUE AND fecha_hasta IS NULL")
            //   .IsUnique()
            //   .HasDatabaseName("uq_titular_estudiante_activo");
        }
    }
}

