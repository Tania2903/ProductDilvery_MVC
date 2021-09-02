﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductDilvery_MVC.Data;

namespace ProductDilvery_MVC.Migrations
{
    [DbContext(typeof(PD_MVCDbContext))]
    [Migration("20210831044534_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("ProductDilvery_MVC.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Phone")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ProductDilvery_MVC.Models.Comapny", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Comapny");
                });

            modelBuilder.Entity("ProductDilvery_MVC.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Client")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Company")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Expected")
                        .HasColumnType("TEXT");

                    b.Property<int>("Product")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("clientId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("comapnyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("order")
                        .HasColumnType("TEXT");

                    b.Property<int?>("productId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("clientId");

                    b.HasIndex("comapnyId");

                    b.HasIndex("productId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ProductDilvery_MVC.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price_per_Item")
                        .HasColumnType("TEXT");

                    b.Property<int>("Qty")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ProductDilvery_MVC.Models.Order", b =>
                {
                    b.HasOne("ProductDilvery_MVC.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("clientId");

                    b.HasOne("ProductDilvery_MVC.Models.Comapny", "comapny")
                        .WithMany()
                        .HasForeignKey("comapnyId");

                    b.HasOne("ProductDilvery_MVC.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId");

                    b.Navigation("client");

                    b.Navigation("comapny");

                    b.Navigation("product");
                });
#pragma warning restore 612, 618
        }
    }
}