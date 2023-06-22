﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Data;

#nullable disable

namespace test.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230622110610_Create_Table_LopHoc")]
    partial class Create_Table_LopHoc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("Test.Models.LopHoc", b =>
                {
                    b.Property<string>("MaLop")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaLop");

                    b.ToTable("LopHocs");
                });
#pragma warning restore 612, 618
        }
    }
}
