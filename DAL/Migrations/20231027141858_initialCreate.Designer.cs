﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(WSContext))]
    [Migration("20231027141858_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("models.model.Tutorial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tutorialType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tutorials");
                });

            modelBuilder.Entity("models.model.TutorialStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("TutorialId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TutorialId");

                    b.ToTable("TutorialSteps");
                });

            modelBuilder.Entity("models.model.Workshop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("subscriberLimit")
                        .HasColumnType("int");

                    b.Property<int>("tutorialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("tutorialId")
                        .IsUnique();

                    b.ToTable("Workshops");
                });

            modelBuilder.Entity("models.model.TutorialStep", b =>
                {
                    b.HasOne("models.model.Tutorial", null)
                        .WithMany("steps")
                        .HasForeignKey("TutorialId");
                });

            modelBuilder.Entity("models.model.Workshop", b =>
                {
                    b.HasOne("models.model.Tutorial", "tutorial")
                        .WithOne()
                        .HasForeignKey("models.model.Workshop", "tutorialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tutorial");
                });

            modelBuilder.Entity("models.model.Tutorial", b =>
                {
                    b.Navigation("steps");
                });
#pragma warning restore 612, 618
        }
    }
}
