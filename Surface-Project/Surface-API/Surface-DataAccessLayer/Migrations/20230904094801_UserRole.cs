using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class UserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 502, DateTimeKind.Utc).AddTicks(9532), new DateTime(2023, 9, 4, 9, 48, 1, 502, DateTimeKind.Utc).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 502, DateTimeKind.Utc).AddTicks(9536), new DateTime(2023, 9, 4, 9, 48, 1, 502, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8246), new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8251), new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8256), new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8260), new DateTime(2023, 9, 4, 15, 18, 1, 501, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2866), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2871), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2875), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2879), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2884), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2888), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2892), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2908), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2928), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2932), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2935), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2944), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2948), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 9, 4, 15, 18, 1, 502, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 18, 1, 505, DateTimeKind.Local).AddTicks(4124), new DateTime(2023, 9, 4, 15, 18, 1, 505, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6225), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6226), "ProjectManager" },
                    { (byte)2, new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6229), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6229), "ProjectMember" },
                    { (byte)3, new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6232), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6232), "ProjectViewer" },
                    { (byte)4, new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6235), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6235), "ProjectAdmin" },
                    { (byte)5, new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6237), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6238), "TeamLeader" },
                    { (byte)6, new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6240), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6241), "Developer" },
                    { (byte)7, new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6243), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6244), "QAEngineer" },
                    { (byte)8, new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6246), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6247), "BusinessAnalyst" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_Name",
                table: "UserRole",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 7, 46, 54, 109, DateTimeKind.Utc).AddTicks(5709), new DateTime(2023, 9, 2, 7, 46, 54, 109, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 7, 46, 54, 109, DateTimeKind.Utc).AddTicks(5713), new DateTime(2023, 9, 2, 7, 46, 54, 109, DateTimeKind.Utc).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3060), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3083), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7686), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7701), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7704), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7708), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7711), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7715), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7719), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7726), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7733), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7761), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7769), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7776), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7779), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7783), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7786), new DateTime(2023, 9, 2, 13, 16, 54, 102, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 112, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 9, 2, 13, 16, 54, 112, DateTimeKind.Local).AddTicks(6283) });
        }
    }
}
