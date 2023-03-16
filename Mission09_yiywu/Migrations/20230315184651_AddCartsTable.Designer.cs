﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission09_yiywu.Models;

namespace Mission09_yiywu.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20230315184651_AddCartsTable")]
    partial class AddCartsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission09_yiywu.Models.BasketLineItem", b =>
                {
                    b.Property<int>("LineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("BooksBookId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("cartId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineID");

                    b.HasIndex("BooksBookId");

                    b.HasIndex("cartId");

                    b.ToTable("BasketLineItem");
                });

            modelBuilder.Entity("Mission09_yiywu.Models.Books", b =>
                {
                    b.Property<long>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Classification")
                        .HasColumnType("TEXT");

                    b.Property<string>("Isbn")
                        .HasColumnType("TEXT");

                    b.Property<long>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Mission09_yiywu.Models.Cart", b =>
                {
                    b.Property<int>("cartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Anonymous")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("cartId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Mission09_yiywu.Models.BasketLineItem", b =>
                {
                    b.HasOne("Mission09_yiywu.Models.Books", "Books")
                        .WithMany()
                        .HasForeignKey("BooksBookId");

                    b.HasOne("Mission09_yiywu.Models.Cart", null)
                        .WithMany("Lines")
                        .HasForeignKey("cartId");
                });
#pragma warning restore 612, 618
        }
    }
}