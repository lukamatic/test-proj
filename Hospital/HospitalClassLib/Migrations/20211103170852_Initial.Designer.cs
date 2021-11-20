﻿// <auto-generated />
using System;
using Hospital.EfStructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Hospital.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211103170852_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Hospital.Model.Allergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MedicalIngredientId")
                        .HasColumnType("integer");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("integer");

                    b.Property<int?>("MedicationIngredientId")
                        .HasColumnType("integer");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId");

                    b.HasIndex("MedicationIngredientId");

                    b.HasIndex("PatientId");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("Hospital.Model.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PostalCode")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Hospital.Model.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Hospital.Model.Diagnose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Anamnesis")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Illness")
                        .HasColumnType("text");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("integer");

                    b.Property<string>("Symptoms")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("Hospital.Model.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("FeedbackStatus")
                        .HasColumnType("integer");

                    b.Property<bool>("IsPublishable")
                        .HasColumnType("boolean");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Hospital.Model.HospitalTreatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<int?>("RoomId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId");

                    b.HasIndex("RoomId");

                    b.ToTable("HospitalTreatments");
                });

            modelBuilder.Entity("Hospital.Model.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("InventoryItemType")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("Hospital.Model.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BloodType")
                        .HasColumnType("integer");

                    b.Property<int>("JobStatus")
                        .HasColumnType("integer");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("Hospital.Model.Medication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("HowToUse")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("TimesPerDay")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("Hospital.Model.MedicationIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MedicationIngredients");
                });

            modelBuilder.Entity("Hospital.Model.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("IssuedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("integer");

                    b.Property<int>("MedicationId")
                        .HasColumnType("integer");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId");

                    b.HasIndex("MedicationId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Hospital.Model.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("SurveyId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Hospital.Model.Referral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsUrgent")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("IssuedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Referrals");
                });

            modelBuilder.Entity("Hospital.Model.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BuildingName")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<double>("DimensionX")
                        .HasColumnType("double precision");

                    b.Property<double>("DimensionY")
                        .HasColumnType("double precision");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Hospital.Model.RoomInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("InventoryItemId")
                        .HasColumnType("integer");

                    b.Property<int>("RoomId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("InventoryItemId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomInventories");
                });

            modelBuilder.Entity("Hospital.Model.ScheduledEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("boolean");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("integer");

                    b.Property<int?>("PatientId")
                        .HasColumnType("integer");

                    b.Property<int?>("RoomId")
                        .HasColumnType("integer");

                    b.Property<int>("ScheduledEventType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("MedicalRecordId");

                    b.HasIndex("PatientId");

                    b.HasIndex("RoomId");

                    b.ToTable("ScheduledEvents");
                });

            modelBuilder.Entity("Hospital.Model.Specialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("Hospital.Model.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Hospital.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("MedicationMedicationIngredient", b =>
                {
                    b.Property<int>("MedicationIngredientsId")
                        .HasColumnType("integer");

                    b.Property<int>("MedicationsId")
                        .HasColumnType("integer");

                    b.HasKey("MedicationIngredientsId", "MedicationsId");

                    b.HasIndex("MedicationsId");

                    b.ToTable("MedicationMedicationIngredient");
                });

            modelBuilder.Entity("Hospital.Model.Patient", b =>
                {
                    b.HasBaseType("Hospital.Model.User");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("Hospital.Model.Staff", b =>
                {
                    b.HasBaseType("Hospital.Model.User");

                    b.Property<int>("RoomId")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("Staff");
                });

            modelBuilder.Entity("Hospital.Model.Doctor", b =>
                {
                    b.HasBaseType("Hospital.Model.Staff");

                    b.Property<int?>("SpecializationId")
                        .HasColumnType("integer");

                    b.HasIndex("RoomId");

                    b.HasIndex("SpecializationId");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("Hospital.Model.Allergy", b =>
                {
                    b.HasOne("Hospital.Model.MedicalRecord", null)
                        .WithMany("Allergies")
                        .HasForeignKey("MedicalRecordId");

                    b.HasOne("Hospital.Model.MedicationIngredient", "MedicationIngredient")
                        .WithMany()
                        .HasForeignKey("MedicationIngredientId");

                    b.HasOne("Hospital.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicationIngredient");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital.Model.City", b =>
                {
                    b.HasOne("Hospital.Model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Hospital.Model.Diagnose", b =>
                {
                    b.HasOne("Hospital.Model.MedicalRecord", null)
                        .WithMany("Diagnoses")
                        .HasForeignKey("MedicalRecordId");
                });

            modelBuilder.Entity("Hospital.Model.Feedback", b =>
                {
                    b.HasOne("Hospital.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital.Model.HospitalTreatment", b =>
                {
                    b.HasOne("Hospital.Model.MedicalRecord", "MedicalRecord")
                        .WithMany("HospitalTreatments")
                        .HasForeignKey("MedicalRecordId");

                    b.HasOne("Hospital.Model.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.Navigation("MedicalRecord");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hospital.Model.MedicalRecord", b =>
                {
                    b.HasOne("Hospital.Model.Patient", "Patient")
                        .WithOne("MedicalRecord")
                        .HasForeignKey("Hospital.Model.MedicalRecord", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital.Model.Prescription", b =>
                {
                    b.HasOne("Hospital.Model.MedicalRecord", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("MedicalRecordId");

                    b.HasOne("Hospital.Model.Medication", "Medication")
                        .WithMany()
                        .HasForeignKey("MedicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medication");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital.Model.Question", b =>
                {
                    b.HasOne("Hospital.Model.Survey", "Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Hospital.Model.Referral", b =>
                {
                    b.HasOne("Hospital.Model.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Model.MedicalRecord", null)
                        .WithMany("Referrals")
                        .HasForeignKey("MedicalRecordId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Hospital.Model.RoomInventory", b =>
                {
                    b.HasOne("Hospital.Model.InventoryItem", "InventoryItem")
                        .WithMany("RoomInventories")
                        .HasForeignKey("InventoryItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Model.Room", "Room")
                        .WithMany("RoomInventories")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventoryItem");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hospital.Model.ScheduledEvent", b =>
                {
                    b.HasOne("Hospital.Model.Doctor", "Doctor")
                        .WithMany("ScheduledEvents")
                        .HasForeignKey("DoctorId");

                    b.HasOne("Hospital.Model.MedicalRecord", null)
                        .WithMany("ScheduledEvents")
                        .HasForeignKey("MedicalRecordId");

                    b.HasOne("Hospital.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.HasOne("Hospital.Model.Room", "Room")
                        .WithMany("ScheduledEvents")
                        .HasForeignKey("RoomId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hospital.Model.User", b =>
                {
                    b.HasOne("Hospital.Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("MedicationMedicationIngredient", b =>
                {
                    b.HasOne("Hospital.Model.MedicationIngredient", null)
                        .WithMany()
                        .HasForeignKey("MedicationIngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Model.Medication", null)
                        .WithMany()
                        .HasForeignKey("MedicationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital.Model.Doctor", b =>
                {
                    b.HasOne("Hospital.Model.Room", "Room")
                        .WithMany("Doctors")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Model.Specialization", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId");

                    b.Navigation("Room");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("Hospital.Model.InventoryItem", b =>
                {
                    b.Navigation("RoomInventories");
                });

            modelBuilder.Entity("Hospital.Model.MedicalRecord", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("Diagnoses");

                    b.Navigation("HospitalTreatments");

                    b.Navigation("Prescriptions");

                    b.Navigation("Referrals");

                    b.Navigation("ScheduledEvents");
                });

            modelBuilder.Entity("Hospital.Model.Room", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("RoomInventories");

                    b.Navigation("ScheduledEvents");
                });

            modelBuilder.Entity("Hospital.Model.Survey", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Hospital.Model.Patient", b =>
                {
                    b.Navigation("MedicalRecord");
                });

            modelBuilder.Entity("Hospital.Model.Doctor", b =>
                {
                    b.Navigation("ScheduledEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
