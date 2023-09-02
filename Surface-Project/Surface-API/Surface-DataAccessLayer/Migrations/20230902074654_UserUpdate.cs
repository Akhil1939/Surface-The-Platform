using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class UserUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreatedOn", "FirstName", "LastName", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 2, 13, 16, 54, 112, DateTimeKind.Local).AddTicks(6268), "admin", null, new DateTime(2023, 9, 2, 13, 16, 54, 112, DateTimeKind.Local).AddTicks(6283) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "User");

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 7, 8, 52, 462, DateTimeKind.Utc).AddTicks(261), new DateTime(2023, 8, 27, 7, 8, 52, 462, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 7, 8, 52, 462, DateTimeKind.Utc).AddTicks(266), new DateTime(2023, 8, 27, 7, 8, 52, 462, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1833), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1840), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1843), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4648), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4652), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4655), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4658), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4662), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4665), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4668), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4678), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4681), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4687), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4691), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4694), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4697), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4703), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4707), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4713), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4717), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4726), new DateTime(2023, 8, 27, 12, 38, 52, 460, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 471, DateTimeKind.Local).AddTicks(85), new DateTime(2023, 8, 27, 12, 38, 52, 471, DateTimeKind.Local).AddTicks(97) });
        }
    }
}
