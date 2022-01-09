﻿// <auto-generated />
using System;
using ContactApplication.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ContactApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ContactApplication.Models.CallLogs", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ContactId")
                        .HasColumnType("integer");

                    b.Property<string>("LogType")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LogId");

                    b.HasIndex("ContactId");

                    b.HasIndex("UserId");

                    b.ToTable("CallLogs");
                });

            modelBuilder.Entity("ContactApplication.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("integer");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ContactId");

                    b.HasIndex("UserId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("ContactApplication.Models.Login", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int?>("UserRegId")
                        .HasColumnType("integer");

                    b.HasKey("UserId");

                    b.HasIndex("UserRegId");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("ContactApplication.Models.Register", b =>
                {
                    b.Property<int>("UserRegId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("UserRegId");

                    b.ToTable("Register");
                });

            modelBuilder.Entity("ContactApplication.Models.CallLogs", b =>
                {
                    b.HasOne("ContactApplication.Models.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.HasOne("ContactApplication.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContactApplication.Models.Contact", b =>
                {
                    b.HasOne("ContactApplication.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ContactApplication.Models.Login", b =>
                {
                    b.HasOne("ContactApplication.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("UserRegId");
                });
#pragma warning restore 612, 618
        }
    }
}