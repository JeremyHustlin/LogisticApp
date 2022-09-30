﻿// <auto-generated />
using System;
using LogisticApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LogisticApp.Migrations.LogisticDbContextV4Migrations
{
    [DbContext(typeof(LogisticDbContextV4))]
    partial class LogisticDbContextV4ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LogisticApp.ModelsCustomer.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CallCentrePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("LogisticApp.ModelsCustomer.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<string>("OrderLocationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderLocationId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("LogisticApp.ModelsCustomer.OrderLocation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderLocation");
                });

            modelBuilder.Entity("LogisticApp.ModelsCustomer.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.Driver", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ForWarderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Free_or_Busy")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("Hour")
                        .HasColumnType("time");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ForWarderId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.ForWarder", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Call_Centre_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchedulesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SchedulesId");

                    b.ToTable("ForWarders");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.Schedule", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DriverId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderLocationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("OrderLocationId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.Vehicle", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DriverId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ForWarderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("ForWarderId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.VehicleLocation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<TimeSpan>("Hour")
                        .HasColumnType("time");

                    b.Property<string>("Location_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehiclesLocations");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<string>("OrdersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("LogisticApp.ModelsCustomer.Order", b =>
                {
                    b.HasOne("LogisticApp.ModelsCustomer.Customer", "Customers")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogisticApp.ModelsCustomer.OrderLocation", "OrderLocations")
                        .WithMany("Orders")
                        .HasForeignKey("OrderLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("OrderLocations");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.Driver", b =>
                {
                    b.HasOne("LogisticApp.ModelsForWarder.ForWarder", null)
                        .WithMany("Drivers")
                        .HasForeignKey("ForWarderId");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.ForWarder", b =>
                {
                    b.HasOne("LogisticApp.ModelsForWarder.Schedule", "Schedules")
                        .WithMany()
                        .HasForeignKey("SchedulesId");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.Schedule", b =>
                {
                    b.HasOne("LogisticApp.ModelsForWarder.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogisticApp.ModelsCustomer.OrderLocation", "OrderLocation")
                        .WithMany()
                        .HasForeignKey("OrderLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("OrderLocation");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.Vehicle", b =>
                {
                    b.HasOne("LogisticApp.ModelsForWarder.Driver", null)
                        .WithMany("Vehicles")
                        .HasForeignKey("DriverId");

                    b.HasOne("LogisticApp.ModelsForWarder.ForWarder", null)
                        .WithMany("Vehicles")
                        .HasForeignKey("ForWarderId");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("LogisticApp.ModelsCustomer.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogisticApp.ModelsCustomer.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LogisticApp.ModelsCustomer.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("LogisticApp.ModelsCustomer.OrderLocation", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.Driver", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("LogisticApp.ModelsForWarder.ForWarder", b =>
                {
                    b.Navigation("Drivers");

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
