using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InstWeb.Migrations
{
    public partial class AgregoInscripcionEnContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    CursoID = table.Column<Guid>(type: "TEXT", nullable: true),
                    NameID = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Alumnos_NameID",
                        column: x => x.NameID,
                        principalTable: "Alumnos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_CursoID",
                table: "Inscripciones",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_NameID",
                table: "Inscripciones",
                column: "NameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscripciones");
        }
    }
}
