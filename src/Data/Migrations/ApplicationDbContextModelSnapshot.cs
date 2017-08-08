﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OnyxSAT.Data;
using System;

namespace OnyxSAT.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-preview2-25794");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OnyxSAT.Models.Attendance", b =>
                {
                    b.Property<DateTime>("DateTime");

                    b.Property<int>("CardNumber");

                    b.Property<DateTime>("SessionDateTime");

                    b.Property<bool>("Verified");

                    b.HasKey("DateTime");

                    b.HasIndex("CardNumber");

                    b.HasIndex("SessionDateTime");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("OnyxSAT.Models.Card", b =>
                {
                    b.Property<int>("CardNumber");

                    b.Property<string>("StudentId");

                    b.HasKey("CardNumber");

                    b.HasIndex("StudentId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("OnyxSAT.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseCode");

                    b.Property<string>("DayOfWeek")
                        .IsRequired();

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Period");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("TeacherId");

                    b.Property<string>("UnitCode");

                    b.Property<DateTime>("Year");

                    b.HasKey("ClassId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("Period", "Year");

                    b.HasIndex("UnitCode", "CourseCode");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("OnyxSAT.Models.Course", b =>
                {
                    b.Property<string>("CourseCode");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CourseCode");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("OnyxSAT.Models.CourseUnit", b =>
                {
                    b.Property<string>("UnitCode");

                    b.Property<string>("CourseCode");

                    b.HasKey("UnitCode", "CourseCode");

                    b.HasIndex("CourseCode");

                    b.ToTable("CourseUnits");
                });

            modelBuilder.Entity("OnyxSAT.Models.Enrolment", b =>
                {
                    b.Property<int>("EnrolmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassId");

                    b.Property<string>("Status");

                    b.Property<string>("StudentId");

                    b.HasKey("EnrolmentId");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrolments");
                });

            modelBuilder.Entity("OnyxSAT.Models.Location", b =>
                {
                    b.Property<string>("RoomNumber");

                    b.Property<string>("ScannerNumber");

                    b.HasKey("RoomNumber");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("OnyxSAT.Models.Session", b =>
                {
                    b.Property<DateTime>("DateTime");

                    b.Property<string>("RoomNumber");

                    b.HasKey("DateTime");

                    b.HasIndex("RoomNumber");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("OnyxSAT.Models.TeachingPeriod", b =>
                {
                    b.Property<string>("Period");

                    b.Property<DateTime>("Year");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Period", "Year");

                    b.ToTable("TeachingPeriods");
                });

            modelBuilder.Entity("OnyxSAT.Models.Unit", b =>
                {
                    b.Property<string>("UnitCode");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("UnitCode");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("OnyxSAT.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime?>("Birthdate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("OnyxSAT.Models.Student", b =>
                {
                    b.HasBaseType("OnyxSAT.Models.User");

                    b.Property<int>("StudentId");

                    b.ToTable("Student");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("OnyxSAT.Models.Teacher", b =>
                {
                    b.HasBaseType("OnyxSAT.Models.User");

                    b.Property<int>("StaffId");

                    b.ToTable("Teacher");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnyxSAT.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnyxSAT.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnyxSAT.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnyxSAT.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnyxSAT.Models.Attendance", b =>
                {
                    b.HasOne("OnyxSAT.Models.Card", "Card")
                        .WithMany("Attendances")
                        .HasForeignKey("CardNumber")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnyxSAT.Models.Session", "Session")
                        .WithMany("Attendances")
                        .HasForeignKey("SessionDateTime")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnyxSAT.Models.Card", b =>
                {
                    b.HasOne("OnyxSAT.Models.Student", "Student")
                        .WithMany("Cards")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("OnyxSAT.Models.Class", b =>
                {
                    b.HasOne("OnyxSAT.Models.Teacher", "Teacher")
                        .WithMany("Classes")
                        .HasForeignKey("TeacherId");

                    b.HasOne("OnyxSAT.Models.TeachingPeriod", "TeachingPeriod")
                        .WithMany("Classes")
                        .HasForeignKey("Period", "Year");

                    b.HasOne("OnyxSAT.Models.CourseUnit", "CourseUnit")
                        .WithMany("Classes")
                        .HasForeignKey("UnitCode", "CourseCode");
                });

            modelBuilder.Entity("OnyxSAT.Models.CourseUnit", b =>
                {
                    b.HasOne("OnyxSAT.Models.Course", "Course")
                        .WithMany("CourseUnits")
                        .HasForeignKey("CourseCode")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnyxSAT.Models.Unit", "Unit")
                        .WithMany("CourseUnits")
                        .HasForeignKey("UnitCode")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnyxSAT.Models.Enrolment", b =>
                {
                    b.HasOne("OnyxSAT.Models.Class", "Class")
                        .WithMany("Enrolments")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnyxSAT.Models.Student", "Student")
                        .WithMany("Enrolments")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("OnyxSAT.Models.Session", b =>
                {
                    b.HasOne("OnyxSAT.Models.Location", "Location")
                        .WithMany("Sessions")
                        .HasForeignKey("RoomNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
