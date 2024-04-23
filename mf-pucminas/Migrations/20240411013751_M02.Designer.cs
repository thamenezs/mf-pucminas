﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mf_pucminas.Modelo;

#nullable disable

namespace mf_pucminas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240411013751_M02")]
    partial class M02
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("mf_pucminas.Modelo.Consumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Consumo");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.LinkDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ConsumoId")
                        .HasColumnType("int");

                    b.Property<string>("Href")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Metodo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsumoId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("LinkDto");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.VeiculoUsuarios", b =>
                {
                    b.Property<int>("Veiculoid")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Veiculoid", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("VeiculoUsuarios");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.Consumo", b =>
                {
                    b.HasOne("mf_pucminas.Modelo.Veiculo", "Veiculo")
                        .WithMany("Consumos")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.LinkDto", b =>
                {
                    b.HasOne("mf_pucminas.Modelo.Consumo", null)
                        .WithMany("Links")
                        .HasForeignKey("ConsumoId");

                    b.HasOne("mf_pucminas.Modelo.Veiculo", null)
                        .WithMany("Links")
                        .HasForeignKey("VeiculoId");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.VeiculoUsuarios", b =>
                {
                    b.HasOne("mf_pucminas.Modelo.Usuario", "Usuario")
                        .WithMany("Veiculos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mf_pucminas.Modelo.Veiculo", "Veiculo")
                        .WithMany("Usuarios")
                        .HasForeignKey("Veiculoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.Consumo", b =>
                {
                    b.Navigation("Links");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.Usuario", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("mf_pucminas.Modelo.Veiculo", b =>
                {
                    b.Navigation("Consumos");

                    b.Navigation("Links");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
