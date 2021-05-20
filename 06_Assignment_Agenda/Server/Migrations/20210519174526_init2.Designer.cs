﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _06_Assignment_Agenda.Server.Data;

namespace _06_Assignment_Agenda.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210519174526_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_06_Assignment_Agenda.Shared.Activity", b =>
                {
                    b.Property<Guid>("ActivityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CalendarID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ActivityID");

                    b.HasIndex("CalendarID");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("_06_Assignment_Agenda.Shared.Calendar", b =>
                {
                    b.Property<Guid>("CalendarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CalendarID");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("_06_Assignment_Agenda.Shared.Person", b =>
                {
                    b.Property<Guid>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CalendarID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("_06_Assignment_Agenda.Shared.Activity", b =>
                {
                    b.HasOne("_06_Assignment_Agenda.Shared.Calendar", null)
                        .WithMany("Activities")
                        .HasForeignKey("CalendarID");
                });

            modelBuilder.Entity("_06_Assignment_Agenda.Shared.Calendar", b =>
                {
                    b.Navigation("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
