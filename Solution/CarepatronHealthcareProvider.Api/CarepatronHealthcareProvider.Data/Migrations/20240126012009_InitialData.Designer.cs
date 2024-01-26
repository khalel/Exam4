﻿// <auto-generated />
using CarepatronHealthcareProvider.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarepatronHealthcareProvider.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240126012009_InitialData")]
    partial class InitialData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company1Patient", b =>
                {
                    b.Property<int>("Company1PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Company1PatientId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("RecordNumber")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Company1PatientId");

                    b.ToTable("Company1Patient");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company1PhysicalAssessment", b =>
                {
                    b.Property<int>("PhysicalAssessmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhysicalAssessmentId"));

                    b.Property<string>("Assessment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Company1PatientId")
                        .HasColumnType("int");

                    b.HasKey("PhysicalAssessmentId");

                    b.HasIndex("Company1PatientId");

                    b.ToTable("Company1PhysicalAssessment");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company1ProgressNotes", b =>
                {
                    b.Property<int>("ProgressNotesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgressNotesId"));

                    b.Property<int>("Company1PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgressNotesId");

                    b.HasIndex("Company1PatientId");

                    b.ToTable("Company1ProgressNotes");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company2Patient", b =>
                {
                    b.Property<int>("Company1PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Company1PatientId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("RecordNumber")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Company1PatientId");

                    b.ToTable("Company2Patient");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company2PhysicalAssessment", b =>
                {
                    b.Property<int>("PhysicalAssessmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhysicalAssessmentId"));

                    b.Property<string>("Assessment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Company2PatientId")
                        .HasColumnType("int");

                    b.HasKey("PhysicalAssessmentId");

                    b.HasIndex("Company2PatientId");

                    b.ToTable("Company2PhysicalAssessment");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company2ProgressNotes", b =>
                {
                    b.Property<int>("ProgressNotesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgressNotesId"));

                    b.Property<int>("Company2PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgressNotesId");

                    b.HasIndex("Company2PatientId");

                    b.ToTable("Company2ProgressNotes");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.DieticianPatient", b =>
                {
                    b.Property<int>("DieticianPatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DieticianPatientId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("HealthcareProviderId")
                        .HasColumnType("int");

                    b.Property<string>("HealthcareProviderNumber")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("DieticianPatientId");

                    b.HasIndex("HealthcareProviderId");

                    b.ToTable("DieticianPatient");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.HealthcareProvider", b =>
                {
                    b.Property<int>("HealthcareProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HealthcareProviderId"));

                    b.Property<string>("HealthcareProviderName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("HealthcareProviderId");

                    b.ToTable("HealthcareProvider");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("RecordNumber")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("PatientId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.PhysicalAssessment", b =>
                {
                    b.Property<int>("PhysicalAssessmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhysicalAssessmentId"));

                    b.Property<string>("Assessment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("PhysicalAssessmentId");

                    b.HasIndex("PatientId");

                    b.ToTable("PhysicalAssessment");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.PrimaryHealthcareProviderPhysicalAssessment", b =>
                {
                    b.Property<int>("PhysicalAssessmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhysicalAssessmentId"));

                    b.Property<string>("Assessment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DieticianPatientId")
                        .HasColumnType("int");

                    b.HasKey("PhysicalAssessmentId");

                    b.HasIndex("DieticianPatientId");

                    b.ToTable("PrimaryHealthcareProviderPhysicalAssessment");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.PrimaryHealthcareProviderProgressNotes", b =>
                {
                    b.Property<int>("ProgressNotesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgressNotesId"));

                    b.Property<int>("DieticianPatientId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgressNotesId");

                    b.HasIndex("DieticianPatientId");

                    b.ToTable("PrimaryHealthcareProviderProgressNotes");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.ProgressNotes", b =>
                {
                    b.Property<int>("ProgressNotesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgressNotesId"));

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("ProgressNotesId");

                    b.HasIndex("PatientId");

                    b.ToTable("ProgressNotes");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company1PhysicalAssessment", b =>
                {
                    b.HasOne("CarepatronHealthcareProvider.Domain.Model.Company1Patient", null)
                        .WithMany("Company1PhysicalAssessment")
                        .HasForeignKey("Company1PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company1ProgressNotes", b =>
                {
                    b.HasOne("CarepatronHealthcareProvider.Domain.Model.Company1Patient", null)
                        .WithMany("Company1ProgressNotes")
                        .HasForeignKey("Company1PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company2PhysicalAssessment", b =>
                {
                    b.HasOne("CarepatronHealthcareProvider.Domain.Model.Company2Patient", null)
                        .WithMany("Company2PhysicalAssessment")
                        .HasForeignKey("Company2PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company2ProgressNotes", b =>
                {
                    b.HasOne("CarepatronHealthcareProvider.Domain.Model.Company2Patient", null)
                        .WithMany("Company2ProgressNotes")
                        .HasForeignKey("Company2PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.DieticianPatient", b =>
                {
                    b.HasOne("CarepatronHealthcareProvider.Domain.Model.HealthcareProvider", "HealthcareProvider")
                        .WithMany()
                        .HasForeignKey("HealthcareProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HealthcareProvider");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.PhysicalAssessment", b =>
                {
                    b.HasOne("CarepatronHealthcareProvider.Domain.Model.Patient", null)
                        .WithMany("PhysicalAssessments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.PrimaryHealthcareProviderPhysicalAssessment", b =>
                {
                    b.HasOne("CarepatronHealthcareProvider.Domain.Model.DieticianPatient", null)
                        .WithMany("PrimaryHealthcareProviderPhysicalAssessments")
                        .HasForeignKey("DieticianPatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.PrimaryHealthcareProviderProgressNotes", b =>
                {
                    b.HasOne("CarepatronHealthcareProvider.Domain.Model.DieticianPatient", null)
                        .WithMany("PrimaryHealthcareProviderProgressNotes")
                        .HasForeignKey("DieticianPatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.ProgressNotes", b =>
                {
                    b.HasOne("CarepatronHealthcareProvider.Domain.Model.Patient", null)
                        .WithMany("ProgressNotes")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company1Patient", b =>
                {
                    b.Navigation("Company1PhysicalAssessment");

                    b.Navigation("Company1ProgressNotes");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Company2Patient", b =>
                {
                    b.Navigation("Company2PhysicalAssessment");

                    b.Navigation("Company2ProgressNotes");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.DieticianPatient", b =>
                {
                    b.Navigation("PrimaryHealthcareProviderPhysicalAssessments");

                    b.Navigation("PrimaryHealthcareProviderProgressNotes");
                });

            modelBuilder.Entity("CarepatronHealthcareProvider.Domain.Model.Patient", b =>
                {
                    b.Navigation("PhysicalAssessments");

                    b.Navigation("ProgressNotes");
                });
#pragma warning restore 612, 618
        }
    }
}