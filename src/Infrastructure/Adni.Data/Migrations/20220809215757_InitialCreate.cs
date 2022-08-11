﻿using System;
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
                    DoB = table.Column<DateTime>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_companies_CompaniesListId",
                table: "companies",
                column: "CompaniesListId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_EmployeesListId",
                table: "employees",
                column: "EmployeesListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "companiesLists");

            migrationBuilder.DropTable(
                name: "employeesLists");
        }
    }
}