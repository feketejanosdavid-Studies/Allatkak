﻿// <auto-generated />
using Library.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library.Migrations
{
    [DbContext(typeof(AllatContext))]
    [Migration("20240313103730_MySQL")]
    partial class MySQL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Library.Models.Gazda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Gazda");
                });

            modelBuilder.Entity("Library.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Faj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GazdaId")
                        .HasColumnType("int");

                    b.Property<int>("Kor")
                        .HasColumnType("int");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("GazdaId");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("Library.Models.Pet", b =>
                {
                    b.HasOne("Library.Models.Gazda", null)
                        .WithMany("Pet")
                        .HasForeignKey("GazdaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Models.Gazda", b =>
                {
                    b.Navigation("Pet");
                });
#pragma warning restore 612, 618
        }
    }
}
