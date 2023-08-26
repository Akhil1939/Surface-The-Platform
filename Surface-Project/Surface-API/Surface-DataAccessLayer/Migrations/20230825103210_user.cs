using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginProviderId = table.Column<byte>(type: "tinyint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    AccessFailedCount = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)0),
                    LockedOutEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MustChangePassword = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getutcdate())"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getutcdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_LoginProviders_LoginProviderId",
                        column: x => x.LoginProviderId,
                        principalTable: "LoginProviders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Avatar", "CreatedOn", "Email", "LockedOutEndDate", "LoginProviderId", "ModifiedOn", "Password", "Salt", "StatusId" },
                values: new object[] { 1L, "", new DateTime(2023, 8, 25, 16, 2, 9, 968, DateTimeKind.Local).AddTicks(5101), "admin@gmail.com", null, (byte)1, new DateTime(2023, 8, 25, 16, 2, 9, 968, DateTimeKind.Local).AddTicks(5108), "5652DDF6EA419A920A948A4BBA99A1B48B434D1237218FCF8D2DA2DA41E7C0F4046BC10C12ABDA86D09022B2AD1D6F566F82F3DF72CDFAEE40AB154537DFB8FD", "+QA9bkBDYMlaPDTRzIYMoPeMDd9oa9k/Ay4Lg==", (byte)1 });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_LoginProviderId",
                table: "User",
                column: "LoginProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_User_StatusId",
                table: "User",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7140), new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7142), new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1878), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1890), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1892), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1894), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1896), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3713), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3718), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3720), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3722), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3724), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3766), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3772), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3773), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3775), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3777), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3779), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3781), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3783), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3785), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3787), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3789), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3791), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3793), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3795), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3797), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3798), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3800), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3803), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3805), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3807), new DateTime(2023, 8, 25, 15, 59, 46, 388, DateTimeKind.Local).AddTicks(3807) });
        }
    }
}
