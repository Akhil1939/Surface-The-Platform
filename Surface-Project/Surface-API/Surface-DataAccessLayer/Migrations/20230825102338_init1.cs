using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatusGroups",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusGroups", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StatusGroups",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5317), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5327), "User" },
                    { (byte)2, new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5329), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5330), "Project" },
                    { (byte)3, new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5331), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5332), "Task" },
                    { (byte)4, new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5333), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5334), "Feature" },
                    { (byte)5, new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5335), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5335), "Bug" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatusGroups");
        }
    }
}
