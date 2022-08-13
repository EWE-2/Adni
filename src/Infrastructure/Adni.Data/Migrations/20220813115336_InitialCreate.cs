using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Adni.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companiesLists",
                columns: table => new
                {
                    CompaniesListId = table.Column<Guid>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companiesLists", x => x.CompaniesListId);
                });

            migrationBuilder.CreateTable(
                name: "employeesLists",
                columns: table => new
                {
                    EmployeesListId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EmployeesRole = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeesLists", x => x.EmployeesListId);
                });

            migrationBuilder.CreateTable(
                name: "prospectionsList",
                columns: table => new
                {
                    ProspectionsListId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Observation = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prospectionsList", x => x.ProspectionsListId);
                });

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProspectorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyDescription = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyCigle = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyPhonenumber = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyEmail = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyLocation = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyFocal = table.Column<string>(type: "TEXT", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    CompaniesListId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_companies_companiesLists_CompaniesListId",
                        column: x => x.CompaniesListId,
                        principalTable: "companiesLists",
                        principalColumn: "CompaniesListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsOnline = table.Column<bool>(type: "INTEGER", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeesListId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: false),
                    Lastname = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Phonenumber = table.Column<string>(type: "TEXT", nullable: false),
                    WhatsappNumber = table.Column<string>(type: "TEXT", nullable: false),
                    DoB = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_employees_employeesLists_EmployeesListId",
                        column: x => x.EmployeesListId,
                        principalTable: "employeesLists",
                        principalColumn: "EmployeesListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prospections",
                columns: table => new
                {
                    ProspectionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SessionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EmployeeProspectorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CompanyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlacesDisponibles = table.Column<int>(type: "INTEGER", nullable: false),
                    ProspectionsListId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prospections", x => x.ProspectionId);
                    table.ForeignKey(
                        name: "FK_prospections_prospectionsList_ProspectionsListId",
                        column: x => x.ProspectionsListId,
                        principalTable: "prospectionsList",
                        principalColumn: "ProspectionsListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    HeadDepartmentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Departmentname = table.Column<string>(type: "TEXT", nullable: false),
                    DepartmentDescription = table.Column<string>(type: "TEXT", nullable: false),
                    ProspectionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Department_prospections_ProspectionId",
                        column: x => x.ProspectionId,
                        principalTable: "prospections",
                        principalColumn: "ProspectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    FieldId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FieldName = table.Column<string>(type: "TEXT", nullable: false),
                    FieldDescription = table.Column<string>(type: "TEXT", nullable: false),
                    FieldCigle = table.Column<string>(type: "TEXT", nullable: false),
                    ProspectionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.FieldId);
                    table.ForeignKey(
                        name: "FK_Field_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Field_prospections_ProspectionId",
                        column: x => x.ProspectionId,
                        principalTable: "prospections",
                        principalColumn: "ProspectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_companies_CompaniesListId",
                table: "companies",
                column: "CompaniesListId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ProspectionId",
                table: "Department",
                column: "ProspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_EmployeesListId",
                table: "employees",
                column: "EmployeesListId");

            migrationBuilder.CreateIndex(
                name: "IX_Field_DepartmentId",
                table: "Field",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Field_ProspectionId",
                table: "Field",
                column: "ProspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_prospections_ProspectionsListId",
                table: "prospections",
                column: "ProspectionsListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "companiesLists");

            migrationBuilder.DropTable(
                name: "employeesLists");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "prospections");

            migrationBuilder.DropTable(
                name: "prospectionsList");
        }
    }
}
