﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shoe_project_server.Data;

#nullable disable

namespace shoe_project_server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231125035713_initDB")]
    partial class initDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("userAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("userPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("userPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("userRole")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("userId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("shoe_project_server.Models.Favourite", b =>
                {
                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.HasKey("userId", "productId");

                    b.ToTable("favourites");
                });

            modelBuilder.Entity("shoe_project_server.Models.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("customerPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("deliveryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("orderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("orderStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("orderId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("shoe_project_server.Models.Producer", b =>
                {
                    b.Property<int>("producerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("producerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("producerId");

                    b.ToTable("producers");
                });

            modelBuilder.Entity("shoe_project_server.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ProductDescribe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("producerId")
                        .HasColumnType("int");

                    b.Property<string>("productImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("productPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("productId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("shoe_project_server.Models.ProductDetail", b =>
                {
                    b.Property<int>("productDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("productColor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<int>("productSize")
                        .HasColumnType("int");

                    b.HasKey("productDetailId");

                    b.ToTable("productDetails");
                });

            modelBuilder.Entity("shoe_project_server.Models.ProductImage", b =>
                {
                    b.Property<int>("productImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("producId")
                        .HasColumnType("int");

                    b.HasKey("productImageId");

                    b.ToTable("productImages");
                });

            modelBuilder.Entity("shoe_project_server.Models.PurchaseHistory", b =>
                {
                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<int>("productQuantity")
                        .HasColumnType("int");

                    b.HasKey("orderId", "userId");

                    b.ToTable("purchaseHistories");
                });
#pragma warning restore 612, 618
        }
    }
}