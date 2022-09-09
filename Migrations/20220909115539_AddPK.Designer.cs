﻿// <auto-generated />
using System;
using Lab1Test.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab1Test.Migrations
{
    [DbContext(typeof(Lab1Context))]
    [Migration("20220909115539_AddPK")]
    partial class AddPK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lab1Test.EF.Roster", b =>
                {
                    b.Property<string>("Playerid")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("playerid");

                    b.Property<string>("Birthcity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("birthcity");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime")
                        .HasColumnName("birthday");

                    b.Property<string>("Birthstate")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("birthstate");

                    b.Property<string>("Fname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("fname");

                    b.Property<int?>("Height")
                        .HasColumnType("int")
                        .HasColumnName("height");

                    b.Property<int?>("Jersey")
                        .HasColumnType("int")
                        .HasColumnName("jersey");

                    b.Property<string>("Position")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("position");

                    b.Property<string>("Sname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sname");

                    b.Property<int?>("Weight")
                        .HasColumnType("int")
                        .HasColumnName("weight");

                    b.HasKey("Playerid");

                    b.ToTable("roster", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
