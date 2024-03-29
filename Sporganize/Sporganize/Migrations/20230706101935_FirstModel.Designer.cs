﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sporganize.Configurations;

#nullable disable

namespace Sporganize.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230706101935_FirstModel")]
    partial class FirstModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sporganize.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Branch")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StreetId");

                    b.HasIndex("UserId");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("Sporganize.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("districts");
                });

            modelBuilder.Entity("Sporganize.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("files");
                });

            modelBuilder.Entity("Sporganize.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("MatchTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamAId")
                        .HasColumnType("int");

                    b.Property<int?>("TeamBId")
                        .HasColumnType("int");

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamAId");

                    b.HasIndex("TeamBId");

                    b.HasIndex("TournamentId");

                    b.ToTable("matches");
                });

            modelBuilder.Entity("Sporganize.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("provinces");
                });

            modelBuilder.Entity("Sporganize.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ReservationStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReservationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SportFacilityWorkingHoursId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SportFacilityWorkingHoursId");

                    b.HasIndex("UserId");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("Sporganize.Models.SportFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ProfileId")
                        .IsUnique()
                        .HasFilter("[ProfileId] IS NOT NULL");

                    b.HasIndex("StreetId");

                    b.ToTable("sportFacilities");
                });

            modelBuilder.Entity("Sporganize.Models.SportFacilityBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Branch")
                        .HasColumnType("int");

                    b.Property<int?>("SportFacilityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SportFacilityId");

                    b.ToTable("sportFacilityBranches");
                });

            modelBuilder.Entity("Sporganize.Models.SportFacilityWorkingHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BetweenWorkingHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("SportFacilityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SportFacilityId");

                    b.ToTable("sportFacilityWorkingHours");
                });

            modelBuilder.Entity("Sporganize.Models.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("streets");
                });

            modelBuilder.Entity("Sporganize.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Branch")
                        .HasColumnType("int");

                    b.Property<int?>("CaptainId")
                        .HasColumnType("int");

                    b.Property<int?>("LogoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaptainId");

                    b.HasIndex("LogoId")
                        .IsUnique()
                        .HasFilter("[LogoId] IS NOT NULL");

                    b.HasIndex("StreetId");

                    b.ToTable("teams");
                });

            modelBuilder.Entity("Sporganize.Models.TeamTournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GoalConceded")
                        .HasColumnType("int");

                    b.Property<int>("GoalScored")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfDraws")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfLoss")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfWins")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("TournamentId");

                    b.ToTable("teamTournaments");
                });

            modelBuilder.Entity("Sporganize.Models.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Branch")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SportFacilityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SportFacilityId");

                    b.ToTable("tournaments");
                });

            modelBuilder.Entity("Sporganize.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId")
                        .IsUnique()
                        .HasFilter("[ProfileId] IS NOT NULL");

                    b.HasIndex("StreetId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Sporganize.Models.UserAppointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AcceptedUserId")
                        .HasColumnType("int");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AcceptedUserId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("userAppointments");
                });

            modelBuilder.Entity("Sporganize.Models.UserFriends", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FirstFriendId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondFriendId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirstFriendId");

                    b.HasIndex("SecondFriendId");

                    b.ToTable("userFriends");
                });

            modelBuilder.Entity("Sporganize.Models.UserTeams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("userTeams");
                });

            modelBuilder.Entity("Sporganize.Models.Appointment", b =>
                {
                    b.HasOne("Sporganize.Models.Street", "Street")
                        .WithMany("Appointments")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Sporganize.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Street");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sporganize.Models.District", b =>
                {
                    b.HasOne("Sporganize.Models.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Sporganize.Models.Match", b =>
                {
                    b.HasOne("Sporganize.Models.Team", "TeamA")
                        .WithMany("TeamsA")
                        .HasForeignKey("TeamAId");

                    b.HasOne("Sporganize.Models.Team", "TeamB")
                        .WithMany("TeamsB")
                        .HasForeignKey("TeamBId");

                    b.HasOne("Sporganize.Models.Tournament", "Tournament")
                        .WithMany("Matches")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("TeamA");

                    b.Navigation("TeamB");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("Sporganize.Models.Reservation", b =>
                {
                    b.HasOne("Sporganize.Models.SportFacilityWorkingHours", "SportFacilityWorkingHours")
                        .WithMany("Reservations")
                        .HasForeignKey("SportFacilityWorkingHoursId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Sporganize.Models.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("SportFacilityWorkingHours");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sporganize.Models.SportFacility", b =>
                {
                    b.HasOne("Sporganize.Models.User", "Owner")
                        .WithMany("SportFacilities")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Sporganize.Models.File", "Profile")
                        .WithOne("SportFacility")
                        .HasForeignKey("Sporganize.Models.SportFacility", "ProfileId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Sporganize.Models.Street", "Street")
                        .WithMany("SportFacilities")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Owner");

                    b.Navigation("Profile");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("Sporganize.Models.SportFacilityBranch", b =>
                {
                    b.HasOne("Sporganize.Models.SportFacility", "SportFacility")
                        .WithMany("Branches")
                        .HasForeignKey("SportFacilityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("SportFacility");
                });

            modelBuilder.Entity("Sporganize.Models.SportFacilityWorkingHours", b =>
                {
                    b.HasOne("Sporganize.Models.SportFacility", "SportFacility")
                        .WithMany("WorkingHours")
                        .HasForeignKey("SportFacilityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("SportFacility");
                });

            modelBuilder.Entity("Sporganize.Models.Street", b =>
                {
                    b.HasOne("Sporganize.Models.District", "District")
                        .WithMany("Streets")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("District");
                });

            modelBuilder.Entity("Sporganize.Models.Team", b =>
                {
                    b.HasOne("Sporganize.Models.User", "Captain")
                        .WithMany("TeamsToBeCaptain")
                        .HasForeignKey("CaptainId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Sporganize.Models.File", "Logo")
                        .WithOne("Team")
                        .HasForeignKey("Sporganize.Models.Team", "LogoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Sporganize.Models.Street", "Street")
                        .WithMany("Teams")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Captain");

                    b.Navigation("Logo");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("Sporganize.Models.TeamTournament", b =>
                {
                    b.HasOne("Sporganize.Models.Team", "Team")
                        .WithMany("Tournaments")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Sporganize.Models.Tournament", "Tournament")
                        .WithMany("Teams")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Team");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("Sporganize.Models.Tournament", b =>
                {
                    b.HasOne("Sporganize.Models.SportFacility", "SportFacility")
                        .WithMany("Tournaments")
                        .HasForeignKey("SportFacilityId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("SportFacility");
                });

            modelBuilder.Entity("Sporganize.Models.User", b =>
                {
                    b.HasOne("Sporganize.Models.File", "Profile")
                        .WithOne("User")
                        .HasForeignKey("Sporganize.Models.User", "ProfileId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Sporganize.Models.Street", "Street")
                        .WithMany("Users")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Profile");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("Sporganize.Models.UserAppointment", b =>
                {
                    b.HasOne("Sporganize.Models.User", "AcceptedUser")
                        .WithMany("Appointments")
                        .HasForeignKey("AcceptedUserId");

                    b.HasOne("Sporganize.Models.Appointment", "Appointment")
                        .WithMany("Users")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("AcceptedUser");

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("Sporganize.Models.UserFriends", b =>
                {
                    b.HasOne("Sporganize.Models.User", "FirstFriend")
                        .WithMany("FirstFriends")
                        .HasForeignKey("FirstFriendId");

                    b.HasOne("Sporganize.Models.User", "SecondFriend")
                        .WithMany("SecondFriends")
                        .HasForeignKey("SecondFriendId");

                    b.Navigation("FirstFriend");

                    b.Navigation("SecondFriend");
                });

            modelBuilder.Entity("Sporganize.Models.UserTeams", b =>
                {
                    b.HasOne("Sporganize.Models.Team", "Team")
                        .WithMany("Users")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Sporganize.Models.User", "User")
                        .WithMany("Teams")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sporganize.Models.Appointment", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Sporganize.Models.District", b =>
                {
                    b.Navigation("Streets");
                });

            modelBuilder.Entity("Sporganize.Models.File", b =>
                {
                    b.Navigation("SportFacility");

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sporganize.Models.Province", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Sporganize.Models.SportFacility", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("Tournaments");

                    b.Navigation("WorkingHours");
                });

            modelBuilder.Entity("Sporganize.Models.SportFacilityWorkingHours", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Sporganize.Models.Street", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("SportFacilities");

                    b.Navigation("Teams");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Sporganize.Models.Team", b =>
                {
                    b.Navigation("TeamsA");

                    b.Navigation("TeamsB");

                    b.Navigation("Tournaments");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Sporganize.Models.Tournament", b =>
                {
                    b.Navigation("Matches");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Sporganize.Models.User", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("FirstFriends");

                    b.Navigation("Posts");

                    b.Navigation("Reservations");

                    b.Navigation("SecondFriends");

                    b.Navigation("SportFacilities");

                    b.Navigation("Teams");

                    b.Navigation("TeamsToBeCaptain");
                });
#pragma warning restore 612, 618
        }
    }
}
