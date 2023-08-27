using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusGroupId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statuses_StatusGroups_StatusGroupId",
                        column: x => x.StatusGroupId,
                        principalTable: "StatusGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(819), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(832), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(834), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(836), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(838), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name", "StatusGroupId" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4969), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4982), "Active", (byte)1 },
                    { (byte)2, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4984), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4984), "Inactive", (byte)1 },
                    { (byte)3, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4986), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4986), "Reported", (byte)1 },
                    { (byte)4, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4988), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5047), "Blocked", (byte)1 },
                    { (byte)5, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5059), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5060), "Deleted", (byte)1 },
                    { (byte)6, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5061), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5062), "Locked", (byte)1 },
                    { (byte)7, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5064), "Planning", (byte)2 },
                    { (byte)8, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5065), "Active", (byte)2 },
                    { (byte)9, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5067), "On Hold", (byte)2 },
                    { (byte)10, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5069), "Completed", (byte)2 },
                    { (byte)11, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5071), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5071), "Cancelled", (byte)2 },
                    { (byte)12, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5073), "To Do", (byte)3 },
                    { (byte)13, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5075), "In Progress", (byte)3 },
                    { (byte)14, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5077), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5077), "Blocked", (byte)3 },
                    { (byte)15, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5079), "Completed", (byte)3 },
                    { (byte)16, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5081), "Deferred", (byte)3 },
                    { (byte)17, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5083), "Idea", (byte)4 },
                    { (byte)18, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5085), "Backlog", (byte)4 },
                    { (byte)19, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5087), "In Progress", (byte)4 },
                    { (byte)20, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5088), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5089), "Testing", (byte)4 },
                    { (byte)21, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5091), "Released", (byte)4 },
                    { (byte)22, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5092), "Reported", (byte)5 },
                    { (byte)23, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5094), "In Progress", (byte)5 },
                    { (byte)24, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5096), "Reproduced", (byte)5 },
                    { (byte)25, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5098), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5098), "Fixed", (byte)5 },
                    { (byte)26, new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5100), "Verified", (byte)5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_StatusGroupId",
                table: "Statuses",
                column: "StatusGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5317), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5329), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5331), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5333), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5335), new DateTime(2023, 8, 25, 15, 53, 38, 200, DateTimeKind.Local).AddTicks(5335) });
        }
    }
}
