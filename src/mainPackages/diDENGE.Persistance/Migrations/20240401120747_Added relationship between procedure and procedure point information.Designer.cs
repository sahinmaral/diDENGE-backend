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
    [Migration("20240401120747_Added relationship between procedure and procedure point information")]
    partial class Addedrelationshipbetweenprocedureandprocedurepointinformation
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
                            Id = "b2bc0810-4260-4624-8e27-6beb2e795a1d",
                            ConcurrencyStamp = "b5b087ee-faf9-4e5a-8680-10bcccd5ab3f",
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
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7250),
                            DailyLimit = 0.0,
                            MaximumGrade = 73.0,
                            MinimumGrade = 41.0,
                            Name = "Bağımlılık Yok"
                        },
                        new
                        {
                            Id = "610ce001-62a1-40bb-8edb-886959be71f1",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7317),
                            DailyLimit = 60.0,
                            MaximumGrade = 106.0,
                            MinimumGrade = 74.0,
                            Name = "Az Bağımlı"
                        },
                        new
                        {
                            Id = "4ac95367-eda8-49f2-9894-27421cbe256f",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7337),
                            DailyLimit = 90.0,
                            MaximumGrade = 139.0,
                            MinimumGrade = 107.0,
                            Name = "Orta Bağımlı"
                        },
                        new
                        {
                            Id = "f4b20091-1884-470a-8f05-6b25eba12a42",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7351),
                            DailyLimit = 120.0,
                            MaximumGrade = 172.0,
                            MinimumGrade = 140.0,
                            Name = "Yüksek Bağımlı"
                        },
                        new
                        {
                            Id = "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7375),
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

                    b.Property<string>("ProcedureId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AddictionLevelId");

                    b.HasIndex("ProcedureId");

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
                            Id = "bd078f30-e9e4-4b63-8edb-8ca944aaa829",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9289),
                            Name = "Whatsapp",
                            PlaystoreId = "com.whatsapp"
                        },
                        new
                        {
                            Id = "06450876-9517-4d9b-b285-cf35971bc01a",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9398),
                            Name = "Instagram",
                            PlaystoreId = "com.instagram.android"
                        },
                        new
                        {
                            Id = "93f104fd-23cf-4bbb-9557-b18d322723b6",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9432),
                            Name = "Facebook",
                            PlaystoreId = "com.facebook.katana"
                        },
                        new
                        {
                            Id = "40d7d007-ab5e-4af0-8bc0-45a1bdc29171",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9465),
                            Name = "Twitter",
                            PlaystoreId = "com.twitter.android"
                        },
                        new
                        {
                            Id = "9169c110-cc72-4003-8b48-eb3539ff1eb2",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9494),
                            Name = "Snapchat",
                            PlaystoreId = "com.snapchat.android"
                        },
                        new
                        {
                            Id = "f2770b5d-c32c-4e9b-a137-396ae2c35a70",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9527),
                            Name = "Youtube",
                            PlaystoreId = "com.google.android.youtube"
                        },
                        new
                        {
                            Id = "fb0df336-3372-4b7c-88ae-c46ae9752de4",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9559),
                            Name = "LinkedIn",
                            PlaystoreId = "com.linkedin.android"
                        },
                        new
                        {
                            Id = "2cee6fcf-5a3b-4518-b984-6c21ebfec409",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9592),
                            Name = "Telegram",
                            PlaystoreId = "org.telegram.messenger"
                        },
                        new
                        {
                            Id = "28c7f96b-8209-4cc2-94e3-6413900bea34",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9611),
                            Name = "Pinterest",
                            PlaystoreId = "com.pinterest"
                        },
                        new
                        {
                            Id = "917e89dd-8550-4be9-a06a-1e90197c9747",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9649),
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

                    b.HasData(
                        new
                        {
                            Id = "72b70685-e7b0-4aaf-8de6-9de097f566a4",
                            Content = "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(519)
                        },
                        new
                        {
                            Id = "e949ec38-e151-4f5c-a125-0ef512926ebf",
                            Content = "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(602)
                        },
                        new
                        {
                            Id = "1917bb65-ba01-4869-98c1-311742b3f406",
                            Content = "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(635)
                        },
                        new
                        {
                            Id = "c251806f-8ec2-4406-a6e1-c3e3a1da0c10",
                            Content = "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(663)
                        },
                        new
                        {
                            Id = "57a3a6cc-2e7d-468f-ae7a-485f317b9dff",
                            Content = "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(692)
                        },
                        new
                        {
                            Id = "663f7517-f62a-4716-962e-3a664acc74ef",
                            Content = "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(721)
                        },
                        new
                        {
                            Id = "d0651fb3-5a8e-4928-aa15-07db6af84325",
                            Content = "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(749)
                        },
                        new
                        {
                            Id = "efe31465-5895-4f26-a230-63eb3ea84e45",
                            Content = "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(777)
                        },
                        new
                        {
                            Id = "3fb1047b-3928-4ce1-980e-e76ef3eaac05",
                            Content = "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(806)
                        },
                        new
                        {
                            Id = "bdd29a4a-982f-4e9f-b825-89bf436c071c",
                            Content = "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.",
                            CreatedAt = new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(834)
                        });
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

                    b.HasOne("diDENGE.Domain.Entities.Procedure", "Procedure")
                        .WithMany()
                        .HasForeignKey("ProcedureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddictionLevel");

                    b.Navigation("Procedure");

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
