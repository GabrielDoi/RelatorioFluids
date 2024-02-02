﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelatorioFluids;

#nullable disable

namespace RelatorioFluids.Migrations
{
    [DbContext(typeof(Repositorio))]
    [Migration("20240129120402_alterarColunasQtd")]
    partial class alterarColunasQtd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RelatorioFluids.Dosagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoteEN328")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LoteMF3")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LoteOX328")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LoteSO102")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Masseira")
                        .HasColumnType("int");

                    b.Property<decimal>("QtdEN328")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("QtdMF3")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("QtdOX328")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("QtdSO102")
                        .HasColumnType("decimal(10,3)");

                    b.HasKey("Id");

                    b.ToTable("Dosagem");
                });
#pragma warning restore 612, 618
        }
    }
}
