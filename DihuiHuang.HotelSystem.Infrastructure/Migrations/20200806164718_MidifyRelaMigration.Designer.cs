﻿// <auto-generated />
using System;
using DihuiHuang.HotelSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DihuiHuang.HotelSystem.Infrastructure.Migrations
{
    [DbContext(typeof(HotelSystemDbContext))]
    [Migration("20200806164718_MidifyRelaMigration")]
    partial class MidifyRelaMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DihuiHuang.HotelSystem.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("Advance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BookingDays")
                        .HasColumnType("int");

                    b.Property<string>("CName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("Checkin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("RoomNo")
                        .HasColumnType("int");

                    b.Property<int>("TotalPersons")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DihuiHuang.HotelSystem.Core.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RTCode")
                        .HasColumnType("int");

                    b.Property<int?>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DihuiHuang.HotelSystem.Core.Entities.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RTDesc")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("Rent")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("DihuiHuang.HotelSystem.Core.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("RoomNo")
                        .HasColumnType("int");

                    b.Property<string>("SDesc")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("DihuiHuang.HotelSystem.Core.Entities.Customer", b =>
                {
                    b.HasOne("DihuiHuang.HotelSystem.Core.Entities.Room", "Room")
                        .WithMany("Customers")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("DihuiHuang.HotelSystem.Core.Entities.Room", b =>
                {
                    b.HasOne("DihuiHuang.HotelSystem.Core.Entities.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId");
                });

            modelBuilder.Entity("DihuiHuang.HotelSystem.Core.Entities.Service", b =>
                {
                    b.HasOne("DihuiHuang.HotelSystem.Core.Entities.Room", "Room")
                        .WithMany("Services")
                        .HasForeignKey("RoomId");
                });
#pragma warning restore 612, 618
        }
    }
}