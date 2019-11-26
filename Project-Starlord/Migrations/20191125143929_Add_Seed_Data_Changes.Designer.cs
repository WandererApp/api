﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Starlord.Data;

namespace Project_Starlord.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20191125143929_Add_Seed_Data_Changes")]
    partial class Add_Seed_Data_Changes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project_Starlord.Models.PinPointModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("PinPoints");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Latitude = 50m,
                            Longitude = 20m,
                            Timestamp = new DateTime(2019, 11, 25, 15, 39, 28, 651, DateTimeKind.Local).AddTicks(2185),
                            TripId = 1
                        },
                        new
                        {
                            Id = 2,
                            Latitude = 40m,
                            Longitude = 60m,
                            Timestamp = new DateTime(2019, 11, 25, 15, 39, 28, 651, DateTimeKind.Local).AddTicks(4098),
                            TripId = 1
                        },
                        new
                        {
                            Id = 3,
                            Latitude = 300m,
                            Longitude = 12m,
                            Timestamp = new DateTime(2019, 11, 25, 15, 39, 28, 651, DateTimeKind.Local).AddTicks(4147),
                            TripId = 1
                        },
                        new
                        {
                            Id = 4,
                            Latitude = 280m,
                            Longitude = 47m,
                            Timestamp = new DateTime(2019, 11, 25, 15, 39, 28, 651, DateTimeKind.Local).AddTicks(4152),
                            TripId = 1
                        },
                        new
                        {
                            Id = 5,
                            Latitude = 792m,
                            Longitude = 147m,
                            Timestamp = new DateTime(2019, 11, 25, 15, 39, 28, 651, DateTimeKind.Local).AddTicks(4156),
                            TripId = 2
                        },
                        new
                        {
                            Id = 6,
                            Latitude = 123m,
                            Longitude = 862m,
                            Timestamp = new DateTime(2019, 11, 25, 15, 39, 28, 651, DateTimeKind.Local).AddTicks(4166),
                            TripId = 2
                        },
                        new
                        {
                            Id = 7,
                            Latitude = 1200m,
                            Longitude = 1300m,
                            Timestamp = new DateTime(2019, 11, 25, 15, 39, 28, 651, DateTimeKind.Local).AddTicks(4169),
                            TripId = 2
                        });
                });

            modelBuilder.Entity("Project_Starlord.Models.ResetTokenModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsTokenUsed")
                        .HasColumnType("bit");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ResetTokens");
                });

            modelBuilder.Entity("Project_Starlord.Models.TripModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TimestampFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimestampTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("TripName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TimestampFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TimestampTo = new DateTime(2019, 11, 25, 15, 39, 28, 644, DateTimeKind.Local).AddTicks(8969),
                            TripName = "trip1",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            TimestampFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TimestampTo = new DateTime(2019, 11, 25, 15, 39, 28, 650, DateTimeKind.Local).AddTicks(7662),
                            TripName = "trip2",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Project_Starlord.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Email = "007@hr.nl",
                            Password = "saLye4TVUGn83DoIqmVxMUcjX+HuKahEuE7C/rk1FrhvCi8p",
                            Username = "SecretAgent"
                        },
                        new
                        {
                            Id = 1,
                            Email = "admin@admin.nl",
                            Password = "5DSldrrtWHc8L8QBXQ561zR+MEiR+JQmIRtvWiXCrF7RJoVx",
                            Username = "Admin"
                        });
                });

            modelBuilder.Entity("Project_Starlord.Models.PinPointModel", b =>
                {
                    b.HasOne("Project_Starlord.Models.TripModel", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project_Starlord.Models.TripModel", b =>
                {
                    b.HasOne("Project_Starlord.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
