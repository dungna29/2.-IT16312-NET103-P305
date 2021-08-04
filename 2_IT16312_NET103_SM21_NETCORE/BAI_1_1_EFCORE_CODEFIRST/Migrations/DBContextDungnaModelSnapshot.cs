﻿// <auto-generated />
using System;
using BAI_1_1_EFCORE_CODEFIRST.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BAI_1_1_EFCORE_CODEFIRST.Migrations
{
    [DbContext(typeof(DBContextDungna))]
    partial class DBContextDungnaModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Acc")
                        .HasMaxLength(29)
                        .HasColumnType("nvarchar(29)");

                    b.Property<string>("Pass")
                        .HasMaxLength(29)
                        .HasColumnType("nvarchar(29)");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Sex")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("YearofBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.CourseStudent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCourse")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdStudent")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCourse");

                    b.HasIndex("IdStudent");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(29)
                        .HasColumnType("nvarchar(29)");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(29)
                        .HasColumnType("nvarchar(29)");

                    b.Property<string>("Name")
                        .HasMaxLength(29)
                        .HasColumnType("nvarchar(29)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Acc")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.Account", b =>
                {
                    b.HasOne("BAI_1_1_EFCORE_CODEFIRST.Models.Role", "Roles")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.CourseStudent", b =>
                {
                    b.HasOne("BAI_1_1_EFCORE_CODEFIRST.Models.Course", "Courses")
                        .WithMany()
                        .HasForeignKey("IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAI_1_1_EFCORE_CODEFIRST.Models.Student", "Students")
                        .WithMany()
                        .HasForeignKey("IdStudent");

                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.Order", b =>
                {
                    b.HasOne("BAI_1_1_EFCORE_CODEFIRST.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BAI_1_1_EFCORE_CODEFIRST.Models.OrderDetail", b =>
                {
                    b.HasOne("BAI_1_1_EFCORE_CODEFIRST.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("BAI_1_1_EFCORE_CODEFIRST.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
