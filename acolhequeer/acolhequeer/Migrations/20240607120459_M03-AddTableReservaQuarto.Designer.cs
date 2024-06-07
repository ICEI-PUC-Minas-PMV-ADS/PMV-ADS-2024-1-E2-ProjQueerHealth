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
    [Migration("20240607120459_M03-AddTableReservaQuarto")]
    partial class M03AddTableReservaQuarto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("acolhequeer.Models.Instituicao", b =>
                {
                    b.Property<int>("Instituicao_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Instituicao_id"));

                    b.Property<bool>("Adm_validacao")
                        .HasColumnType("bit");

                    b.Property<bool>("Bool_atd")
                        .HasColumnType("bit");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Endereco_numero")
                        .HasColumnType("int");

                    b.Property<string>("Endereco_rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("N_vagas")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pix_doacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Qtd_disponibilidade")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Instituicao_id");

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("acolhequeer.Models.ReservaQuarto", b =>
                {
                    b.Property<int>("Reserva_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Reserva_id"));

                    b.Property<string>("Check_in")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Check_out")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_reserva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instituicao_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Usuario_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Reserva_id");

                    b.ToTable("ReservaQuartos");
                });

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