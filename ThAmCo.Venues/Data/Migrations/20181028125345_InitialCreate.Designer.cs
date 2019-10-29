﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThAmCo.Venues.Data;

namespace ThAmCo.Venues.Data.Migrations
{
    [DbContext(typeof(VenuesDbContext))]
    [Migration("20181028125345_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("thamco.venues")
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThAmCo.Venues.Data.Availability", b =>
                {
                    b.Property<DateTime>("Date");

                    b.Property<string>("VenueCode");

                    b.Property<double>("CostPerHour");

                    b.HasKey("Date", "VenueCode");

                    b.HasIndex("VenueCode");

                    b.ToTable("Availabilities");

                    b.HasData(
                        new { Date = new DateTime(2018, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 51.79 },
                        new { Date = new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 46.77 },
                        new { Date = new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 72.07 },
                        new { Date = new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 57.18 },
                        new { Date = new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 91.03 },
                        new { Date = new DateTime(2018, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 61.13 },
                        new { Date = new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 139.55 },
                        new { Date = new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 96.38 },
                        new { Date = new DateTime(2018, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 92.69 },
                        new { Date = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 59.86 },
                        new { Date = new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 95.01 },
                        new { Date = new DateTime(2018, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 57.45 },
                        new { Date = new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 55.44 },
                        new { Date = new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 79.26 },
                        new { Date = new DateTime(2018, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 80.49 },
                        new { Date = new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 97.65 },
                        new { Date = new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 57.4 },
                        new { Date = new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 58.02 },
                        new { Date = new DateTime(2018, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 50.63 },
                        new { Date = new DateTime(2018, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 78.49 },
                        new { Date = new DateTime(2018, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 94.67 },
                        new { Date = new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 32.43 },
                        new { Date = new DateTime(2018, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 68.05 },
                        new { Date = new DateTime(2018, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 92.52 },
                        new { Date = new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 53.12 },
                        new { Date = new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 49.28 },
                        new { Date = new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 104.76 },
                        new { Date = new DateTime(2018, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 30.91 },
                        new { Date = new DateTime(2018, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 99.44 },
                        new { Date = new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 69.36 },
                        new { Date = new DateTime(2018, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 76.14 },
                        new { Date = new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 64.02 },
                        new { Date = new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 51.48 },
                        new { Date = new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 112.88 },
                        new { Date = new DateTime(2018, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 109.15 },
                        new { Date = new DateTime(2018, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 115.89 },
                        new { Date = new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 64.03 },
                        new { Date = new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 53.84 },
                        new { Date = new DateTime(2018, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 40.11 },
                        new { Date = new DateTime(2018, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 92.32 },
                        new { Date = new DateTime(2018, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 76.81 },
                        new { Date = new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 43.72 },
                        new { Date = new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 80.66 },
                        new { Date = new DateTime(2018, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 42.3 },
                        new { Date = new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 51.56 },
                        new { Date = new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 87.87 },
                        new { Date = new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 48.59 },
                        new { Date = new DateTime(2018, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 84.98 },
                        new { Date = new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 35.85 },
                        new { Date = new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 80.77 },
                        new { Date = new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 83.71 },
                        new { Date = new DateTime(2018, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 91.53 },
                        new { Date = new DateTime(2018, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 132.13 },
                        new { Date = new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 104.41 },
                        new { Date = new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 114.65 },
                        new { Date = new DateTime(2018, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 50.39 },
                        new { Date = new DateTime(2018, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 95.83 },
                        new { Date = new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 62.54 },
                        new { Date = new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 78.43 },
                        new { Date = new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 77.7 },
                        new { Date = new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 33.03 },
                        new { Date = new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 110.11 },
                        new { Date = new DateTime(2019, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 77.64 },
                        new { Date = new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 130.17 },
                        new { Date = new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 35.67 },
                        new { Date = new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 101.32 },
                        new { Date = new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 53.22 },
                        new { Date = new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 74.15 },
                        new { Date = new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 102.22 },
                        new { Date = new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 44.05 },
                        new { Date = new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 99.88 },
                        new { Date = new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 115.3 },
                        new { Date = new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 53.81 },
                        new { Date = new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "CRKHL", CostPerHour = 72.34 },
                        new { Date = new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "FDLCK", CostPerHour = 52.94 },
                        new { Date = new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), VenueCode = "TNDMR", CostPerHour = 112.63 }
                    );
                });

            modelBuilder.Entity("ThAmCo.Venues.Data.EventType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .IsFixedLength(true)
                        .HasMaxLength(3);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EventTypes");

                    b.HasData(
                        new { Id = "CON", Title = "Conference" },
                        new { Id = "MET", Title = "Meeting" },
                        new { Id = "PTY", Title = "Party" },
                        new { Id = "WED", Title = "Wedding" }
                    );
                });

            modelBuilder.Entity("ThAmCo.Venues.Data.Reservation", b =>
                {
                    b.Property<string>("Reference")
                        .ValueGeneratedOnAdd()
                        .IsFixedLength(true)
                        .HasMaxLength(13);

                    b.Property<DateTime>("EventDate");

                    b.Property<string>("StaffId")
                        .IsRequired();

                    b.Property<string>("VenueCode")
                        .IsRequired();

                    b.Property<DateTime>("WhenMade");

                    b.HasKey("Reference");

                    b.HasIndex("EventDate", "VenueCode")
                        .IsUnique();

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("ThAmCo.Venues.Data.Suitability", b =>
                {
                    b.Property<string>("EventTypeId");

                    b.Property<string>("VenueCode");

                    b.HasKey("EventTypeId", "VenueCode");

                    b.HasIndex("VenueCode");

                    b.ToTable("Suitabilities");

                    b.HasData(
                        new { EventTypeId = "WED", VenueCode = "CRKHL" },
                        new { EventTypeId = "CON", VenueCode = "CRKHL" },
                        new { EventTypeId = "PTY", VenueCode = "CRKHL" },
                        new { EventTypeId = "WED", VenueCode = "TNDMR" },
                        new { EventTypeId = "CON", VenueCode = "TNDMR" },
                        new { EventTypeId = "MET", VenueCode = "TNDMR" },
                        new { EventTypeId = "WED", VenueCode = "FDLCK" },
                        new { EventTypeId = "PTY", VenueCode = "FDLCK" }
                    );
                });

            modelBuilder.Entity("ThAmCo.Venues.Data.Venue", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd()
                        .IsFixedLength(true)
                        .HasMaxLength(5);

                    b.Property<int>("Capacity");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Code");

                    b.ToTable("Venues");

                    b.HasData(
                        new { Code = "CRKHL", Capacity = 150, Description = "Once the residence of Lord and Lady Crackling, this lavish dwelling remains a prime example of 18th century fine living.", Name = "Crackling Hall" },
                        new { Code = "TNDMR", Capacity = 450, Description = "Refurbished manor house with fully equipped facilities ready to help you have a good time in business or pleasure.", Name = "Tinder Manor" },
                        new { Code = "FDLCK", Capacity = 85, Description = "Rustic pub set in ideallic countryside, the original venue of a notorious local musician and his parrot.", Name = "The Fiddler's Cockatoo" }
                    );
                });

            modelBuilder.Entity("ThAmCo.Venues.Data.Availability", b =>
                {
                    b.HasOne("ThAmCo.Venues.Data.Venue", "Venue")
                        .WithMany("AvailableDates")
                        .HasForeignKey("VenueCode")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThAmCo.Venues.Data.Reservation", b =>
                {
                    b.HasOne("ThAmCo.Venues.Data.Availability", "Availability")
                        .WithOne("Reservation")
                        .HasForeignKey("ThAmCo.Venues.Data.Reservation", "EventDate", "VenueCode")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ThAmCo.Venues.Data.Suitability", b =>
                {
                    b.HasOne("ThAmCo.Venues.Data.EventType", "EventType")
                        .WithMany("SuitableVenues")
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ThAmCo.Venues.Data.Venue", "Venue")
                        .WithMany("SuitableEventTypes")
                        .HasForeignKey("VenueCode")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
