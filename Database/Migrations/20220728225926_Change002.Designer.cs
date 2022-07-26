﻿// <auto-generated />
using System;
using Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(DbContextPersonalCard))]
    [Migration("20220728225926_Change002")]
    partial class Change002
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Database.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("date");

                    b.Property<DateTime?>("Death")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Persons", "dbo.Content");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birth = new DateTime(1596, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Death = new DateTime(1645, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Михаил",
                            LastName = "Романов",
                            MiddleName = "Федорович"
                        },
                        new
                        {
                            Id = 2,
                            Birth = new DateTime(1629, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Death = new DateTime(1676, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Алексей",
                            LastName = "Романов",
                            MiddleName = "Михайлович"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
