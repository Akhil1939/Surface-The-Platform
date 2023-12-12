using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class TeamMembertableanduseravtar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VerificationToken",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 834, DateTimeKind.Utc).AddTicks(2203), new DateTime(2023, 11, 28, 5, 49, 32, 834, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 834, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 11, 28, 5, 49, 32, 834, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5938), new DateTime(2024, 4, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5943), new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5945), new DateTime(2024, 2, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5944), new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5946), new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5950), new DateTime(2024, 1, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5951), new DateTime(2023, 11, 28, 11, 19, 32, 837, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7762), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7764), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9933), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9936), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9938), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9940), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9982), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9985), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9989), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9994), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 11, 28, 11, 19, 32, 833, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(2), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(4), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(6), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(8), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(10), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(13), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(17), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(19), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(21), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(23), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(27), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(31), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(34), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(36), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(38), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(40), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(42), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(45), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(47), new DateTime(2023, 11, 28, 11, 19, 32, 834, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 840, DateTimeKind.Local).AddTicks(1212), new DateTime(2023, 11, 28, 11, 19, 32, 840, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 840, DateTimeKind.Local).AddTicks(1222), new DateTime(2023, 11, 28, 11, 19, 32, 840, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 840, DateTimeKind.Local).AddTicks(1225), new DateTime(2023, 11, 28, 11, 19, 32, 840, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2155), new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2159), new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2165), new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2167), new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 11, 28, 5, 49, 32, 836, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 19, 32, 836, DateTimeKind.Local).AddTicks(862), new DateTime(2023, 11, 28, 11, 19, 32, 836, DateTimeKind.Local).AddTicks(871) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerificationToken",
                table: "TeamMembers");

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 623, DateTimeKind.Utc).AddTicks(5098), new DateTime(2023, 11, 27, 4, 13, 37, 623, DateTimeKind.Utc).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 623, DateTimeKind.Utc).AddTicks(5101), new DateTime(2023, 11, 27, 4, 13, 37, 623, DateTimeKind.Utc).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6674), new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6687), new DateTime(2024, 4, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6676), new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6688), new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6691), new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6694), new DateTime(2024, 2, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6692), new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6697), new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 1, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6698), new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6701), new DateTime(2023, 11, 27, 9, 43, 37, 626, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(364), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(385), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(391), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3087), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3093), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3102), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3110), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3117), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3121), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3125), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3127), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3129), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3137), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3139), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3141), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3146), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3148), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3150), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3152), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3154), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3156), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3158), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3160), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3162), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3164), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3166), new DateTime(2023, 11, 27, 9, 43, 37, 623, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 628, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 11, 27, 9, 43, 37, 628, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 628, DateTimeKind.Local).AddTicks(8921), new DateTime(2023, 11, 27, 9, 43, 37, 628, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 628, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 11, 27, 9, 43, 37, 628, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2973), new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2976), new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2979), new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2981), new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2983), new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2984), new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2986), new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2988), new DateTime(2023, 11, 27, 4, 13, 37, 625, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 27, 9, 43, 37, 625, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 11, 27, 9, 43, 37, 625, DateTimeKind.Local).AddTicks(1822) });
        }
    }
}
