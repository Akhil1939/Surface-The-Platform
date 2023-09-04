using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class CustomerStory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 963, DateTimeKind.Utc).AddTicks(8451), new DateTime(2023, 9, 4, 11, 52, 16, 963, DateTimeKind.Utc).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 963, DateTimeKind.Utc).AddTicks(8455), new DateTime(2023, 9, 4, 11, 52, 16, 963, DateTimeKind.Utc).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3713), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 2, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3717), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3730), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3734), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3738), new DateTime(2023, 12, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3736), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3739), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3744), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3747), new DateTime(2023, 11, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3745), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3748), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1850), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1854), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1857), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1861), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.InsertData(
                table: "StatusGroups",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[] { (byte)6, new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1864), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1865), "Customer Story" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4756), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4765), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4773), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4776), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4783), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4794), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4797), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4801), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4804), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4807), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4811), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4838), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4842), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4845), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4849), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 966, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 9, 4, 17, 22, 16, 966, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2666), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2670), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2673), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2676), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2679), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2682), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2685), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2688), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name", "StatusGroupId" },
                values: new object[,]
                {
                    { (byte)27, new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4852), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4853), "Pending", (byte)6 },
                    { (byte)28, new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4856), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4856), "Reviewed", (byte)6 },
                    { (byte)29, new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4859), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4860), "In Progress", (byte)6 },
                    { (byte)30, new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4863), "Closed", (byte)6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30);

            migrationBuilder.DeleteData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6);

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

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2932), new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2947), new DateTime(2024, 2, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2949), new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2958), new DateTime(2023, 12, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2955), new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 11, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2964), new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2967), new DateTime(2023, 9, 4, 16, 14, 1, 485, DateTimeKind.Local).AddTicks(2962) });

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
        }
    }
}
