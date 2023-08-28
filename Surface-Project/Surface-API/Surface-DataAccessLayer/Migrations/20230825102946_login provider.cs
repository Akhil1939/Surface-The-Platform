using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class loginprovider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginProviders",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginProviders_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LoginProviders",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name", "StatusId" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7140), new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7140), "Custom", (byte)1 },
                    { (byte)2, new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7142), new DateTime(2023, 8, 25, 10, 29, 46, 388, DateTimeKind.Utc).AddTicks(7142), "Google", (byte)1 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LoginProviders_Name",
                table: "LoginProviders",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoginProviders_StatusId",
                table: "LoginProviders",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginProviders");

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(819), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(832), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(834), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(836), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(838), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4969), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4984), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4986), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(4988), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5059), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5061), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5071), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5077), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5088), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5098), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 8, 25, 15, 54, 44, 190, DateTimeKind.Local).AddTicks(5100) });
        }
    }
}
