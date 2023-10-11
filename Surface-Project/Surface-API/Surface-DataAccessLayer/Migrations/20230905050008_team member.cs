 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class teammember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UserRoleId = table.Column<byte>(type: "tinyint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeamMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 508, DateTimeKind.Local).AddTicks(5294), new DateTime(2023, 9, 5, 10, 30, 8, 508, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 508, DateTimeKind.Local).AddTicks(5308), new DateTime(2023, 9, 5, 10, 30, 8, 508, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 508, DateTimeKind.Local).AddTicks(5313), new DateTime(2023, 9, 5, 10, 30, 8, 508, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 503, DateTimeKind.Utc).AddTicks(36), new DateTime(2023, 9, 5, 5, 0, 8, 503, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 503, DateTimeKind.Utc).AddTicks(40), new DateTime(2023, 9, 5, 5, 0, 8, 503, DateTimeKind.Utc).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(481), new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 2, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(483), new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(502), new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(507), new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(511), new DateTime(2023, 12, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(516), new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 11, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(520), new DateTime(2023, 9, 5, 10, 30, 8, 507, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4177), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4197), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4207), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.InsertData(
                table: "StatusGroups",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[] { (byte)7, new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4214), "TeamMember" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7234), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7243), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7246), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7250), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7253), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7257), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7260), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7263), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7266), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7270), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7273), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7276), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7280), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7283), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7286), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7289), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7293), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7300), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7303), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7307), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7310), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7313), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7319), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7322), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7326), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7329), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7332), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7335), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 509, DateTimeKind.Local).AddTicks(9294), new DateTime(2023, 9, 5, 10, 30, 8, 509, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 509, DateTimeKind.Local).AddTicks(9306), new DateTime(2023, 9, 5, 10, 30, 8, 509, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 509, DateTimeKind.Local).AddTicks(9310), new DateTime(2023, 9, 5, 10, 30, 8, 509, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4563), new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4567), new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4570), new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4574), new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4577), new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4579), new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4582), new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4584), new DateTime(2023, 9, 5, 5, 0, 8, 505, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 505, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 9, 5, 10, 30, 8, 505, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name", "StatusGroupId" },
                values: new object[,]
                {
                    { (byte)31, new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7339), "Active", (byte)7 },
                    { (byte)32, new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7342), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7342), "On Leave", (byte)7 },
                    { (byte)33, new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7345), "Pending", (byte)7 },
                    { (byte)34, new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7348), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7349), "Completed", (byte)7 },
                    { (byte)35, new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7352), "Resigned/Left", (byte)7 },
                    { (byte)36, new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7355), "Suspended", (byte)7 },
                    { (byte)37, new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7358), "Not Assigned", (byte)7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_StatusId",
                table: "TeamMembers",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_UserId",
                table: "TeamMembers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)31);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)32);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)33);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)34);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)35);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)36);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)37);

            migrationBuilder.DeleteData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)7);

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 834, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 9, 5, 9, 52, 51, 834, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 834, DateTimeKind.Local).AddTicks(2299), new DateTime(2023, 9, 5, 9, 52, 51, 834, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 834, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 9, 5, 9, 52, 51, 834, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 827, DateTimeKind.Utc).AddTicks(3863), new DateTime(2023, 9, 5, 4, 22, 51, 827, DateTimeKind.Utc).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 827, DateTimeKind.Utc).AddTicks(3868), new DateTime(2023, 9, 5, 4, 22, 51, 827, DateTimeKind.Utc).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(165), new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 2, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(168), new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(182), new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(187), new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(191), new DateTime(2023, 12, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(188), new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(192), new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(198), new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(201), new DateTime(2023, 11, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(199), new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(203), new DateTime(2023, 9, 5, 9, 52, 51, 832, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7782), new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7785), new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7788), new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7791), new DateTime(2023, 9, 5, 9, 52, 51, 826, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1079), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1088), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1091), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1095), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1099), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1102), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1106), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1109), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1119), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1122), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1126), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1139), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1142), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1149), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1152), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1159), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1162), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1166), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1169), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1172), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1176), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1179), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1182), new DateTime(2023, 9, 5, 9, 52, 51, 827, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2398), new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2419), new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2423), new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(867), new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(871), new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(874), new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(877), new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(883), new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(886), new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(889), new DateTime(2023, 9, 5, 4, 22, 51, 830, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 9, 52, 51, 829, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 9, 5, 9, 52, 51, 829, DateTimeKind.Local).AddTicks(8762) });
        }
    }
}
