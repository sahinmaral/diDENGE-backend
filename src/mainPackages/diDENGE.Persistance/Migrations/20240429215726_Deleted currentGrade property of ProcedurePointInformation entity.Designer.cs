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
    [Migration("20240429215726_Deleted currentGrade property of ProcedurePointInformation entity")]
    partial class DeletedcurrentGradepropertyofProcedurePointInformationentity
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
                            Id = "99a4d7a6-d5ac-41cf-bc11-e1187f11d8c0",
                            ConcurrencyStamp = "02655f16-a57b-4213-9154-f78f7d39a48e",
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
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DailyLimit = 0.0,
                            MaximumGrade = 73.0,
                            MinimumGrade = 41.0,
                            Name = "Bağımlılık Yok"
                        },
                        new
                        {
                            Id = "610ce001-62a1-40bb-8edb-886959be71f1",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DailyLimit = 60.0,
                            MaximumGrade = 106.0,
                            MinimumGrade = 74.0,
                            Name = "Az Bağımlı"
                        },
                        new
                        {
                            Id = "4ac95367-eda8-49f2-9894-27421cbe256f",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DailyLimit = 90.0,
                            MaximumGrade = 139.0,
                            MinimumGrade = 107.0,
                            Name = "Orta Bağımlı"
                        },
                        new
                        {
                            Id = "f4b20091-1884-470a-8f05-6b25eba12a42",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DailyLimit = 120.0,
                            MaximumGrade = 172.0,
                            MinimumGrade = 140.0,
                            Name = "Yüksek Bağımlı"
                        },
                        new
                        {
                            Id = "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
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

                    b.HasData(
                        new
                        {
                            Id = "d5cbddb9-e315-4c56-8ef7-bcaeb68e7b9b",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Takdir"
                        },
                        new
                        {
                            Id = "d2337816-2312-44e0-8e6b-dab47a7ca01d",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Hatırlatıcı"
                        },
                        new
                        {
                            Id = "a28a5be9-e694-40e8-8a31-9c282d61157d",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Uyarı"
                        });
                });

            modelBuilder.Entity("diDENGE.Domain.Entities.ProcedurePointInformation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddictionLevelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

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
                            Id = "51984c42-0ac8-4539-b58e-00cd48a7fe34",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Whatsapp",
                            PlaystoreId = "com.whatsapp"
                        },
                        new
                        {
                            Id = "164b41e0-7434-408c-a72e-dd84545fc266",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Instagram",
                            PlaystoreId = "com.instagram.android"
                        },
                        new
                        {
                            Id = "e5c9cae4-2d4c-45d3-8a82-43ea107f9dcb",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Facebook",
                            PlaystoreId = "com.facebook.katana"
                        },
                        new
                        {
                            Id = "b7f30572-da99-428b-8467-92a24212f365",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Twitter",
                            PlaystoreId = "com.twitter.android"
                        },
                        new
                        {
                            Id = "d625b39b-43a9-416d-b229-b0d3cf981c0f",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Snapchat",
                            PlaystoreId = "com.snapchat.android"
                        },
                        new
                        {
                            Id = "78d21b42-34cf-4180-b0b6-39661df16f5d",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Youtube",
                            PlaystoreId = "com.google.android.youtube"
                        },
                        new
                        {
                            Id = "9a9e9ff4-93db-4b0b-afe1-370723f3664f",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "LinkedIn",
                            PlaystoreId = "com.linkedin.android"
                        },
                        new
                        {
                            Id = "4d451c71-a3ac-4baf-bdd1-f31cce5d3bd0",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Telegram",
                            PlaystoreId = "org.telegram.messenger"
                        },
                        new
                        {
                            Id = "7d7f61d1-7626-4899-918f-cf47f6c7853a",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pinterest",
                            PlaystoreId = "com.pinterest"
                        },
                        new
                        {
                            Id = "8a1a3a89-6a11-4a80-a3b3-365725493e4f",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
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
                            Id = "d8a7a6a5-1658-46af-8964-05ab7243be43",
                            Content = "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "a2f7fdae-ef64-47e0-a344-a47ff144b9f2",
                            Content = "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "1de8bede-f92b-4a94-8af3-6b15fe86dea1",
                            Content = "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "978ac017-ebd5-4b96-92c3-821560081e98",
                            Content = "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "b1e7e772-4b93-4765-a50f-86d083f92da5",
                            Content = "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "7de044c6-9d6e-4b75-b5e2-17211abdb9b3",
                            Content = "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "66cc2e47-7253-43a8-9760-84fa7a74b57c",
                            Content = "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "e44af59a-a282-42ab-beea-39e7ae581e25",
                            Content = "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "9811bd23-26c8-42eb-a33b-411861f576f1",
                            Content = "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "4ab2ae6f-2be4-4a6b-a884-d0b8bda3fe31",
                            Content = "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.",
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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
