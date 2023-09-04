using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RepoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<double>(type: "float", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Project_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Project_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 480, DateTimeKind.Utc).AddTicks(9623), new DateTime(2023, 9, 4, 10, 44, 1, 480, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 480, DateTimeKind.Utc).AddTicks(9627), new DateTime(2023, 9, 4, 10, 44, 1, 480, DateTimeKind.Utc).AddTicks(9627) });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "ActualEndDate", "ActualStartDate", "Budget", "CreatedBy", "CreatedOn", "Description", "EndDate", "ModifiedBy", "ModifiedOn", "Name", "RepoLink", "StartDate", "StatusId" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2932), 5000.0, 1L, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2947), "This is a demo project that all users are in this project", new DateTime(2024, 2, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2936), 1L, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2949), "Surface", null, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2920), (byte)8 },
                    { 2L, null, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2954), 10000.0, 4L, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2958), "A new development project", new DateTime(2023, 12, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2955), 4L, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2959), "Project A", "https://github.com/projecta", new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2953), (byte)8 },
                    { 3L, null, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2963), 7500.0, 3L, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2966), "Another project for testing", new DateTime(2023, 11, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2964), 3L, new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2967), "Project B", "https://github.com/projectb", new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2962), (byte)8 }
                });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4111), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4130), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4133), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4136), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4140), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6892), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6896), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6900), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6903), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6907), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6911), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6914), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6918), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6921), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6924), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6928), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6931), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6935), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6938), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6941), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6945), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6948), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6952), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6955), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6958), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6961), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6965), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6968), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6972), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6975), new DateTime(2023, 9, 4, 16, 14, 1, 480, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 483, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 9, 4, 16, 14, 1, 483, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6396), new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6400), new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6403), new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6406), new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6409), new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6412), new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6415), new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6418), new DateTime(2023, 9, 4, 10, 44, 1, 483, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.CreateIndex(
                name: "IX_Project_CreatedBy",
                table: "Project",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ModifiedBy",
                table: "Project",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Project_StatusId",
                table: "Project",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

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

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6225), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6229), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6232), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6235), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6237), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6240), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6243), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6246), new DateTime(2023, 9, 4, 9, 48, 1, 505, DateTimeKind.Utc).AddTicks(6247) });
        }
    }
}
