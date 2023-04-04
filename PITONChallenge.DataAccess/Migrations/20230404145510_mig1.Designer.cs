﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PITONChallenge.DataAccess;

#nullable disable

namespace PITONChallenge.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230404145510_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PITONChallenge.Entity.Concrete.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MissionCategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("MissionGoalTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MissionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MissionCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("PITONChallenge.Entity.Concrete.MissionCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MissionCategories");
                });

            modelBuilder.Entity("PITONChallenge.Entity.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PITONChallenge.Entity.Concrete.Mission", b =>
                {
                    b.HasOne("PITONChallenge.Entity.Concrete.MissionCategory", "MissionCategory")
                        .WithMany("Mission")
                        .HasForeignKey("MissionCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PITONChallenge.Entity.Concrete.User", "User")
                        .WithMany("Mission")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MissionCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PITONChallenge.Entity.Concrete.MissionCategory", b =>
                {
                    b.Navigation("Mission");
                });

            modelBuilder.Entity("PITONChallenge.Entity.Concrete.User", b =>
                {
                    b.Navigation("Mission");
                });
#pragma warning restore 612, 618
        }
    }
}
