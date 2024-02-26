﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineLibrary.Data;

#nullable disable

namespace OnlineLibrary.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "5062ef3f-cfc1-4aa4-93c6-4aa086b93588",
                            RoleId = "60182f84-4a69-490b-9159-02657683eafe"
                        },
                        new
                        {
                            UserId = "3ffd4ba2-8fd2-4880-ada4-b401638c8819",
                            RoleId = "dca7f64f-ede7-4735-9e42-7cb3b20ad2d8"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OnlineLibrary.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("OnlineLibrary.Models.Book", b =>
                {
                    b.Property<int>("CodeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearPublished")
                        .HasColumnType("INTEGER");

                    b.HasKey("CodeNumber");

                    b.ToTable("Book", (string)null);

                    b.HasData(
                        new
                        {
                            CodeNumber = 1,
                            Author = "Andrew Chevallier",
                            Quantity = 1,
                            Title = "Encyclopedia of Herbal Medicine: 550 Herbs and Remedies for Common Ailments",
                            YearPublished = 2016
                        },
                        new
                        {
                            CodeNumber = 2,
                            Author = "Michael T. Murray M.D. and Joseph Pizzorno",
                            Quantity = 3,
                            Title = "The Encyclopedia of Natural Medicine Third Edition",
                            YearPublished = 2012
                        },
                        new
                        {
                            CodeNumber = 3,
                            Author = "Thomas Easley and Steven Horne",
                            Quantity = 1,
                            Title = "The Modern Herbal Dispensatory: A Medicine-Making Guide",
                            YearPublished = 2016
                        },
                        new
                        {
                            CodeNumber = 4,
                            Author = "Cat Ellis",
                            Quantity = 2,
                            Title = "Prepper's Natural Medicine: Life-Saving Herbs, Essential Oils and Natural Remedies for When There is No Doctor",
                            YearPublished = 2015
                        },
                        new
                        {
                            CodeNumber = 5,
                            Author = "Rosemary Gladstar",
                            Quantity = 1,
                            Title = "Rosemary Gladstar's Medicinal Herbs: A Beginner's Guide: 33 Healing Herbs to Know, Grow, and Use",
                            YearPublished = 2012
                        });
                });

            modelBuilder.Entity("OnlineLibrary.Models.BookTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookCodeNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Returned")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookCodeNumber");

                    b.HasIndex("UserId");

                    b.ToTable("BookTransaction", (string)null);
                });

            modelBuilder.Entity("OnlineLibrary.Models.CustomRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "60182f84-4a69-490b-9159-02657683eafe",
                            CreatedDate = new DateTime(2024, 2, 25, 23, 35, 36, 660, DateTimeKind.Local).AddTicks(9440),
                            Description = "Administrator Role",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "dca7f64f-ede7-4735-9e42-7cb3b20ad2d8",
                            CreatedDate = new DateTime(2024, 2, 25, 23, 35, 36, 660, DateTimeKind.Local).AddTicks(9490),
                            Description = "Member Role",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("OnlineLibrary.Models.CustomUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5062ef3f-cfc1-4aa4-93c6-4aa086b93588",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7065a878-7c87-407a-8f3c-e1f569aafbb4",
                            Email = "aa@aa.aa",
                            EmailConfirmed = true,
                            FirstName = "Adam",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "AA@AA.AA",
                            NormalizedUserName = "AA@AA.AA",
                            PasswordHash = "AQAAAAIAAYagAAAAEFoZIQ6sCw8kOzncONzFAT7FzPlgMAfkxSMW3B75mY5+vcbO5KxyR3au95HWv41EHQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "937732f6-3b3c-4036-be5a-e6d938490b77",
                            TwoFactorEnabled = false,
                            UserName = "aa@aa.aa"
                        },
                        new
                        {
                            Id = "3ffd4ba2-8fd2-4880-ada4-b401638c8819",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c4cb2058-d79d-4141-8473-ffa9e9e07656",
                            Email = "mm@mm.mm",
                            EmailConfirmed = true,
                            FirstName = "Mary",
                            LastName = "Martin",
                            LockoutEnabled = false,
                            NormalizedEmail = "MM@MM.MM",
                            NormalizedUserName = "MM@MM.MM",
                            PasswordHash = "AQAAAAIAAYagAAAAELT9z0bUSu6V+ne9V2jFsOvNMM4W5Kof7rlNm1HSszpChIiRsm5xHmpjjbWHK2d1pQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dfc06344-08cd-447c-9600-d08489fde2eb",
                            TwoFactorEnabled = false,
                            UserName = "mm@mm.mm"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("OnlineLibrary.Models.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnlineLibrary.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnlineLibrary.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("OnlineLibrary.Models.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineLibrary.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnlineLibrary.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineLibrary.Models.BookTransaction", b =>
                {
                    b.HasOne("OnlineLibrary.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookCodeNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineLibrary.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
