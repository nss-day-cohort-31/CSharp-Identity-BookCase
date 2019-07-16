﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookCase.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "ebde3fc4-1db2-4edb-8b97-d71a375f957a", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEP5GDep07tMlu86mF/0vGSSJkcruwdT7Jtw7CnuJ9RB513EhMexQ67rTzuYcEUuopQ==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "Genre", "LastName", "PenName" },
                values: new object[] { 1, "Stephen", "Horror", "King", "Richard Bachman" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "Genre", "Isbn", "OwnerId", "PublishDate", "Title" },
                values: new object[] { 1, 1, null, "1234512345", "00000000-ffff-ffff-ffff-ffffffffffff", new DateTime(1988, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
