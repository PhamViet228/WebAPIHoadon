﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIHoadon.Models;

namespace WebAPIHoadon.Migrations
{
    [DbContext(typeof(hoadonContext))]
    partial class hoadonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebAPIHoadon.Models.Chitiethoadon", b =>
                {
                    b.Property<string>("Sohd")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("sohd");

                    b.Property<string>("Mahang")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("mahang");

                    b.Property<double?>("Dongia")
                        .HasColumnType("float")
                        .HasColumnName("dongia");

                    b.Property<int?>("Soluong")
                        .HasColumnType("int")
                        .HasColumnName("soluong");

                    b.HasKey("Sohd", "Mahang");

                    b.HasIndex("Mahang");

                    b.ToTable("chitiethoadon");
                });

            modelBuilder.Entity("WebAPIHoadon.Models.Hanghoa", b =>
                {
                    b.Property<string>("Mahang")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("mahang");

                    b.Property<double?>("Dongia")
                        .HasColumnType("float")
                        .HasColumnName("dongia");

                    b.Property<string>("Dvt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("dvt");

                    b.Property<string>("Tenhang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenhang");

                    b.HasKey("Mahang");

                    b.ToTable("hanghoa");
                });

            modelBuilder.Entity("WebAPIHoadon.Models.Hoadon", b =>
                {
                    b.Property<string>("Sohd")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("sohd");

                    b.Property<DateTime?>("Ngaylaphd")
                        .HasColumnType("datetime")
                        .HasColumnName("ngaylaphd");

                    b.Property<string>("Tenkh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenkh");

                    b.HasKey("Sohd");

                    b.ToTable("hoadon");
                });

            modelBuilder.Entity("WebAPIHoadon.Models.Chitiethoadon", b =>
                {
                    b.HasOne("WebAPIHoadon.Models.Hanghoa", "MahangNavigation")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("Mahang")
                        .HasConstraintName("FK_chitiethoadon_hanghoa")
                        .IsRequired();

                    b.HasOne("WebAPIHoadon.Models.Hoadon", "SohdNavigation")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("Sohd")
                        .HasConstraintName("FK_chitiethoadon_hoadon")
                        .IsRequired();

                    b.Navigation("MahangNavigation");

                    b.Navigation("SohdNavigation");
                });

            modelBuilder.Entity("WebAPIHoadon.Models.Hanghoa", b =>
                {
                    b.Navigation("Chitiethoadons");
                });

            modelBuilder.Entity("WebAPIHoadon.Models.Hoadon", b =>
                {
                    b.Navigation("Chitiethoadons");
                });
#pragma warning restore 612, 618
        }
    }
}