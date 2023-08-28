using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class UsertokenAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MustChangePassword",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreatedOn", "ModifiedOn", "Token" },
                values: new object[] { new DateTime(2023, 8, 27, 12, 38, 52, 471, DateTimeKind.Local).AddTicks(85), new DateTime(2023, 8, 27, 12, 38, 52, 471, DateTimeKind.Local).AddTicks(97), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "User");

            migrationBuilder.AddColumn<bool>(
                name: "MustChangePassword",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 32, 9, 965, DateTimeKind.Utc).AddTicks(9406), new DateTime(2023, 8, 25, 10, 32, 9, 965, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 32, 9, 965, DateTimeKind.Utc).AddTicks(9408), new DateTime(2023, 8, 25, 10, 32, 9, 965, DateTimeKind.Utc).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6388), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6400), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6402), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6404), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6406), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8030), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8035), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8043), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8046), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8048), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8050), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8052), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8054), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8056), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8058), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8060), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8062), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8064), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8066), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8072), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8074), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8076), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8078), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8080), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8081), new DateTime(2023, 8, 25, 16, 2, 9, 965, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 2, 9, 968, DateTimeKind.Local).AddTicks(5101), new DateTime(2023, 8, 25, 16, 2, 9, 968, DateTimeKind.Local).AddTicks(5108) });
        }
    }
}
