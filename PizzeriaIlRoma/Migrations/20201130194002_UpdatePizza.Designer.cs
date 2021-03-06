﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzeriaIlRoma.Models;

namespace PizzeriaIlRoma.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201130194002_UpdatePizza")]
    partial class UpdatePizza
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PizzeriaIlRoma.Models.Ingredient", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PizzaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PizzaID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("PizzeriaIlRoma.Models.Pizza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzeriaIlRoma.Models.Ingredient", b =>
                {
                    b.HasOne("PizzeriaIlRoma.Models.Pizza", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("PizzaID");
                });

            modelBuilder.Entity("PizzeriaIlRoma.Models.Pizza", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
