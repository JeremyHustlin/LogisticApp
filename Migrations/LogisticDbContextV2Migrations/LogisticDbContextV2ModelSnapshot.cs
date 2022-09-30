﻿// <auto-generated />
using LogisticApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LogisticApp.Migrations.LogisticDbContextV2Migrations
{
    [DbContext(typeof(LogisticDbContextV2))]
    partial class LogisticDbContextV2ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LogisticApp.ModelsDelivers.Delivers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransportationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TransportationId");

                    b.ToTable("Delivers");
                });

            modelBuilder.Entity("LogisticApp.ModelsDelivers.Price", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Suma")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("LogisticApp.ModelsDelivers.Transportation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<string>("PriceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PriceId");

                    b.ToTable("Transportations");
                });

            modelBuilder.Entity("LogisticApp.ModelsDelivers.Delivers", b =>
                {
                    b.HasOne("LogisticApp.ModelsDelivers.Transportation", "Transportations")
                        .WithMany()
                        .HasForeignKey("TransportationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Transportations");
                });

            modelBuilder.Entity("LogisticApp.ModelsDelivers.Transportation", b =>
                {
                    b.HasOne("LogisticApp.ModelsDelivers.Price", "Prices")
                        .WithMany()
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prices");
                });
#pragma warning restore 612, 618
        }
    }
}
