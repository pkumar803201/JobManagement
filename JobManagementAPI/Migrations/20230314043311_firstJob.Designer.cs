﻿// <auto-generated />
using System;
using JobManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobManagementAPI.Migrations
{
    [DbContext(typeof(JobDbContext))]
    [Migration("20230314043311_firstJob")]
    partial class firstJob
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JobManagementUI.Data.Job", b =>
                {
                    b.Property<int>("jobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("jobId"), 1L, 1);

                    b.Property<string>("FromEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("creator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pdfName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("scheduleDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("scheduleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("JobManagementUI.Data.recipientEmail", b =>
                {
                    b.Property<int>("mailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("mailId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("jobId")
                        .HasColumnType("int");

                    b.HasKey("mailId");

                    b.HasIndex("jobId");

                    b.ToTable("recipientEmail");
                });

            modelBuilder.Entity("JobManagementUI.Data.url", b =>
                {
                    b.Property<int>("urlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("urlId"), 1L, 1);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("jobId")
                        .HasColumnType("int");

                    b.HasKey("urlId");

                    b.HasIndex("jobId");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("JobManagementUI.Data.recipientEmail", b =>
                {
                    b.HasOne("JobManagementUI.Data.Job", "job")
                        .WithMany()
                        .HasForeignKey("jobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("job");
                });

            modelBuilder.Entity("JobManagementUI.Data.url", b =>
                {
                    b.HasOne("JobManagementUI.Data.Job", "job")
                        .WithMany()
                        .HasForeignKey("jobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("job");
                });
#pragma warning restore 612, 618
        }
    }
}
