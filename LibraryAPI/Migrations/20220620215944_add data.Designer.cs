﻿// <auto-generated />
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryAPI.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20220620215944_add data")]
    partial class adddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryAPI.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pageSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Dostoyevski",
                            Name = "Suc ve Ceza",
                            Price = 45,
                            Type = "Roman",
                            pageSize = 560
                        },
                        new
                        {
                            Id = 2,
                            Author = "Arif Ergin",
                            Name = "Tekvin",
                            Price = 56,
                            Type = "Roman",
                            pageSize = 760
                        },
                        new
                        {
                            Id = 3,
                            Author = "Ali",
                            Name = "Cin Ali",
                            Price = 10,
                            Type = "Çocuk",
                            pageSize = 870
                        },
                        new
                        {
                            Id = 4,
                            Author = "JR:R TOLKIEN",
                            Name = "Yüzüklerin Efendisi",
                            Price = 90,
                            Type = "Bilim Kurgu",
                            pageSize = 900
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
