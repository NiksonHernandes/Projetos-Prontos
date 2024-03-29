﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using prototipoSiteTurismo;

namespace prototipoSiteTurismo.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("prototipoSiteTurismo.Entidades.Carrinho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CidadeChegada")
                        .HasColumnType("text");

                    b.Property<string>("CidadeSaida")
                        .HasColumnType("text");

                    b.Property<string>("DataChegada")
                        .HasColumnType("text");

                    b.Property<string>("DataSaida")
                        .HasColumnType("text");

                    b.Property<string>("Detalhes")
                        .HasColumnType("text");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("CARRINHO");
                });

            modelBuilder.Entity("prototipoSiteTurismo.Entidades.Hoteis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("DataChegada")
                        .HasColumnType("text");

                    b.Property<string>("DataSaida")
                        .HasColumnType("text");

                    b.Property<string>("Detalhes")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("HOTEIS");
                });

            modelBuilder.Entity("prototipoSiteTurismo.Entidades.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Endereco")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .HasColumnType("text");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("LOGIN");
                });

            modelBuilder.Entity("prototipoSiteTurismo.Entidades.Passagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CidadeChegada")
                        .HasColumnType("text");

                    b.Property<string>("CidadeSaida")
                        .HasColumnType("text");

                    b.Property<string>("DataChegada")
                        .HasColumnType("text");

                    b.Property<string>("DataSaida")
                        .HasColumnType("text");

                    b.Property<string>("Detalhes")
                        .HasColumnType("text");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("PASSAGEM");
                });
#pragma warning restore 612, 618
        }
    }
}
