using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adni.Data.Migrations
{
    public partial class UpdatingInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fields_prospections_ProspectionId",
                table: "fields");

            migrationBuilder.DropIndex(
                name: "IX_fields_ProspectionId",
                table: "fields");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "prospections");

            migrationBuilder.DropColumn(
                name: "ProspectionId",
                table: "fields");

            migrationBuilder.AddColumn<Guid>(
                name: "InternshipPlacementId",
                table: "students",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AcademicYear",
                table: "prospections",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "FieldId",
                table: "PlacesDisponibles",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "internshipPlacements",
                columns: table => new
                {
                    InternshipPlacementId = table.Column<Guid>(type: "uuid", nullable: false),
                    InternType = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsSend = table.Column<bool>(type: "boolean", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IntershipDcm = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_internshipPlacements", x => x.InternshipPlacementId);
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

            migrationBuilder.CreateIndex(
                name: "IX_students_InternshipPlacementId",
                table: "students",
                column: "InternshipPlacementId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_internshipPlacements_InternshipPlacementId",
                table: "students",
                column: "InternshipPlacementId",
                principalTable: "internshipPlacements",
                principalColumn: "InternshipPlacementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_internshipPlacements_InternshipPlacementId",
                table: "students");

            migrationBuilder.DropTable(
                name: "attributions");

            migrationBuilder.DropTable(
                name: "internshipPlacements");

            migrationBuilder.DropTable(
                name: "internshipReports");

            migrationBuilder.DropTable(
                name: "internships");

            migrationBuilder.DropIndex(
                name: "IX_students_InternshipPlacementId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "InternshipPlacementId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "AcademicYear",
                table: "prospections");

            migrationBuilder.DropColumn(
                name: "FieldId",
                table: "PlacesDisponibles");

            migrationBuilder.AddColumn<Guid>(
                name: "SessionId",
                table: "prospections",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProspectionId",
                table: "fields",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_fields_ProspectionId",
                table: "fields",
                column: "ProspectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_fields_prospections_ProspectionId",
                table: "fields",
                column: "ProspectionId",
                principalTable: "prospections",
                principalColumn: "ProspectionId");
        }
    }
}
