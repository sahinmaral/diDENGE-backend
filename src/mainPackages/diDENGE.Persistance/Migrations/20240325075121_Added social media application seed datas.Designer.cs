﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using diDENGE.Persistance.Context;

#nullable disable

namespace diDENGE.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240325075121_Added social media application seed datas")]
    partial class Addedsocialmediaapplicationseeddatas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Security.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c9dd1587-7e07-49e1-8c88-39121243f142",
                            ConcurrencyStamp = "7d6b8c49-349e-48a6-947d-dcaedcf8afe2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNewUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePhotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.AddictionLevel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("DailyLimit")
                        .HasColumnType("float");

                    b.Property<double>("MaximumGrade")
                        .HasColumnType("float");

                    b.Property<double>("MinimumGrade")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AddictionLevels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "95cec253-2a7e-4466-b7e2-8aef25c437f6",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9169),
                            DailyLimit = 0.0,
                            MaximumGrade = 73.0,
                            MinimumGrade = 41.0,
                            Name = "Bağımlılık Yok"
                        },
                        new
                        {
                            Id = "610ce001-62a1-40bb-8edb-886959be71f1",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9222),
                            DailyLimit = 60.0,
                            MaximumGrade = 106.0,
                            MinimumGrade = 74.0,
                            Name = "Az Bağımlı"
                        },
                        new
                        {
                            Id = "4ac95367-eda8-49f2-9894-27421cbe256f",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9246),
                            DailyLimit = 90.0,
                            MaximumGrade = 139.0,
                            MinimumGrade = 107.0,
                            Name = "Orta Bağımlı"
                        },
                        new
                        {
                            Id = "f4b20091-1884-470a-8f05-6b25eba12a42",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9266),
                            DailyLimit = 120.0,
                            MaximumGrade = 172.0,
                            MinimumGrade = 140.0,
                            Name = "Yüksek Bağımlı"
                        },
                        new
                        {
                            Id = "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9285),
                            DailyLimit = 150.0,
                            MaximumGrade = 205.0,
                            MinimumGrade = 173.0,
                            Name = "Çok Yüksek Bağımlı"
                        });
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.Procedure", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Procedures", (string)null);
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.ProcedurePointInformation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddictionLevelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("CurrentGrade")
                        .HasColumnType("float");

                    b.Property<double>("OverallGrade")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AddictionLevelId");

                    b.HasIndex("UserId");

                    b.ToTable("ProcedurePointInformations", (string)null);
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.SocialMediaApplication", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaystoreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SocialMediaApplications", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3d8d1f5a-d644-42df-895b-ce599e5c6d12",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8626),
                            Name = "Whatsapp",
                            PlaystoreId = "com.whatsapp"
                        },
                        new
                        {
                            Id = "d527300b-7c26-41ac-bfb9-631816017197",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8687),
                            Name = "Instagram",
                            PlaystoreId = "com.instagram.android"
                        },
                        new
                        {
                            Id = "37de582b-d425-4f0c-8070-7ac2b41d4530",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8716),
                            Name = "Facebook",
                            PlaystoreId = "com.facebook.katana"
                        },
                        new
                        {
                            Id = "c04f044b-9263-4704-8b31-73fac08e1648",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8735),
                            Name = "Twitter",
                            PlaystoreId = "com.twitter.android"
                        },
                        new
                        {
                            Id = "23b08efb-2a72-42e8-9ef0-d275db95ec81",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8764),
                            Name = "Snapchat",
                            PlaystoreId = "com.snapchat.android"
                        },
                        new
                        {
                            Id = "ab7b5a8e-0ceb-427e-83fd-a20855af564b",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8797),
                            Name = "Youtube",
                            PlaystoreId = "com.google.android.youtube"
                        },
                        new
                        {
                            Id = "d1887587-9d24-426f-8c1f-a45eb4aee3be",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8821),
                            Name = "LinkedIn",
                            PlaystoreId = "com.linkedin.android"
                        },
                        new
                        {
                            Id = "de5640ee-b119-4f45-99c8-6f916c32a6bd",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8850),
                            Name = "Telegram",
                            PlaystoreId = "org.telegram.messenger"
                        },
                        new
                        {
                            Id = "a7bcfed8-389c-4109-9fe8-f85cb4c077a4",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8878),
                            Name = "Pinterest",
                            PlaystoreId = "com.pinterest"
                        },
                        new
                        {
                            Id = "882c9990-4f7f-46dc-ad36-2091edf23336",
                            CreatedAt = new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8934),
                            Name = "TikTok",
                            PlaystoreId = "com.zhiliaoapp.musically"
                        });
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.SocialMediaApplicationUsage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddictionLevelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OpeningCount")
                        .HasColumnType("int");

                    b.Property<double>("SpentTime")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AddictionLevelId");

                    b.HasIndex("UserId");

                    b.ToTable("SocialMediaApplicationUsages", (string)null);
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.UserAddictionLevel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddictionLevelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AddictionLevelId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAddictionLevels", (string)null);
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.WordOfTheDay", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WordOfTheDays", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Core.Security.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Core.Security.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Security.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.ProcedurePointInformation", b =>
                {
                    b.HasOne("diDENGE.Domain.Entities.AddictionLevel", "AddictionLevel")
                        .WithMany()
                        .HasForeignKey("AddictionLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddictionLevel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.SocialMediaApplicationUsage", b =>
                {
                    b.HasOne("diDENGE.Domain.Entities.AddictionLevel", "AddictionLevel")
                        .WithMany()
                        .HasForeignKey("AddictionLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddictionLevel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.UserAddictionLevel", b =>
                {
                    b.HasOne("diDENGE.Domain.Entities.AddictionLevel", "AddictionLevel")
                        .WithMany()
                        .HasForeignKey("AddictionLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddictionLevel");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
