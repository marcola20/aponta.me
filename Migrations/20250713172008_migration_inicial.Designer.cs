﻿// <auto-generated />
using System;
using ApontaMe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApontaMe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250713172008_migration_inicial")]
    partial class migration_inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.7");

            modelBuilder.Entity("ApontaMe.Models.Apontamento", b =>
                {
                    b.Property<int>("ApontamentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("Entrada")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("Intervalo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("Saida")
                        .HasColumnType("TEXT");

                    b.HasKey("ApontamentoID");

                    b.ToTable("Apontamentos");
                });

            modelBuilder.Entity("ApontaMe.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Pessoa_Fisica")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pessoa_Juridica")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
