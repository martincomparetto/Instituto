﻿// <auto-generated />
using System;
using InstWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InstWeb.Migrations
{
    [DbContext(typeof(InstitutoContext))]
    partial class InstitutoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("InstWeb.Models.Alumno", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("DNI")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Domicilio")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Legajo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Localidad")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("InstWeb.Models.Curso", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Denominacion")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ProfesorID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("ProfesorID");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("InstWeb.Models.Inscripcion", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AlumnoID")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CursoID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("AlumnoID");

                    b.HasIndex("CursoID");

                    b.ToTable("Inscripciones");
                });

            modelBuilder.Entity("InstWeb.Models.Profesor", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellido")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("DNI")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Domicilio")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("InstWeb.Models.Curso", b =>
                {
                    b.HasOne("InstWeb.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorID");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("InstWeb.Models.Inscripcion", b =>
                {
                    b.HasOne("InstWeb.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoID");

                    b.HasOne("InstWeb.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoID");

                    b.Navigation("Alumno");

                    b.Navigation("Curso");
                });
#pragma warning restore 612, 618
        }
    }
}