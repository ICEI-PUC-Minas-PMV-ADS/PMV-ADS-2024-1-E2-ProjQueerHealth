﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using acolhequeer.Models;

#nullable disable

namespace acolhequeer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240607112428_M01-AddTableUsuario")]
    partial class M01AddTableUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("acolhequeer.Models.Usuario", b =>
                {
                    b.Property<int>("Usuario_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Usuario_id"));

                    b.Property<bool>("Bool_admin")
                        .HasColumnType("bit");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Endereco_numero")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Usuario_id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}