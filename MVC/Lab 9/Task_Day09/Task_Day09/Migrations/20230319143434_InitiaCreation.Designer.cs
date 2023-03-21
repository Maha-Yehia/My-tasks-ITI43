﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task_Day09.Models;

#nullable disable

namespace Task_Day09.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230319143434_InitiaCreation")]
    partial class InitiaCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Task_Day09.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TraineeID")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("TraineeID");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("Task_Day09.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrackId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TrackId");

                    b.ToTable("tracks");
                });

            modelBuilder.Entity("Task_Day09.Models.Trainee", b =>
                {
                    b.Property<int>("TraineeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraineeId"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("BirthDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("TrackID")
                        .HasColumnType("int");

                    b.Property<string>("TraineeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraineeId");

                    b.HasIndex("TrackID");

                    b.ToTable("trainees");
                });

            modelBuilder.Entity("Task_Day09.Models.Course", b =>
                {
                    b.HasOne("Task_Day09.Models.Trainee", "trainee")
                        .WithMany()
                        .HasForeignKey("TraineeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("trainee");
                });

            modelBuilder.Entity("Task_Day09.Models.Trainee", b =>
                {
                    b.HasOne("Task_Day09.Models.Track", "TrTrack")
                        .WithMany()
                        .HasForeignKey("TrackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrTrack");
                });
#pragma warning restore 612, 618
        }
    }
}
