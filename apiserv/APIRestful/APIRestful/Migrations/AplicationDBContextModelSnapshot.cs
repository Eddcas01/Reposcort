﻿// <auto-generated />
using System;
using APIRestful;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIRestful.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    partial class AplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIRestful.Models.Personas", b =>
                {
                    b.Property<int>("personaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CIF")
                        .HasColumnType("int");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EST")
                        .HasColumnType("int");

                    b.Property<DateTime>("FECHANAC")
                        .HasColumnType("datetime2");

                    b.Property<int>("NOCEL")
                        .HasColumnType("int");

                    b.Property<string>("NOMBRES")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NOTEL")
                        .HasColumnType("int");

                    b.HasKey("personaid");

                    b.ToTable("personas");
                });
#pragma warning restore 612, 618
        }
    }
}
