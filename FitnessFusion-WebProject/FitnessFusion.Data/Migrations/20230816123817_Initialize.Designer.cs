﻿// <auto-generated />
using System;
using FitnessFusion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    [DbContext(typeof(FitnessFusionDbContext))]
    [Migration("20230816123817_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExerciseTrainingPlan", b =>
                {
                    b.Property<Guid>("ExercisesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TrainingPlansId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExercisesId", "TrainingPlansId");

                    b.HasIndex("TrainingPlansId");

                    b.ToTable("ExerciseTrainingPlan");
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentCaloriesGoal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EndSubscription")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsSubscribeValid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTrainer")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartSubscription")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

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

                    b.HasIndex("SubscriptionId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8b31291b-0f00-49aa-964d-e3242a0fd13e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f9899fdc-3727-420a-9537-51d09f5d9b09",
                            Email = "admin@fitnessfusion.bg",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            IsSubscribeValid = false,
                            IsTrainer = false,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@fitnessfusion.bg",
                            NormalizedUserName = "admin@fitnessfusion.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEJV0VfbPfal+C+gOqySlmoCnddE6kxIXuCYJVu5TWSEwAXonAM2qYM70ZV5iVK3l0A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4086a2a8-4ccc-430e-916b-ceda5be3ab94",
                            SubscriptionId = new Guid("ce8bb39f-685a-4c7f-9ccf-55b627121474"),
                            TwoFactorEnabled = false,
                            UserName = "admin@fitnessfusion.bg"
                        });
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MuscleGroup")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VideoLink")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("893cf870-d243-49c2-9ee4-491f5fcffc5a"),
                            Description = "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.",
                            Difficulty = 1,
                            ImagePath = "BenchPress.jfif",
                            MuscleGroup = 0,
                            Name = "Bench press",
                            VideoLink = "https://youtu.be/gRVjAtPip0Y"
                        },
                        new
                        {
                            Id = new Guid("05dedb58-0fca-480a-9a27-ced130aaf85d"),
                            Description = "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.",
                            Difficulty = 1,
                            ImagePath = "Squat.jfif",
                            MuscleGroup = 2,
                            Name = "Squat",
                            VideoLink = "https://youtu.be/MVMNk0HiTMg"
                        },
                        new
                        {
                            Id = new Guid("c655c316-1fc5-4687-80ff-5333bcbb5aa1"),
                            Description = "A pull-up is an upper-body exercise that involves hanging from a pull-up bar by your hands with your palms facing away from you, and lifting your entire body up with your arm and back muscles until your chest touches the bar.",
                            Difficulty = 1,
                            ImagePath = "PullUp.jfif",
                            MuscleGroup = 1,
                            Name = "Pull Up",
                            VideoLink = "https://youtu.be/poyr8KenUfc"
                        });
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.Meal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("CaloriesPer100g")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3035ab13-9f6a-49bb-8652-3cda29df512d"),
                            CaloriesPer100g = 300.0,
                            ImageUrl = "Musli.png",
                            MealType = 0,
                            Name = "TestBreakfast"
                        },
                        new
                        {
                            Id = new Guid("8ea6c2b1-ca97-47c8-9f22-fd616e7a31ce"),
                            CaloriesPer100g = 300.0,
                            ImageUrl = "Egg.png",
                            MealType = 1,
                            Name = "TestLunch"
                        },
                        new
                        {
                            Id = new Guid("97d2029a-d397-4f7b-9d77-a44922bc98b5"),
                            CaloriesPer100g = 300.0,
                            ImageUrl = "Egg.png",
                            MealType = 3,
                            Name = "TestDinner"
                        },
                        new
                        {
                            Id = new Guid("aad09e22-eab2-421e-85c2-1a98d55ef164"),
                            CaloriesPer100g = 300.0,
                            ImageUrl = "Egg.png",
                            MealType = 2,
                            Name = "TestSnack"
                        });
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("TypeOfSubscription")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce8bb39f-685a-4c7f-9ccf-55b627121474"),
                            Description = "Test description to subscription",
                            Image = "RandomImage",
                            Name = "Test Subscription",
                            Price = 30m,
                            TypeOfSubscription = 1
                        });
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.TrainingPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.ToTable("TrainingPlans");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.Trainer", b =>
                {
                    b.HasBaseType("FitnessFusion.Data.Models.ApplicationUser");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Trainer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d972ec1a-3fa7-48b6-aafa-11509efbd920"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "adf875c4-7e48-4ac1-850d-85735a81ef7f",
                            Email = "trainer@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Test",
                            IsSubscribeValid = false,
                            IsTrainer = true,
                            LastName = "Trainer",
                            LockoutEnabled = true,
                            NormalizedEmail = "TRAINER@ABV.BG",
                            NormalizedUserName = "TRAINER@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEGXxBCRRdnE+QnW+JI8zaaUvMrZ0I0JTOCECt8FSKco2gvcQ+YOlrwlHO03ij+4HfA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f321b542-d4d0-4eb0-afa7-38e09e666a92",
                            TwoFactorEnabled = false,
                            UserName = "trainer@abv.bg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus."
                        });
                });

            modelBuilder.Entity("ExerciseTrainingPlan", b =>
                {
                    b.HasOne("FitnessFusion.Data.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessFusion.Data.Models.TrainingPlan", null)
                        .WithMany()
                        .HasForeignKey("TrainingPlansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("FitnessFusion.Data.Models.Subscription", "Subscription")
                        .WithMany("Users")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.TrainingPlan", b =>
                {
                    b.HasOne("FitnessFusion.Data.Models.Trainer", "Trainer")
                        .WithMany("TrainingPlans")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("FitnessFusion.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("FitnessFusion.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessFusion.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("FitnessFusion.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.Subscription", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.Trainer", b =>
                {
                    b.Navigation("TrainingPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
