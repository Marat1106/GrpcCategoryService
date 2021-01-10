﻿// <auto-generated />
using System;
using GrpcService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GrpcService.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210110113831_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GrpcService.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GrpcService.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ProductCategoryid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("ProductCategoryid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("GrpcService.Models.Product", b =>
                {
                    b.HasOne("GrpcService.Models.Category", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryid");
                });
#pragma warning restore 612, 618
        }
    }
}
