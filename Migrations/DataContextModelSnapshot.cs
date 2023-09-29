﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

#nullable disable

namespace RpgApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RpgApi.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId")
                        .IsUnique();

                    b.ToTable("TB_ARMAS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 45,
                            Nome = "Pistola",
                            PersonagemId = 1
                        },
                        new
                        {
                            Id = 2,
                            Dano = 90,
                            Nome = "Escopeta",
                            PersonagemId = 2
                        },
                        new
                        {
                            Id = 3,
                            Dano = 70,
                            Nome = "Submetralhadora",
                            PersonagemId = 3
                        },
                        new
                        {
                            Id = 4,
                            Dano = 80,
                            Nome = "Fuzil",
                            PersonagemId = 4
                        },
                        new
                        {
                            Id = 5,
                            Dano = 100,
                            Nome = "Lançador de Foguetes",
                            PersonagemId = 5
                        },
                        new
                        {
                            Id = 6,
                            Dano = 50,
                            Nome = "Revólver",
                            PersonagemId = 6
                        },
                        new
                        {
                            Id = 7,
                            Dano = 30,
                            Nome = "Faca",
                            PersonagemId = 7
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<byte[]>("FotoPersonagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Inteligencia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontosVida")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_PERSONAGENS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Classe = 1,
                            Defesa = 23,
                            Forca = 17,
                            Inteligencia = 33,
                            Nome = "Frodo",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 2,
                            Classe = 1,
                            Defesa = 25,
                            Forca = 15,
                            Inteligencia = 30,
                            Nome = "Sam",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 3,
                            Classe = 3,
                            Defesa = 21,
                            Forca = 18,
                            Inteligencia = 35,
                            Nome = "Galadriel",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 4,
                            Classe = 2,
                            Defesa = 18,
                            Forca = 18,
                            Inteligencia = 37,
                            Nome = "Gandalf",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 5,
                            Classe = 1,
                            Defesa = 17,
                            Forca = 20,
                            Inteligencia = 31,
                            Nome = "Hobbit",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 6,
                            Classe = 3,
                            Defesa = 13,
                            Forca = 21,
                            Inteligencia = 34,
                            Nome = "Celeborn",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 7,
                            Classe = 2,
                            Defesa = 11,
                            Forca = 25,
                            Inteligencia = 35,
                            Nome = "Radagast",
                            PontosVida = 100
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Jogador");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIOS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "seuEmail@gmail.com",
                            Latitude = -23.520024100000001,
                            Longitude = -46.596497999999997,
                            PasswordHash = new byte[] { 197, 254, 203, 125, 169, 168, 128, 155, 47, 45, 100, 198, 233, 20, 69, 162, 221, 168, 19, 82, 200, 32, 148, 148, 169, 248, 190, 157, 37, 219, 55, 190, 58, 229, 69, 8, 36, 0, 81, 113, 53, 14, 39, 231, 137, 223, 147, 180, 9, 191, 195, 229, 166, 168, 191, 184, 34, 159, 63, 81, 46, 165, 187, 131 },
                            PasswordSalt = new byte[] { 160, 143, 12, 47, 207, 87, 112, 46, 92, 20, 28, 70, 3, 63, 124, 35, 242, 31, 158, 230, 147, 232, 84, 152, 101, 1, 108, 2, 222, 15, 164, 109, 216, 34, 113, 115, 110, 247, 123, 118, 116, 224, 0, 119, 53, 130, 240, 166, 135, 105, 109, 120, 51, 180, 177, 129, 224, 218, 153, 224, 80, 252, 69, 71, 26, 86, 215, 240, 181, 229, 2, 244, 236, 154, 18, 214, 108, 29, 139, 0, 198, 72, 12, 28, 107, 168, 248, 193, 150, 116, 66, 125, 165, 231, 101, 201, 7, 95, 185, 186, 249, 203, 207, 70, 138, 77, 66, 12, 171, 35, 81, 214, 244, 12, 153, 86, 86, 234, 154, 93, 194, 146, 106, 34, 166, 25, 161, 230 },
                            Perfil = "Admin",
                            Username = "UsuarioAdmin"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Arma", b =>
                {
                    b.HasOne("RpgApi.Models.Personagem", "Personagem")
                        .WithOne("Arma")
                        .HasForeignKey("RpgApi.Models.Arma", "PersonagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personagem");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.HasOne("RpgApi.Models.Usuario", "Usuario")
                        .WithMany("Personagens")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Navigation("Arma")
                        .IsRequired();
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}
