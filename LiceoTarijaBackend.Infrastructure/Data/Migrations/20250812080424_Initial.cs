using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LiceoTarijaBackend.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    IdArea = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.IdArea);
                });

            migrationBuilder.CreateTable(
                name: "Auditorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Entidad = table.Column<string>(type: "text", nullable: false),
                    EntidadId = table.Column<int>(type: "integer", nullable: false),
                    Columna = table.Column<string>(type: "text", nullable: true),
                    UsuarioId = table.Column<int>(type: "integer", nullable: true),
                    Operacion = table.Column<string>(type: "text", nullable: false),
                    ValorAnterior = table.Column<string>(type: "text", nullable: true),
                    ValorNuevo = table.Column<string>(type: "text", nullable: true),
                    Observacion = table.Column<string>(type: "text", nullable: true),
                    FechaCambio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    IdCurso = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nivel = table.Column<string>(type: "text", nullable: false),
                    Grado = table.Column<string>(type: "text", nullable: false),
                    Paralelo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.IdCurso);
                });

            migrationBuilder.CreateTable(
                name: "Dimensiones",
                columns: table => new
                {
                    IdDimension = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Peso = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensiones", x => x.IdDimension);
                });

            migrationBuilder.CreateTable(
                name: "Domicilios",
                columns: table => new
                {
                    IdDomicilio = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Zona = table.Column<string>(type: "text", nullable: true),
                    Calle = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    TelefonoFijo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilios", x => x.IdDomicilio);
                });

            migrationBuilder.CreateTable(
                name: "Gestiones",
                columns: table => new
                {
                    IdGestion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Anio = table.Column<int>(type: "integer", nullable: false),
                    FechaInicio = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaFin = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestiones", x => x.IdGestion);
                });

            migrationBuilder.CreateTable(
                name: "Periodos",
                columns: table => new
                {
                    IdPeriodo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    FechaInicio = table.Column<DateOnly>(type: "date", nullable: true),
                    FechaFin = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodos", x => x.IdPeriodo);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApellidoPaterno = table.Column<string>(type: "text", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "text", nullable: false),
                    Nombres = table.Column<string>(type: "text", nullable: false),
                    Cedula = table.Column<string>(type: "text", nullable: false),
                    Celular = table.Column<string>(type: "text", nullable: true),
                    FotoUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesEducativas",
                columns: table => new
                {
                    IdUnidad = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Sigla = table.Column<string>(type: "text", nullable: true),
                    Codigo = table.Column<string>(type: "text", nullable: true),
                    DomicilioId = table.Column<int>(type: "integer", nullable: true),
                    Telefono1 = table.Column<string>(type: "text", nullable: true),
                    Telefono2 = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    SitioWeb = table.Column<string>(type: "text", nullable: true),
                    LogoUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesEducativas", x => x.IdUnidad);
                    table.ForeignKey(
                        name: "FK_UnidadesEducativas_Domicilios_DomicilioId",
                        column: x => x.DomicilioId,
                        principalTable: "Domicilios",
                        principalColumn: "IdDomicilio");
                });

            migrationBuilder.CreateTable(
                name: "BloquesHorarios",
                columns: table => new
                {
                    IdBloque = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdGestion = table.Column<int>(type: "integer", nullable: false),
                    Bloque = table.Column<int>(type: "integer", nullable: false),
                    HoraInicio = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    HoraFin = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    GestionIdGestion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloquesHorarios", x => x.IdBloque);
                    table.ForeignKey(
                        name: "FK_BloquesHorarios_Gestiones_GestionIdGestion",
                        column: x => x.GestionIdGestion,
                        principalTable: "Gestiones",
                        principalColumn: "IdGestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursosGestion",
                columns: table => new
                {
                    IdCursoGestion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCurso = table.Column<int>(type: "integer", nullable: false),
                    IdGestion = table.Column<int>(type: "integer", nullable: false),
                    FechaDesde = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaHasta = table.Column<DateOnly>(type: "date", nullable: true),
                    CursoIdCurso = table.Column<int>(type: "integer", nullable: false),
                    GestionIdGestion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosGestion", x => x.IdCursoGestion);
                    table.ForeignKey(
                        name: "FK_CursosGestion_Cursos_CursoIdCurso",
                        column: x => x.CursoIdCurso,
                        principalTable: "Cursos",
                        principalColumn: "IdCurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursosGestion_Gestiones_GestionIdGestion",
                        column: x => x.GestionIdGestion,
                        principalTable: "Gestiones",
                        principalColumn: "IdGestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apoderados",
                columns: table => new
                {
                    IdApoderado = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    Parentesco = table.Column<string>(type: "text", nullable: false),
                    IdDomicilio = table.Column<int>(type: "integer", nullable: false),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: false),
                    DomicilioIdDomicilio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apoderados", x => x.IdApoderado);
                    table.ForeignKey(
                        name: "FK_Apoderados_Domicilios_DomicilioIdDomicilio",
                        column: x => x.DomicilioIdDomicilio,
                        principalTable: "Domicilios",
                        principalColumn: "IdDomicilio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apoderados_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    IdEstudiante = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: true),
                    Sexo = table.Column<string>(type: "text", nullable: false),
                    Rude = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.IdEstudiante);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    IdPersonal = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    Cargo = table.Column<string>(type: "text", nullable: false),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.IdPersonal);
                    table.ForeignKey(
                        name: "FK_Personal_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    IdProfesor = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    Rda = table.Column<int>(type: "integer", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.IdProfesor);
                    table.ForeignKey(
                        name: "FK_Profesores_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPersona = table.Column<int>(type: "integer", nullable: false),
                    NombreUsuario = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    PersonaIdPersona = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursosAreas",
                columns: table => new
                {
                    IdCursoArea = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCursoGestion = table.Column<int>(type: "integer", nullable: false),
                    IdArea = table.Column<int>(type: "integer", nullable: false),
                    CursoGestionIdCursoGestion = table.Column<int>(type: "integer", nullable: false),
                    AreaIdArea = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosAreas", x => x.IdCursoArea);
                    table.ForeignKey(
                        name: "FK_CursosAreas_Areas_AreaIdArea",
                        column: x => x.AreaIdArea,
                        principalTable: "Areas",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursosAreas_CursosGestion_CursoGestionIdCursoGestion",
                        column: x => x.CursoGestionIdCursoGestion,
                        principalTable: "CursosGestion",
                        principalColumn: "IdCursoGestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApoderadosEstudiantes",
                columns: table => new
                {
                    IdApoderado = table.Column<int>(type: "integer", nullable: false),
                    IdEstudiante = table.Column<int>(type: "integer", nullable: false),
                    FechaDesde = table.Column<DateOnly>(type: "date", nullable: false),
                    Titular = table.Column<bool>(type: "boolean", nullable: true),
                    FechaHasta = table.Column<DateOnly>(type: "date", nullable: true),
                    ApoderadoIdApoderado = table.Column<int>(type: "integer", nullable: false),
                    EstudianteIdEstudiante = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApoderadosEstudiantes", x => new { x.IdApoderado, x.IdEstudiante, x.FechaDesde });
                    table.ForeignKey(
                        name: "FK_ApoderadosEstudiantes_Apoderados_ApoderadoIdApoderado",
                        column: x => x.ApoderadoIdApoderado,
                        principalTable: "Apoderados",
                        principalColumn: "IdApoderado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApoderadosEstudiantes_Estudiantes_EstudianteIdEstudiante",
                        column: x => x.EstudianteIdEstudiante,
                        principalTable: "Estudiantes",
                        principalColumn: "IdEstudiante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GestionesEstudiantes",
                columns: table => new
                {
                    IdGestionEstudiante = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdEstudiante = table.Column<int>(type: "integer", nullable: false),
                    IdCursoGestion = table.Column<int>(type: "integer", nullable: false),
                    FechaInscripcion = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaDesde = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaHasta = table.Column<DateOnly>(type: "date", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    EstudianteIdEstudiante = table.Column<int>(type: "integer", nullable: false),
                    CursoGestionIdCursoGestion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestionesEstudiantes", x => x.IdGestionEstudiante);
                    table.ForeignKey(
                        name: "FK_GestionesEstudiantes_CursosGestion_CursoGestionIdCursoGesti~",
                        column: x => x.CursoGestionIdCursoGestion,
                        principalTable: "CursosGestion",
                        principalColumn: "IdCursoGestion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GestionesEstudiantes_Estudiantes_EstudianteIdEstudiante",
                        column: x => x.EstudianteIdEstudiante,
                        principalTable: "Estudiantes",
                        principalColumn: "IdEstudiante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionesHorarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCursoGestion = table.Column<int>(type: "integer", nullable: false),
                    IdArea = table.Column<int>(type: "integer", nullable: false),
                    IdProfesor = table.Column<int>(type: "integer", nullable: false),
                    DiaSemana = table.Column<string>(type: "text", nullable: false),
                    IdBloque = table.Column<int>(type: "integer", nullable: false),
                    FechaDesde = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaHasta = table.Column<DateOnly>(type: "date", nullable: true),
                    AreaIdArea = table.Column<int>(type: "integer", nullable: false),
                    BloqueIdBloque = table.Column<int>(type: "integer", nullable: false),
                    CursoGestionIdCursoGestion = table.Column<int>(type: "integer", nullable: false),
                    ProfesorIdProfesor = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionesHorarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsignacionesHorarias_Areas_AreaIdArea",
                        column: x => x.AreaIdArea,
                        principalTable: "Areas",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignacionesHorarias_BloquesHorarios_BloqueIdBloque",
                        column: x => x.BloqueIdBloque,
                        principalTable: "BloquesHorarios",
                        principalColumn: "IdBloque",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignacionesHorarias_CursosGestion_CursoGestionIdCursoGesti~",
                        column: x => x.CursoGestionIdCursoGestion,
                        principalTable: "CursosGestion",
                        principalColumn: "IdCursoGestion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignacionesHorarias_Profesores_ProfesorIdProfesor",
                        column: x => x.ProfesorIdProfesor,
                        principalTable: "Profesores",
                        principalColumn: "IdProfesor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursosAreasProfesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCursoGestion = table.Column<int>(type: "integer", nullable: false),
                    IdArea = table.Column<int>(type: "integer", nullable: false),
                    IdProfesor = table.Column<int>(type: "integer", nullable: false),
                    CursoGestionIdCursoGestion = table.Column<int>(type: "integer", nullable: false),
                    AreaIdArea = table.Column<int>(type: "integer", nullable: false),
                    ProfesorIdProfesor = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosAreasProfesores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursosAreasProfesores_Areas_AreaIdArea",
                        column: x => x.AreaIdArea,
                        principalTable: "Areas",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursosAreasProfesores_CursosGestion_CursoGestionIdCursoGest~",
                        column: x => x.CursoGestionIdCursoGestion,
                        principalTable: "CursosGestion",
                        principalColumn: "IdCursoGestion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursosAreasProfesores_Profesores_ProfesorIdProfesor",
                        column: x => x.ProfesorIdProfesor,
                        principalTable: "Profesores",
                        principalColumn: "IdProfesor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GestionesProfesores",
                columns: table => new
                {
                    IdGestionProfesor = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdProfesor = table.Column<int>(type: "integer", nullable: false),
                    IdCursoGestion = table.Column<int>(type: "integer", nullable: false),
                    EsTutor = table.Column<bool>(type: "boolean", nullable: true),
                    FechaDesde = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaHasta = table.Column<DateOnly>(type: "date", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    ProfesorIdProfesor = table.Column<int>(type: "integer", nullable: false),
                    CursoGestionIdCursoGestion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestionesProfesores", x => x.IdGestionProfesor);
                    table.ForeignKey(
                        name: "FK_GestionesProfesores_CursosGestion_CursoGestionIdCursoGestion",
                        column: x => x.CursoGestionIdCursoGestion,
                        principalTable: "CursosGestion",
                        principalColumn: "IdCursoGestion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GestionesProfesores_Profesores_ProfesorIdProfesor",
                        column: x => x.ProfesorIdProfesor,
                        principalTable: "Profesores",
                        principalColumn: "IdProfesor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalificacionesVentanas",
                columns: table => new
                {
                    IdVentana = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdGestion = table.Column<int>(type: "integer", nullable: false),
                    IdPeriodo = table.Column<int>(type: "integer", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    AbiertoPorUsuarioId = table.Column<int>(type: "integer", nullable: true),
                    AbiertoEn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CerradoPorUsuarioId = table.Column<int>(type: "integer", nullable: true),
                    CerradoEn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    GestionIdGestion = table.Column<int>(type: "integer", nullable: false),
                    PeriodoIdPeriodo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalificacionesVentanas", x => x.IdVentana);
                    table.ForeignKey(
                        name: "FK_CalificacionesVentanas_Gestiones_GestionIdGestion",
                        column: x => x.GestionIdGestion,
                        principalTable: "Gestiones",
                        principalColumn: "IdGestion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalificacionesVentanas_Periodos_PeriodoIdPeriodo",
                        column: x => x.PeriodoIdPeriodo,
                        principalTable: "Periodos",
                        principalColumn: "IdPeriodo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalificacionesVentanas_Usuarios_AbiertoPorUsuarioId",
                        column: x => x.AbiertoPorUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                    table.ForeignKey(
                        name: "FK_CalificacionesVentanas_Usuarios_CerradoPorUsuarioId",
                        column: x => x.CerradoPorUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Evaluaciones",
                columns: table => new
                {
                    IdEvaluacion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    IdDimension = table.Column<int>(type: "integer", nullable: false),
                    IdArea = table.Column<int>(type: "integer", nullable: false),
                    IdProfesor = table.Column<int>(type: "integer", nullable: false),
                    IdPeriodo = table.Column<int>(type: "integer", nullable: false),
                    IdCursoGestion = table.Column<int>(type: "integer", nullable: false),
                    TipoEvaluacion = table.Column<string>(type: "text", nullable: false),
                    CreadoPorUsuarioId = table.Column<int>(type: "integer", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DimensionIdDimension = table.Column<int>(type: "integer", nullable: false),
                    AreaIdArea = table.Column<int>(type: "integer", nullable: false),
                    ProfesorIdProfesor = table.Column<int>(type: "integer", nullable: false),
                    PeriodoIdPeriodo = table.Column<int>(type: "integer", nullable: false),
                    CursoGestionIdCursoGestion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluaciones", x => x.IdEvaluacion);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_Areas_AreaIdArea",
                        column: x => x.AreaIdArea,
                        principalTable: "Areas",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_CursosGestion_CursoGestionIdCursoGestion",
                        column: x => x.CursoGestionIdCursoGestion,
                        principalTable: "CursosGestion",
                        principalColumn: "IdCursoGestion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_Dimensiones_DimensionIdDimension",
                        column: x => x.DimensionIdDimension,
                        principalTable: "Dimensiones",
                        principalColumn: "IdDimension",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_Periodos_PeriodoIdPeriodo",
                        column: x => x.PeriodoIdPeriodo,
                        principalTable: "Periodos",
                        principalColumn: "IdPeriodo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_Profesores_ProfesorIdProfesor",
                        column: x => x.ProfesorIdProfesor,
                        principalTable: "Profesores",
                        principalColumn: "IdProfesor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_Usuarios_CreadoPorUsuarioId",
                        column: x => x.CreadoPorUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "UsuariosRoles",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "integer", nullable: false),
                    Rol = table.Column<string>(type: "text", nullable: false),
                    FechaDesde = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaHasta = table.Column<DateOnly>(type: "date", nullable: true),
                    UsuarioIdUsuario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosRoles", x => new { x.IdUsuario, x.Rol, x.FechaDesde });
                    table.ForeignKey(
                        name: "FK_UsuariosRoles_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    IdAsistencia = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdGestionEstudiante = table.Column<int>(type: "integer", nullable: false),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    TipoAsistencia = table.Column<string>(type: "text", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    GestionEstudianteIdGestionEstudiante = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.IdAsistencia);
                    table.ForeignKey(
                        name: "FK_Asistencias_GestionesEstudiantes_GestionEstudianteIdGestion~",
                        column: x => x.GestionEstudianteIdGestionEstudiante,
                        principalTable: "GestionesEstudiantes",
                        principalColumn: "IdGestionEstudiante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Observaciones",
                columns: table => new
                {
                    IdObservacion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdGestionEstudiante = table.Column<int>(type: "integer", nullable: false),
                    IdProfesor = table.Column<int>(type: "integer", nullable: false),
                    IdArea = table.Column<int>(type: "integer", nullable: false),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    CreadoPorUsuarioId = table.Column<int>(type: "integer", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    GestionEstudianteIdGestionEstudiante = table.Column<int>(type: "integer", nullable: false),
                    ProfesorIdProfesor = table.Column<int>(type: "integer", nullable: false),
                    AreaIdArea = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observaciones", x => x.IdObservacion);
                    table.ForeignKey(
                        name: "FK_Observaciones_Areas_AreaIdArea",
                        column: x => x.AreaIdArea,
                        principalTable: "Areas",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Observaciones_GestionesEstudiantes_GestionEstudianteIdGesti~",
                        column: x => x.GestionEstudianteIdGestionEstudiante,
                        principalTable: "GestionesEstudiantes",
                        principalColumn: "IdGestionEstudiante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Observaciones_Profesores_ProfesorIdProfesor",
                        column: x => x.ProfesorIdProfesor,
                        principalTable: "Profesores",
                        principalColumn: "IdProfesor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Observaciones_Usuarios_CreadoPorUsuarioId",
                        column: x => x.CreadoPorUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "CalificacionesExcepciones",
                columns: table => new
                {
                    IdExcepcion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdVentana = table.Column<int>(type: "integer", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    Motivo = table.Column<string>(type: "text", nullable: true),
                    FechaDesde = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaHasta = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    VentanaIdVentana = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalificacionesExcepciones", x => x.IdExcepcion);
                    table.ForeignKey(
                        name: "FK_CalificacionesExcepciones_CalificacionesVentanas_VentanaIdV~",
                        column: x => x.VentanaIdVentana,
                        principalTable: "CalificacionesVentanas",
                        principalColumn: "IdVentana",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalificacionesExcepciones_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    IdNota = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    IdGestionEstudiante = table.Column<int>(type: "integer", nullable: false),
                    IdEvaluacion = table.Column<int>(type: "integer", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    GestionEstudianteIdGestionEstudiante = table.Column<int>(type: "integer", nullable: false),
                    EvaluacionIdEvaluacion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.IdNota);
                    table.ForeignKey(
                        name: "FK_Notas_Evaluaciones_EvaluacionIdEvaluacion",
                        column: x => x.EvaluacionIdEvaluacion,
                        principalTable: "Evaluaciones",
                        principalColumn: "IdEvaluacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notas_GestionesEstudiantes_GestionEstudianteIdGestionEstudi~",
                        column: x => x.GestionEstudianteIdGestionEstudiante,
                        principalTable: "GestionesEstudiantes",
                        principalColumn: "IdGestionEstudiante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apoderados_DomicilioIdDomicilio",
                table: "Apoderados",
                column: "DomicilioIdDomicilio");

            migrationBuilder.CreateIndex(
                name: "IX_Apoderados_PersonaIdPersona",
                table: "Apoderados",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_ApoderadosEstudiantes_ApoderadoIdApoderado",
                table: "ApoderadosEstudiantes",
                column: "ApoderadoIdApoderado");

            migrationBuilder.CreateIndex(
                name: "IX_ApoderadosEstudiantes_EstudianteIdEstudiante",
                table: "ApoderadosEstudiantes",
                column: "EstudianteIdEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesHorarias_AreaIdArea",
                table: "AsignacionesHorarias",
                column: "AreaIdArea");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesHorarias_BloqueIdBloque",
                table: "AsignacionesHorarias",
                column: "BloqueIdBloque");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesHorarias_CursoGestionIdCursoGestion",
                table: "AsignacionesHorarias",
                column: "CursoGestionIdCursoGestion");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesHorarias_ProfesorIdProfesor",
                table: "AsignacionesHorarias",
                column: "ProfesorIdProfesor");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_GestionEstudianteIdGestionEstudiante",
                table: "Asistencias",
                column: "GestionEstudianteIdGestionEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_BloquesHorarios_GestionIdGestion",
                table: "BloquesHorarios",
                column: "GestionIdGestion");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionesExcepciones_UsuarioId",
                table: "CalificacionesExcepciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionesExcepciones_VentanaIdVentana",
                table: "CalificacionesExcepciones",
                column: "VentanaIdVentana");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionesVentanas_AbiertoPorUsuarioId",
                table: "CalificacionesVentanas",
                column: "AbiertoPorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionesVentanas_CerradoPorUsuarioId",
                table: "CalificacionesVentanas",
                column: "CerradoPorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionesVentanas_GestionIdGestion",
                table: "CalificacionesVentanas",
                column: "GestionIdGestion");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionesVentanas_PeriodoIdPeriodo",
                table: "CalificacionesVentanas",
                column: "PeriodoIdPeriodo");

            migrationBuilder.CreateIndex(
                name: "IX_CursosAreas_AreaIdArea",
                table: "CursosAreas",
                column: "AreaIdArea");

            migrationBuilder.CreateIndex(
                name: "IX_CursosAreas_CursoGestionIdCursoGestion",
                table: "CursosAreas",
                column: "CursoGestionIdCursoGestion");

            migrationBuilder.CreateIndex(
                name: "IX_CursosAreasProfesores_AreaIdArea",
                table: "CursosAreasProfesores",
                column: "AreaIdArea");

            migrationBuilder.CreateIndex(
                name: "IX_CursosAreasProfesores_CursoGestionIdCursoGestion",
                table: "CursosAreasProfesores",
                column: "CursoGestionIdCursoGestion");

            migrationBuilder.CreateIndex(
                name: "IX_CursosAreasProfesores_ProfesorIdProfesor",
                table: "CursosAreasProfesores",
                column: "ProfesorIdProfesor");

            migrationBuilder.CreateIndex(
                name: "IX_CursosGestion_CursoIdCurso",
                table: "CursosGestion",
                column: "CursoIdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_CursosGestion_GestionIdGestion",
                table: "CursosGestion",
                column: "GestionIdGestion");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_PersonaIdPersona",
                table: "Estudiantes",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_AreaIdArea",
                table: "Evaluaciones",
                column: "AreaIdArea");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_CreadoPorUsuarioId",
                table: "Evaluaciones",
                column: "CreadoPorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_CursoGestionIdCursoGestion",
                table: "Evaluaciones",
                column: "CursoGestionIdCursoGestion");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_DimensionIdDimension",
                table: "Evaluaciones",
                column: "DimensionIdDimension");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_PeriodoIdPeriodo",
                table: "Evaluaciones",
                column: "PeriodoIdPeriodo");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_ProfesorIdProfesor",
                table: "Evaluaciones",
                column: "ProfesorIdProfesor");

            migrationBuilder.CreateIndex(
                name: "IX_GestionesEstudiantes_CursoGestionIdCursoGestion",
                table: "GestionesEstudiantes",
                column: "CursoGestionIdCursoGestion");

            migrationBuilder.CreateIndex(
                name: "IX_GestionesEstudiantes_EstudianteIdEstudiante",
                table: "GestionesEstudiantes",
                column: "EstudianteIdEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_GestionesProfesores_CursoGestionIdCursoGestion",
                table: "GestionesProfesores",
                column: "CursoGestionIdCursoGestion");

            migrationBuilder.CreateIndex(
                name: "IX_GestionesProfesores_ProfesorIdProfesor",
                table: "GestionesProfesores",
                column: "ProfesorIdProfesor");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_EvaluacionIdEvaluacion",
                table: "Notas",
                column: "EvaluacionIdEvaluacion");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_GestionEstudianteIdGestionEstudiante",
                table: "Notas",
                column: "GestionEstudianteIdGestionEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Observaciones_AreaIdArea",
                table: "Observaciones",
                column: "AreaIdArea");

            migrationBuilder.CreateIndex(
                name: "IX_Observaciones_CreadoPorUsuarioId",
                table: "Observaciones",
                column: "CreadoPorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Observaciones_GestionEstudianteIdGestionEstudiante",
                table: "Observaciones",
                column: "GestionEstudianteIdGestionEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Observaciones_ProfesorIdProfesor",
                table: "Observaciones",
                column: "ProfesorIdProfesor");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_PersonaIdPersona",
                table: "Personal",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_PersonaIdPersona",
                table: "Profesores",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_UnidadesEducativas_DomicilioId",
                table: "UnidadesEducativas",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PersonaIdPersona",
                table: "Usuarios",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosRoles_UsuarioIdUsuario",
                table: "UsuariosRoles",
                column: "UsuarioIdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApoderadosEstudiantes");

            migrationBuilder.DropTable(
                name: "AsignacionesHorarias");

            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "Auditorias");

            migrationBuilder.DropTable(
                name: "CalificacionesExcepciones");

            migrationBuilder.DropTable(
                name: "CursosAreas");

            migrationBuilder.DropTable(
                name: "CursosAreasProfesores");

            migrationBuilder.DropTable(
                name: "GestionesProfesores");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Observaciones");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "UnidadesEducativas");

            migrationBuilder.DropTable(
                name: "UsuariosRoles");

            migrationBuilder.DropTable(
                name: "Apoderados");

            migrationBuilder.DropTable(
                name: "BloquesHorarios");

            migrationBuilder.DropTable(
                name: "CalificacionesVentanas");

            migrationBuilder.DropTable(
                name: "Evaluaciones");

            migrationBuilder.DropTable(
                name: "GestionesEstudiantes");

            migrationBuilder.DropTable(
                name: "Domicilios");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Dimensiones");

            migrationBuilder.DropTable(
                name: "Periodos");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CursosGestion");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Gestiones");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}

