using Microsoft.EntityFrameworkCore.Migrations;

namespace InstWeb.Migrations
{
    public partial class CambioNombreAlumno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_Alumnos_NameID",
                table: "Inscripciones");

            migrationBuilder.RenameColumn(
                name: "NameID",
                table: "Inscripciones",
                newName: "AlumnosID");

            migrationBuilder.RenameIndex(
                name: "IX_Inscripciones_NameID",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_Alumnos_AlumnosID",
                table: "Inscripciones");

            migrationBuilder.RenameColumn(
                name: "AlumnosID",
                table: "Inscripciones",
                newName: "NameID");

            migrationBuilder.RenameIndex(
                name: "IX_Inscripciones_AlumnosID",
                table: "Inscripciones",
                newName: "IX_Inscripciones_NameID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripciones_Alumnos_NameID",
                table: "Inscripciones",
                column: "NameID",
                principalTable: "Alumnos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
