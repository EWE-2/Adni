using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adni.Data.Migrations
{
    public partial class InitialBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "almUsers",
                columns: table => new
                {
                    AlmUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldId = table.Column<Guid>(type: "uuid", nullable: false),
                    GraduateYear = table.Column<string>(type: "text", nullable: true),
                    ProStatus = table.Column<string>(type: "text", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: true),
                    Contrat = table.Column<string>(type: "text", nullable: true),
                    CompanyLocalisation = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<char>(type: "character(1)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    WhatsappNumber = table.Column<string>(type: "text", nullable: true),
                    Dob = table.Column<string>(type: "text", nullable: true),
                    UserLocation = table.Column<string>(type: "text", nullable: true),
                    ImageDirectory = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_almUsers", x => x.AlmUserId);
                });

            migrationBuilder.CreateTable(
                name: "attributions",
                columns: table => new
                {
                    AttributionId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    AcademicYear = table.Column<string>(type: "text", nullable: false),
                    InternType = table.Column<string>(type: "text", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    Student = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attributions", x => x.AttributionId);
                });

            migrationBuilder.CreateTable(
                name: "companiesLists",
                columns: table => new
                {
                    CompaniesListId = table.Column<Guid>(type: "uuid", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companiesLists", x => x.CompaniesListId);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeadDepartmentName = table.Column<string>(type: "text", nullable: false),
                    DepartmentName = table.Column<string>(type: "text", nullable: false),
                    DepartmentDescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "employeesLists",
                columns: table => new
                {
                    EmployeesListId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeesRole = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeesLists", x => x.EmployeesListId);
                });

            migrationBuilder.CreateTable(
                name: "internshipReports",
                columns: table => new
                {
                    InternshipReportId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeposed = table.Column<bool>(type: "boolean", nullable: false),
                    InternshipId = table.Column<Guid>(type: "uuid", nullable: false),
                    Student = table.Column<Guid>(type: "uuid", nullable: false),
                    Note = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_internshipReports", x => x.InternshipReportId);
                });

            migrationBuilder.CreateTable(
                name: "internships",
                columns: table => new
                {
                    InternshipId = table.Column<Guid>(type: "uuid", nullable: false),
                    InternshipPlacementId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IntershipType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_internships", x => x.InternshipId);
                });

            migrationBuilder.CreateTable(
                name: "prospectionsList",
                columns: table => new
                {
                    ProspectionsListId = table.Column<Guid>(type: "uuid", nullable: false),
                    Observation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prospectionsList", x => x.ProspectionsListId);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<char>(type: "character(1)", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    UserLocation = table.Column<string>(type: "text", nullable: false),
                    Dob = table.Column<string>(type: "text", nullable: false),
                    ImageDirectory = table.Column<string>(type: "text", nullable: true),
                    Matricule = table.Column<string>(type: "text", nullable: true),
                    AcademicYear = table.Column<string>(type: "text", nullable: false),
                    AcademicLevel = table.Column<int>(type: "integer", nullable: false),
                    FieldId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProspectorId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: true),
                    CompanyDescription = table.Column<string>(type: "text", nullable: true),
                    CompanyCigle = table.Column<string>(type: "text", nullable: true),
                    CompanyPhonenumber = table.Column<string>(type: "text", nullable: true),
                    CompanyEmail = table.Column<string>(type: "text", nullable: true),
                    CompanyLocation = table.Column<string>(type: "text", nullable: true),
                    CompanyFocal = table.Column<string>(type: "text", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    CompaniesListId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_companies_companiesLists_CompaniesListId",
                        column: x => x.CompaniesListId,
                        principalTable: "companiesLists",
                        principalColumn: "CompaniesListId");
                });

            migrationBuilder.CreateTable(
                name: "fields",
                columns: table => new
                {
                    FieldId = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldName = table.Column<string>(type: "text", nullable: false),
                    FieldDescription = table.Column<string>(type: "text", nullable: true),
                    FieldCigle = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fields", x => x.FieldId);
                    table.ForeignKey(
                        name: "FK_fields_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsOnline = table.Column<bool>(type: "boolean", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    EmployeesListId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<char>(type: "character(1)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    WhatsappNumber = table.Column<string>(type: "text", nullable: true),
                    Dob = table.Column<string>(type: "text", nullable: true),
                    UserLocation = table.Column<string>(type: "text", nullable: true),
                    ImageDirectory = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_employees_employeesLists_EmployeesListId",
                        column: x => x.EmployeesListId,
                        principalTable: "employeesLists",
                        principalColumn: "EmployeesListId");
                });

            migrationBuilder.CreateTable(
                name: "prospections",
                columns: table => new
                {
                    ProspectionId = table.Column<Guid>(type: "uuid", nullable: false),
                    AcademicYear = table.Column<string>(type: "text", nullable: false),
                    EmployeeProspectorId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProspectionsListId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prospections", x => x.ProspectionId);
                    table.ForeignKey(
                        name: "FK_prospections_prospectionsList_ProspectionsListId",
                        column: x => x.ProspectionsListId,
                        principalTable: "prospectionsList",
                        principalColumn: "ProspectionsListId");
                });

            migrationBuilder.CreateTable(
                name: "placesDisponibles",
                columns: table => new
                {
                    PlacesDisponiblesId = table.Column<Guid>(type: "uuid", nullable: false),
                    NbrPlace = table.Column<int>(type: "integer", nullable: false),
                    ProspectionId = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_placesDisponibles", x => x.PlacesDisponiblesId);
                    table.ForeignKey(
                        name: "FK_placesDisponibles_prospections_ProspectionId",
                        column: x => x.ProspectionId,
                        principalTable: "prospections",
                        principalColumn: "ProspectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_companies_CompaniesListId",
                table: "companies",
                column: "CompaniesListId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_EmployeesListId",
                table: "employees",
                column: "EmployeesListId");

            migrationBuilder.CreateIndex(
                name: "IX_fields_DepartmentId",
                table: "fields",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_placesDisponibles_ProspectionId",
                table: "placesDisponibles",
                column: "ProspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_prospections_ProspectionsListId",
                table: "prospections",
                column: "ProspectionsListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "almUsers");

            migrationBuilder.DropTable(
                name: "attributions");

            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "fields");

            migrationBuilder.DropTable(
                name: "internshipReports");

            migrationBuilder.DropTable(
                name: "internships");

            migrationBuilder.DropTable(
                name: "placesDisponibles");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "companiesLists");

            migrationBuilder.DropTable(
                name: "employeesLists");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "prospections");

            migrationBuilder.DropTable(
                name: "prospectionsList");
        }
    }
}
