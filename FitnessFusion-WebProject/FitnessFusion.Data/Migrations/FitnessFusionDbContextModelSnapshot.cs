﻿// <auto-generated />
using System;
using FitnessFusion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessFusion.Data.Migrations
{
    [DbContext(typeof(FitnessFusionDbContext))]
    partial class FitnessFusionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApplicationUserSubscription", b =>
                {
                    b.Property<Guid>("SubscriptionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SubscriptionsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ApplicationUserSubscription");
                });

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

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSubscribeValid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTrainer")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");
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
                            Id = new Guid("5cd2a1d8-13c6-4d8d-83b2-8bc70d14e898"),
                            Description = "It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells. During a bench press, you lower the weight down to chest level and then press upwards while extending your arms.",
                            Difficulty = 1,
                            ImagePath = "BenchPress.jfif",
                            MuscleGroup = 0,
                            Name = "Bench press",
                            VideoLink = "https://youtu.be/gRVjAtPip0Y"
                        },
                        new
                        {
                            Id = new Guid("df46c6b2-7a10-41d5-9a14-6f3d5070594a"),
                            Description = "An exercise in which a standing person lowers to a position in which the torso is erect and the knees are deeply bent and then rises to an upright position.",
                            Difficulty = 1,
                            ImagePath = "Squat.jfif",
                            MuscleGroup = 2,
                            Name = "Squat",
                            VideoLink = "https://youtu.be/MVMNk0HiTMg"
                        },
                        new
                        {
                            Id = new Guid("1fb1d071-4975-479e-a952-e568fa6fdb07"),
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
                            Id = new Guid("59c1d805-95c1-4bbe-bd2e-c9970a83170a"),
                            CaloriesPer100g = 300.0,
                            ImageUrl = "Musli.png",
                            MealType = 0,
                            Name = "TestBreakfast"
                        },
                        new
                        {
                            Id = new Guid("eddc30ab-e581-457c-867b-280f0eb1ddc6"),
                            CaloriesPer100g = 300.0,
                            ImageUrl = "Egg.png",
                            MealType = 1,
                            Name = "TestLunch"
                        },
                        new
                        {
                            Id = new Guid("384d61e1-8af2-4107-9700-51266d6831b1"),
                            CaloriesPer100g = 300.0,
                            ImageUrl = "Egg.png",
                            MealType = 3,
                            Name = "TestDinner"
                        },
                        new
                        {
                            Id = new Guid("ea66020d-4f97-4e8d-8f68-37011399fdc1"),
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeriodOfSubscription")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("TypeOfSubscription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("FitnessFusion.Data.Models.TrainingPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("d0805a02-9106-4577-934b-0648491589c3"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2c678da5-0966-4dfc-9a51-70b749906f48",
                            Email = "trainer@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Test",
                            IsSubscribeValid = true,
                            IsTrainer = true,
                            LastName = "Trainer",
                            LockoutEnabled = true,
                            NormalizedEmail = "TRAINER@ABV.BG",
                            NormalizedUserName = "TRAINER@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAELYMpFa6bQWirzgZInmMJqAmv5XoaDTUp1uaWGeQn7PGHbdiA6H9JEQfUyX/b0N6SA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "04f56de6-f75c-4055-9bab-02f23933a341",
                            TwoFactorEnabled = false,
                            UserName = "trainer@abv.bg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vestibulum sollicitudin est, varius vehicula erat pulvinar vel. Morbi molestie accumsan dolor, in bibendum mauris faucibus eu. Donec finibus a quam consectetur fermentum. Pellentesque faucibus at neque et iaculis. Sed consequat urna pulvinar feugiat finibus."
                        });
                });

            modelBuilder.Entity("ApplicationUserSubscription", b =>
                {
                    b.HasOne("FitnessFusion.Data.Models.Subscription", null)
                        .WithMany()
                        .HasForeignKey("SubscriptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessFusion.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("FitnessFusion.Data.Models.Trainer", b =>
                {
                    b.Navigation("TrainingPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
