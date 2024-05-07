using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieManagement.Persistance.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "DirectorName_FirstName", "DirectorName_LastName" },
                values: new object[] { 1, new DateTime(2024, 5, 7, 11, 52, 25, 682, DateTimeKind.Local).AddTicks(7873), null, null, null, null, null, 1, "Andrzej", "Wajda" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "CreatedBy", "DirectorId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "PremiereYear", "StatusId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, null, null, null, "Pan Tadeusz", 0, 0 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "CreatedBy", "DirectorId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "PremiereYear", "StatusId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, null, null, null, "Popiół i Diament", 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
