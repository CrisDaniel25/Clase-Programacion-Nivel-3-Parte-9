﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea_9.Context;

namespace Tarea_9.Migrations
{
    [DbContext(typeof(CitaContext))]
    partial class CitaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tarea_9.Models.Cita", b =>
                {
                    b.Property<long>("cedula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("covid")
                        .HasColumnType("bit");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("justificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("latitud")
                        .HasColumnType("float");

                    b.Property<double>("longitud")
                        .HasColumnType("float");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("telefono")
                        .HasColumnType("bigint");

                    b.Property<string>("tipoSangre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cedula");

                    b.ToTable("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
