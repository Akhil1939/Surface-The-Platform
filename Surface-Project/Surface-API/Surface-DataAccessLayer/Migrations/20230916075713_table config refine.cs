using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class tableconfigrefine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 268, DateTimeKind.Local).AddTicks(6739), new DateTime(2023, 9, 16, 13, 27, 13, 268, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 268, DateTimeKind.Local).AddTicks(6759), new DateTime(2023, 9, 16, 13, 27, 13, 268, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "CustomerStories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 268, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 9, 16, 13, 27, 13, 268, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 260, DateTimeKind.Utc).AddTicks(2470), new DateTime(2023, 9, 16, 7, 57, 13, 260, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 260, DateTimeKind.Utc).AddTicks(2474), new DateTime(2023, 9, 16, 7, 57, 13, 260, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3272), new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3286), new DateTime(2024, 2, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3276), new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3288), new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3293), new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 12, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3294), new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3306), new DateTime(2023, 11, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3307), new DateTime(2023, 9, 16, 13, 27, 13, 265, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6473), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6476), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6479), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6482), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6486), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6488), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9819), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9830), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9834), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9837), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9840), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9844), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9850), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9853), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9857), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9864), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9867), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9870), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9876), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9980), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 259, DateTimeKind.Local).AddTicks(9999), new DateTime(2023, 9, 16, 13, 27, 13, 260, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 260, DateTimeKind.Local).AddTicks(3), new DateTime(2023, 9, 16, 13, 27, 13, 260, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 260, DateTimeKind.Local).AddTicks(6), new DateTime(2023, 9, 16, 13, 27, 13, 260, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 270, DateTimeKind.Local).AddTicks(1362), new DateTime(2023, 9, 16, 13, 27, 13, 270, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 270, DateTimeKind.Local).AddTicks(1372), new DateTime(2023, 9, 16, 13, 27, 13, 270, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 270, DateTimeKind.Local).AddTicks(1376), new DateTime(2023, 9, 16, 13, 27, 13, 270, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6081), new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6085), new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6088), new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6091), new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6093), new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6096), new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6099), new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6102), new DateTime(2023, 9, 16, 7, 57, 13, 263, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 16, 13, 27, 13, 263, DateTimeKind.Local).AddTicks(3896), new DateTime(2023, 9, 16, 13, 27, 13, 263, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStories_ProjectId",
                table: "CustomerStories",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerStories_Projects_ProjectId",
                table: "CustomerStories",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_Teams_TeamId",
                table: "TeamMembers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerStories_Projects_ProjectId",
                table: "CustomerStories");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_Teams_TeamId",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerStories_ProjectId",
                table: "CustomerStories");

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

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(4214) });

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
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7342), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7348), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 9, 5, 10, 30, 8, 502, DateTimeKind.Local).AddTicks(7358) });

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
        }
    }
}
