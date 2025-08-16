using AutoMapper;
using LiceoTarijaBackend.Application.DTOs.ApoderadoEstudiantes;
using LiceoTarijaBackend.Application.DTOs.Apoderados;
// DTOs (agrega los using según los uses)
using LiceoTarijaBackend.Application.DTOs.Areas;
using LiceoTarijaBackend.Application.DTOs.Asistencias;
using LiceoTarijaBackend.Application.DTOs.Auditorias;
using LiceoTarijaBackend.Application.DTOs.BloqueHorarios;
using LiceoTarijaBackend.Application.DTOs.CalificacionesExcepciones;
using LiceoTarijaBackend.Application.DTOs.CalificacionesVentanas;
using LiceoTarijaBackend.Application.DTOs.CursoAreaProfesores;
using LiceoTarijaBackend.Application.DTOs.CursoAreas;
using LiceoTarijaBackend.Application.DTOs.CursosGestion;
using LiceoTarijaBackend.Application.DTOs.Cursos;
using LiceoTarijaBackend.Application.DTOs.Dimensions;
using LiceoTarijaBackend.Application.DTOs.Domicilios;
using LiceoTarijaBackend.Application.DTOs.Estudiantes;
using LiceoTarijaBackend.Application.DTOs.Evaluaciones;
using LiceoTarijaBackend.Application.DTOs.Gestiones;
using LiceoTarijaBackend.Application.DTOs.Notas;
using LiceoTarijaBackend.Application.DTOs.Observaciones;
using LiceoTarijaBackend.Application.DTOs.Periodos;
using LiceoTarijaBackend.Application.DTOs.Personas;
using LiceoTarijaBackend.Application.DTOs.Profesores;
using LiceoTarijaBackend.Application.DTOs.UnidadEducativas;
using LiceoTarijaBackend.Application.DTOs.UsuariosRoles;
using LiceoTarijaBackend.Application.DTOs.Usuarios;
// Entities
using LiceoTarijaBackend.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LiceoTarijaBackend.Application.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // PK simple (ejemplos clave)
            CreateMap<Area, AreaReadDto>(); CreateMap<AreaCreateDto, Area>(); CreateMap<AreaUpdateDto, Area>();
            CreateMap<Estudiante, EstudianteReadDto>(); CreateMap<EstudianteCreateDto, Estudiante>(); CreateMap<EstudianteUpdateDto, Estudiante>();
            CreateMap<Profesor, ProfesorReadDto>(); CreateMap<ProfesorCreateDto, Profesor>(); CreateMap<ProfesorUpdateDto, Profesor>();
            CreateMap<Persona, PersonaReadDto>(); CreateMap<PersonaCreateDto, Persona>(); CreateMap<PersonaUpdateDto, Persona>();
            CreateMap<Domicilio, DomicilioReadDto>(); CreateMap<DomicilioCreateDto, Domicilio>(); CreateMap<DomicilioUpdateDto, Domicilio>();
            CreateMap<Curso, CursoReadDto>(); CreateMap<CursoCreateDto, Curso>(); CreateMap<CursoUpdateDto, Curso>();
            CreateMap<Gestion, GestionReadDto>(); CreateMap<GestionCreateDto, Gestion>(); CreateMap<GestionUpdateDto, Gestion>();
            CreateMap<Periodo, PeriodoReadDto>(); CreateMap<PeriodoCreateDto, Periodo>(); CreateMap<PeriodoUpdateDto, Periodo>();
            CreateMap<Dimension, DimensionReadDto>(); CreateMap<DimensionCreateDto, Dimension>(); CreateMap<DimensionUpdateDto, Dimension>();
            CreateMap<Usuario, UsuarioReadDto>(); CreateMap<UsuarioCreateDto, Usuario>(); CreateMap<UsuarioUpdateDto, Usuario>();
            CreateMap<UnidadEducativa, UnidadEducativaReadDto>();
            CreateMap<UnidadEducativaCreateDto, UnidadEducativa>();
            CreateMap<UnidadEducativaUpdateDto, UnidadEducativa>();
            CreateMap<BloqueHorario, BloqueHorarioReadDto>(); CreateMap<BloqueHorarioCreateDto, BloqueHorario>(); CreateMap<BloqueHorarioUpdateDto, BloqueHorario>();
            CreateMap<Evaluacion, EvaluacionReadDto>(); CreateMap<EvaluacionCreateDto, Evaluacion>(); CreateMap<EvaluacionUpdateDto, Evaluacion>();
            CreateMap<Nota, NotaReadDto>(); CreateMap<NotaCreateDto, Nota>(); CreateMap<NotaUpdateDto, Nota>();
            CreateMap<Asistencia, AsistenciaReadDto>(); CreateMap<AsistenciaCreateDto, Asistencia>(); CreateMap<AsistenciaUpdateDto, Asistencia>();
            CreateMap<Observacion, ObservacionReadDto>(); CreateMap<ObservacionCreateDto, Observacion>(); CreateMap<ObservacionUpdateDto, Observacion>();
            CreateMap<Auditoria, AuditoriaReadDto>(); CreateMap<AuditoriaCreateDto, Auditoria>(); CreateMap<AuditoriaUpdateDto, Auditoria>();
            CreateMap<CalificacionesVentana, CalificacionesVentanaReadDto>();
            CreateMap<CalificacionesVentanaCreateDto, CalificacionesVentana>();
            CreateMap<CalificacionesVentanaUpdateDto, CalificacionesVentana>();
            CreateMap<CalificacionesExcepcion, CalificacionesExcepcionReadDto>();
            CreateMap<CalificacionesExcepcionCreateDto, CalificacionesExcepcion>();
            CreateMap<CalificacionesExcepcionUpdateDto, CalificacionesExcepcion>();

            // PK compuesta
            CreateMap<ApoderadoEstudiante, ApoderadoEstudianteReadDto>();
            CreateMap<ApoderadoEstudianteCreateDto, ApoderadoEstudiante>();
            CreateMap<ApoderadoEstudianteUpdateDto, ApoderadoEstudiante>();

            CreateMap<UsuarioRol, UsuarioRolReadDto>();
            CreateMap<UsuarioRolCreateDto, UsuarioRol>();
            CreateMap<UsuarioRolUpdateDto, UsuarioRol>();

            // Relaciones auxiliares
            CreateMap<CursoGestion, CursoGestionReadDto>(); CreateMap<CursoGestionCreateDto, CursoGestion>(); CreateMap<CursoGestionUpdateDto, CursoGestion>();
            CreateMap<CursoArea, CursoAreaReadDto>(); CreateMap<CursoAreaCreateDto, CursoArea>(); CreateMap<CursoAreaUpdateDto, CursoArea>();
            CreateMap<CursoAreaProfesor, CursoAreaProfesorReadDto>(); CreateMap<CursoAreaProfesorCreateDto, CursoAreaProfesor>(); CreateMap<CursoAreaProfesorUpdateDto, CursoAreaProfesor>();
            CreateMap<Apoderado, ApoderadoReadDto>(); CreateMap<ApoderadoCreateDto, Apoderado>(); CreateMap<ApoderadoUpdateDto, Apoderado>();
        }
    }
}


