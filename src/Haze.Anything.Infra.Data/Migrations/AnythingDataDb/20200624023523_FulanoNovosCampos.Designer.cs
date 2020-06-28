﻿// <auto-generated />
using System;
using Haze.Anything.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Haze.Anything.Infra.Data.Migrations.AnythingDataDb
{
    [DbContext(typeof(AnythingDataDbContext))]
    [Migration("20200624023523_FulanoNovosCampos")]
    partial class FulanoNovosCampos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Haze.Anything.Domain.Entities.Fulano", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Tenant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Fulano");
                });

            modelBuilder.Entity("Haze.Anything.Domain.Entities.Fulano", b =>
                {
                    b.OwnsOne("Haze.Core.Domain.ValueObjects.Documento", "Documento", b1 =>
                        {
                            b1.Property<Guid>("FulanoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Numero")
                                .HasColumnName("DocumentoNumero")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Tipo")
                                .HasColumnName("DocumentoTipo")
                                .HasColumnType("int");

                            b1.HasKey("FulanoId");

                            b1.ToTable("Fulano");

                            b1.WithOwner()
                                .HasForeignKey("FulanoId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}