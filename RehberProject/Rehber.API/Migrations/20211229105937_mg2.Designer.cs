﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rehber.API.Data;

namespace Rehber.API.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211229105937_mg2")]
    partial class mg2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rehber.Entity.Model.Rehberr", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CikisDatetime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GirisDatetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rehberİsim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SilindiDatetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyisim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Rehberrs");
                });

            modelBuilder.Entity("Rehber.Entity.Model.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CikisDatetime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GirisDatetime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("SilindiDatetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userMail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Rehber.Entity.Model.Rehberr", b =>
                {
                    b.HasOne("Rehber.Entity.Model.User", "User")
                        .WithMany("Rehbers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Rehber.Entity.Model.User", b =>
                {
                    b.Navigation("Rehbers");
                });
#pragma warning restore 612, 618
        }
    }
}
