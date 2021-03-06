﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data.Entities.Context;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(CatContext))]
    partial class CatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2");

            modelBuilder.Entity("WebApplication1.Data.Entities.Cat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<int?>("Orderid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("color")
                        .HasColumnType("TEXT");

                    b.Property<string>("favoriteDish")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("orderNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Orderid");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("WebApplication1.Data.Entities.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("orderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("orderNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebApplication1.Data.Entities.Cat", b =>
                {
                    b.HasOne("WebApplication1.Data.Entities.Order", null)
                        .WithMany("Cats")
                        .HasForeignKey("Orderid");
                });
#pragma warning restore 612, 618
        }
    }
}
