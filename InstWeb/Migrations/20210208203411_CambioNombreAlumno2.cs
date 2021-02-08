using Microsoft.EntityFrameworkCore.Migrations;

namespace InstWeb.Migrations
{
    public partial class CambioNombreAlumno2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_Alumnos_AlumnosID",
                table: "Inscripciones");

            migrationBuilder.RenameColumn(
                name: "AlumnosID",
                table: "Inscripciones",
                newName: "AlumnoID");

            migrationBuilder.RenameIndex(
                name: "IX_Inscripciones_AlumnosID",
                table: "Inscripciones",
                newName: "IX_Inscripciones_AlumnoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripciones_Alumnos_AlumnoID",
                table: "Inscripciones",
                column: "AlumnoID",
                principalTable: "Alumnos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_Alumnos_AlumnoID",
                table: "Inscripciones");

            migrationBuilder.RenameColumn(
                name: "AlumnoID",
                table: "Inscripciones",
                newName: "AlumnosID");

            migrationBuilder.RenameIndex(
                name: "IX_Inscripciones_AlumnoID",
                table: "Inscripciones",
                newName: "IX_Inscripciones_AlumnosID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripciones_Alumnos_AlumnosID",
                table: "Inscripciones",
                column: "AlumnosID",
                principalTable: "Alumnos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
