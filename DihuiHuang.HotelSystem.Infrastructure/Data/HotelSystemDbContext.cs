using DihuiHuang.HotelSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DihuiHuang.HotelSystem.Infrastructure.Data
{
    public class HotelSystemDbContext:DbContext
    {
        public HotelSystemDbContext(DbContextOptions<HotelSystemDbContext> options) : base(options)
        { }
        public DbSet<Service> Services { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(ConfigureRoom);
            modelBuilder.Entity<Customer>(ConfigureCustomer);
        }

        private void ConfigureCustomer(EntityTypeBuilder<Customer> modelBuilder)
        {
            modelBuilder.HasKey(c => c.Id);
            modelBuilder.HasOne(c => c.Room).WithMany(r => r.Customers).HasForeignKey(c => c.RoomNo);

        }

        private void ConfigureRoom(EntityTypeBuilder<Room> modelBuilder)
        {
            modelBuilder.HasKey(r => r.Id);
            modelBuilder.Property(r => r.Status).HasColumnType("bit");
            //modelBuilder.Property(r => r.RTCode).HasColumnType("int");
            modelBuilder.HasOne(r => r.RoomType).WithMany(rt => rt.Rooms).HasForeignKey(r=>r.RTCode);
        }

        //private void ConfigureService(EntityTypeBuilder<Service> modelBuilder)
        //{
        //    modelBuilder.HasKey(r => r.Id);
        //    modelBuilder.Property(r => r.RoomNo).HasColumnType("int");
        //    //modelBuilder.Property(r => r.RTCode).HasColumnType("int");
        //    modelBuilder.HasOne(r => r.RoomType).WithMany(rt => rt.Rooms).HasForeignKey(r => r.RTCode);
        //}

    }
}
