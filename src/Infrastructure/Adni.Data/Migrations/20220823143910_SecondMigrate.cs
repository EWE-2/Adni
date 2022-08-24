using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adni.Data.Migrations
{
    public partial class SecondMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_prospections_ProspectionId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Field_Department_DepartmentId",
                table: "Field");

            migrationBuilder.DropForeignKey(
                name: "FK_Field_prospections_ProspectionId",
                table: "Field");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Field",
                table: "Field");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Field",
                newName: "fields");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "departments");

            migrationBuilder.RenameIndex(
                name: "IX_Field_ProspectionId",
                table: "fields",
                newName: "IX_fields_ProspectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Field_DepartmentId",
                table: "fields",
                newName: "IX_fields_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_ProspectionId",
                table: "departments",
                newName: "IX_departments_ProspectionId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "employees",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fields",
                table: "fields",
                column: "FieldId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "DepartmentId");

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Firstname = table.Column<string>(type: "TEXT", nullable: true),
                    Lastname = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    Phonenumber = table.Column<string>(type: "TEXT", nullable: true),
                    WhatsappNumber = table.Column<string>(type: "TEXT", nullable: true),
                    DoB = table.Column<string>(type: "TEXT", nullable: true),
                    Matricule = table.Column<string>(type: "TEXT", nullable: true),
                    AcademicYear = table.Column<string>(type: "TEXT", nullable: false),
                    AcademicLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    FieldId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_departments_prospections_ProspectionId",
                table: "departments",
                column: "ProspectionId",
                principalTable: "prospections",
                principalColumn: "ProspectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_fields_departments_DepartmentId",
                table: "fields",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_fields_prospections_ProspectionId",
                table: "fields",
                column: "ProspectionId",
                principalTable: "prospections",
                principalColumn: "ProspectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_prospections_ProspectionId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_fields_departments_DepartmentId",
                table: "fields");

            migrationBuilder.DropForeignKey(
                name: "FK_fields_prospections_ProspectionId",
                table: "fields");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fields",
                table: "fields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "fields",
                newName: "Field");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_fields_ProspectionId",
                table: "Field",
                newName: "IX_Field_ProspectionId");

            migrationBuilder.RenameIndex(
                name: "IX_fields_DepartmentId",
                table: "Field",
                newName: "IX_Field_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_departments_ProspectionId",
                table: "Department",
                newName: "IX_Department_ProspectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Field",
                table: "Field",
                column: "FieldId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_prospections_ProspectionId",
                table: "Department",
                column: "ProspectionId",
                principalTable: "prospections",
                principalColumn: "ProspectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Field_Department_DepartmentId",
                table: "Field",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Field_prospections_ProspectionId",
                table: "Field",
                column: "ProspectionId",
                principalTable: "prospections",
                principalColumn: "ProspectionId");
        }
    }
}
