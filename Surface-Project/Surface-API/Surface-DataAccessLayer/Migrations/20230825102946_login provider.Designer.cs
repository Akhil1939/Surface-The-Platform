﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Surface_Entities.Context;

#nullable disable

namespace Surface_DataAccessLayer.Migrations
{
    [DbContext(typeof(SurfaceContext))]
    [Migration("20230825102946_login provider")]
    partial class loginprovider
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Surface.Entities.DataModels.LoginProvider", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)1);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("StatusId");

                    b.ToTable("LoginProviders");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            CreatedOn = new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7140),
                            ModifiedOn = new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7140),
                            Name = "Custom",
                            StatusId = (byte)1
                        },
                        new
                        {
                            Id = (byte)2,
                            CreatedOn = new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7142),
                            ModifiedOn = new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7142),
                            Name = "Google",
                            StatusId = (byte)1
                        });
                });

            modelBuilder.Entity("Surface.Entities.DataModels.Status", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("StatusGroupId")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("StatusGroupId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3713),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3716),
                            Name = "Active",
                            StatusGroupId = (byte)1
                        },
                        new
                        {
                            Id = (byte)2,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3718),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3718),
                            Name = "Inactive",
                            StatusGroupId = (byte)1
                        },
                        new
                        {
                            Id = (byte)3,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3720),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3720),
                            Name = "Reported",
                            StatusGroupId = (byte)1
                        },
                        new
                        {
                            Id = (byte)4,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3722),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3722),
                            Name = "Blocked",
                            StatusGroupId = (byte)1
                        },
                        new
                        {
                            Id = (byte)5,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3724),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3724),
                            Name = "Deleted",
                            StatusGroupId = (byte)1
                        },
                        new
                        {
                            Id = (byte)6,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3766),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3767),
                            Name = "Locked",
                            StatusGroupId = (byte)1
                        },
                        new
                        {
                            Id = (byte)7,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3769),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3769),
                            Name = "Planning",
                            StatusGroupId = (byte)2
                        },
                        new
                        {
                            Id = (byte)8,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3772),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3772),
                            Name = "Active",
                            StatusGroupId = (byte)2
                        },
                        new
                        {
                            Id = (byte)9,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3773),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3774),
                            Name = "On Hold",
                            StatusGroupId = (byte)2
                        },
                        new
                        {
                            Id = (byte)10,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3775),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3776),
                            Name = "Completed",
                            StatusGroupId = (byte)2
                        },
                        new
                        {
                            Id = (byte)11,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3777),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3778),
                            Name = "Cancelled",
                            StatusGroupId = (byte)2
                        },
                        new
                        {
                            Id = (byte)12,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3779),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3780),
                            Name = "To Do",
                            StatusGroupId = (byte)3
                        },
                        new
                        {
                            Id = (byte)13,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3781),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3782),
                            Name = "In Progress",
                            StatusGroupId = (byte)3
                        },
                        new
                        {
                            Id = (byte)14,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3783),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3784),
                            Name = "Blocked",
                            StatusGroupId = (byte)3
                        },
                        new
                        {
                            Id = (byte)15,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3785),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3786),
                            Name = "Completed",
                            StatusGroupId = (byte)3
                        },
                        new
                        {
                            Id = (byte)16,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3787),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3788),
                            Name = "Deferred",
                            StatusGroupId = (byte)3
                        },
                        new
                        {
                            Id = (byte)17,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3789),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3789),
                            Name = "Idea",
                            StatusGroupId = (byte)4
                        },
                        new
                        {
                            Id = (byte)18,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3791),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3791),
                            Name = "Backlog",
                            StatusGroupId = (byte)4
                        },
                        new
                        {
                            Id = (byte)19,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3793),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3793),
                            Name = "In Progress",
                            StatusGroupId = (byte)4
                        },
                        new
                        {
                            Id = (byte)20,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3795),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3795),
                            Name = "Testing",
                            StatusGroupId = (byte)4
                        },
                        new
                        {
                            Id = (byte)21,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3797),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3797),
                            Name = "Released",
                            StatusGroupId = (byte)4
                        },
                        new
                        {
                            Id = (byte)22,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3798),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3799),
                            Name = "Reported",
                            StatusGroupId = (byte)5
                        },
                        new
                        {
                            Id = (byte)23,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3800),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3801),
                            Name = "In Progress",
                            StatusGroupId = (byte)5
                        },
                        new
                        {
                            Id = (byte)24,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3803),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3803),
                            Name = "Reproduced",
                            StatusGroupId = (byte)5
                        },
                        new
                        {
                            Id = (byte)25,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3805),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3805),
                            Name = "Fixed",
                            StatusGroupId = (byte)5
                        },
                        new
                        {
                            Id = (byte)26,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3807),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3807),
                            Name = "Verified",
                            StatusGroupId = (byte)5
                        });
                });

            modelBuilder.Entity("Surface.Entities.DataModels.StatusGroup", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StatusGroups");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1878),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1887),
                            Name = "User"
                        },
                        new
                        {
                            Id = (byte)2,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1890),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1891),
                            Name = "Project"
                        },
                        new
                        {
                            Id = (byte)3,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1892),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1893),
                            Name = "Task"
                        },
                        new
                        {
                            Id = (byte)4,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1894),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1895),
                            Name = "Feature"
                        },
                        new
                        {
                            Id = (byte)5,
                            CreatedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1896),
                            ModifiedOn = new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1896),
                            Name = "Bug"
                        });
                });

            modelBuilder.Entity("Surface.Entities.DataModels.LoginProvider", b =>
                {
                    b.HasOne("Surface.Entities.DataModels.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Surface.Entities.DataModels.Status", b =>
                {
                    b.HasOne("Surface.Entities.DataModels.StatusGroup", "StatusGroup")
                        .WithMany()
                        .HasForeignKey("StatusGroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("StatusGroup");
                });
#pragma warning restore 612, 618
        }
    }
}