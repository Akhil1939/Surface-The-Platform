using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class projectteamteammemeberdeletebehaviouradded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 96, DateTimeKind.Utc).AddTicks(5143), new DateTime(2023, 11, 24, 5, 8, 12, 96, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 96, DateTimeKind.Utc).AddTicks(5145), new DateTime(2023, 11, 24, 5, 8, 12, 96, DateTimeKind.Utc).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4918), new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 4, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4921), new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4932), new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 2, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4933), new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4935), new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 1, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4938), new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1537), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1542), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1544), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1545), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3453), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3455), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3457), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3461), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3466), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3470), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3478), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3482), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3484), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3486), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3488), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3490), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3492), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3494), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3496), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3498), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3500), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3502), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3505), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3511), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3513), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3517), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3519), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3521), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8284), new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8291), new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8293), new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5136), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5138), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5140), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5142), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5144), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5145), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5147), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5149), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 11, 24, 10, 38, 12, 98, DateTimeKind.Local).AddTicks(441), new DateTime(2023, 11, 24, 10, 38, 12, 98, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Projects_ProjectId",
                table: "Teams",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
