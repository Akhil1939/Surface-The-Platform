using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class teams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teams_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teams_Users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "ModifiedBy", "ModifiedOn", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2398), 1L, new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2415), "Design", 1L },
                    { 2L, 2L, new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2419), 2L, new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2420), "Development", 1L },
                    { 3L, 3L, new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2423), 3L, new DateTime(2023, 9, 5, 9, 52, 51, 836, DateTimeKind.Local).AddTicks(2424), "Testing", 1L }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CreatedBy",
                table: "Teams",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ModifiedBy",
                table: "Teams",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProjectId",
                table: "Teams",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 440, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 9, 4, 11, 56, 51, 440, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 440, DateTimeKind.Utc).AddTicks(2151), new DateTime(2023, 9, 4, 11, 56, 51, 440, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1441), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1460), new DateTime(2024, 2, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1449), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1463), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1470), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1475), new DateTime(2023, 12, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1472), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1477), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1482), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 11, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1483), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1487), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3483), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3514), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3519), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3527), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7687), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7703), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7707), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7720), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7724), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7727), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7733), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7759), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7762), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7784), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7787), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7791), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4751), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4760), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4764), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4768), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4772), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4776), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4780), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4784), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 444, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 9, 4, 17, 26, 51, 444, DateTimeKind.Local).AddTicks(1454) });
        }
    }
}
