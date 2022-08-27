﻿// <auto-generated />
using System;
using Adni.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Adni.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Adni.Domain.Entities.AlmUser", b =>
                {
                    b.Property<Guid>("AlmUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Contrat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Dob")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("FieldId")
                        .HasColumnType("uuid");

                    b.Property<string>("Firtname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("Gender")
                        .HasColumnType("character(1)");

                    b.Property<string>("GraduateYear")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Localisation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AlmUserId");

                    b.ToTable("almUsers");
                });

            modelBuilder.Entity("Adni.Domain.Entities.CompaniesList", b =>
                {
                    b.Property<Guid>("CompaniesListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CompaniesListId");

                    b.ToTable("companiesLists");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CompaniesListId")
                        .HasColumnType("uuid");

                    b.Property<string>("CompanyCigle")
                        .HasColumnType("text");

                    b.Property<string>("CompanyDescription")
                        .HasColumnType("text");

                    b.Property<string>("CompanyEmail")
                        .HasColumnType("text");

                    b.Property<string>("CompanyFocal")
                        .HasColumnType("text");

                    b.Property<string>("CompanyLocation")
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<string>("CompanyPhonenumber")
                        .HasColumnType("text");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ProspectorId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CompaniesListId");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Department", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("DepartmentDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HeadDepartmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DepartmentId");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("DoB")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("EmployeesListId")
                        .HasColumnType("uuid");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("boolean");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WhatsappNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmployeesListId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("Adni.Domain.Entities.EmployeesList", b =>
                {
                    b.Property<Guid>("EmployeesListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("EmployeesRole")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmployeesListId");

                    b.ToTable("employeesLists");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Field", b =>
                {
                    b.Property<Guid>("FieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uuid");

                    b.Property<string>("FieldCigle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FieldDescription")
                        .HasColumnType("text");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ProspectionId")
                        .HasColumnType("uuid");

                    b.HasKey("FieldId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProspectionId");

                    b.ToTable("fields");
                });

            modelBuilder.Entity("Adni.Domain.Entities.PlacesDisponibles", b =>
                {
                    b.Property<Guid>("PlacesDisponiblesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("NbrPlace")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProspectionId")
                        .HasColumnType("uuid");

                    b.HasKey("PlacesDisponiblesId");

                    b.HasIndex("ProspectionId");

                    b.ToTable("PlacesDisponibles");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Prospection", b =>
                {
                    b.Property<Guid>("ProspectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EmployeeProspectorId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProspectionsListId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("uuid");

                    b.HasKey("ProspectionId");

                    b.HasIndex("ProspectionsListId");

                    b.ToTable("prospections");
                });

            modelBuilder.Entity("Adni.Domain.Entities.ProspectionsList", b =>
                {
                    b.Property<Guid>("ProspectionsListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Observation")
                        .HasColumnType("text");

                    b.HasKey("ProspectionsListId");

                    b.ToTable("prospectionsList");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AcademicLevel")
                        .HasColumnType("integer");

                    b.Property<string>("AcademicYear")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DoB")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<Guid>("FieldId")
                        .HasColumnType("uuid");

                    b.Property<string>("Firstname")
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Matricule")
                        .HasColumnType("text");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("text");

                    b.Property<string>("WhatsappNumber")
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Company", b =>
                {
                    b.HasOne("Adni.Domain.Entities.CompaniesList", null)
                        .WithMany("Companies")
                        .HasForeignKey("CompaniesListId");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Employee", b =>
                {
                    b.HasOne("Adni.Domain.Entities.EmployeesList", null)
                        .WithMany("Employees")
                        .HasForeignKey("EmployeesListId");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Field", b =>
                {
                    b.HasOne("Adni.Domain.Entities.Department", "Department")
                        .WithMany("Fields")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Adni.Domain.Entities.Prospection", null)
                        .WithMany("DesiredFields")
                        .HasForeignKey("ProspectionId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Adni.Domain.Entities.PlacesDisponibles", b =>
                {
                    b.HasOne("Adni.Domain.Entities.Prospection", "Prospection")
                        .WithMany("PlacesDisponibles")
                        .HasForeignKey("ProspectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prospection");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Prospection", b =>
                {
                    b.HasOne("Adni.Domain.Entities.ProspectionsList", null)
                        .WithMany("ProspectionRecap")
                        .HasForeignKey("ProspectionsListId");
                });

            modelBuilder.Entity("Adni.Domain.Entities.CompaniesList", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Department", b =>
                {
                    b.Navigation("Fields");
                });

            modelBuilder.Entity("Adni.Domain.Entities.EmployeesList", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Adni.Domain.Entities.Prospection", b =>
                {
                    b.Navigation("DesiredFields");

                    b.Navigation("PlacesDisponibles");
                });

            modelBuilder.Entity("Adni.Domain.Entities.ProspectionsList", b =>
                {
                    b.Navigation("ProspectionRecap");
                });
#pragma warning restore 612, 618
        }
    }
}
