using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nutricion.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroRegistro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCertificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: true),
                    CoachId = table.Column<int>(type: "int", nullable: true),
                    NutricionistaId = table.Column<int>(type: "int", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Historias_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SugerenciasCuidados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true),
                    PacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciasCuidados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SugerenciasCuidados_Historias_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SugerenciasCuidados_Personas_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Valoraciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    CaloriasConsumidas = table.Column<float>(type: "real", nullable: false),
                    Estatura = table.Column<float>(type: "real", nullable: false),
                    HistoriaId = table.Column<int>(type: "int", nullable: true),
                    PacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valoraciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Valoraciones_Historias_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Valoraciones_Personas_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CoachId",
                table: "Personas",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistoriaId",
                table: "Personas",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NutricionistaId",
                table: "Personas",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_SugerenciasCuidados_HistoriaId",
                table: "SugerenciasCuidados",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SugerenciasCuidados_PacienteId",
                table: "SugerenciasCuidados",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Valoraciones_HistoriaId",
                table: "Valoraciones",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Valoraciones_PacienteId",
                table: "Valoraciones",
                column: "PacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SugerenciasCuidados");

            migrationBuilder.DropTable(
                name: "Valoraciones");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Historias");
        }
    }
}
