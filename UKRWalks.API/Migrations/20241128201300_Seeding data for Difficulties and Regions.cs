using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UKRWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingdataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3bfd4e70-9d17-4a45-85e6-bac5eff4fb6d"), "Easy" },
                    { new Guid("51ef0d6a-2c24-4c04-a626-4125aa2a2dc4"), "Medium" },
                    { new Guid("609c4904-e7f2-4a96-97da-6ee03e4e0a1a"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("34d44f1e-4747-45bb-9f1b-f5f2f450f10a"), "UA-LV", "Lviv", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Lviv_in_Ukraine.svg/1200px-Lviv_in_Ukraine.svg.png" },
                    { new Guid("3550e2e4-37cd-40a7-aeed-57fa6f6fc328"), "UA-KH", "Kharkiv", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Kharkiv_in_Ukraine.svg/1200px-Kharkiv_in_Ukraine.svg.png" },
                    { new Guid("3ea8ea23-cc61-4c60-a4cd-84e3a261b2bf"), "UA-OD", "Odesa", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Odessa_in_Ukraine.svg/1200px-Odessa_in_Ukraine.svg.png" },
                    { new Guid("779139d1-9db8-4c4c-a71f-e320193c7d57"), "UA-VN", "Vinnytsia", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Vinnytsia_in_Ukraine.svg/1200px-Vinnytsia_in_Ukraine.svg.png" },
                    { new Guid("80530b8c-ce14-4895-8edc-4bf20e86a460"), "UA-KY", "Kyiv", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Kyiv_%28oblast%29_in_Ukraine.svg/1200px-Kyiv_%28oblast%29_in_Ukraine.svg.png" },
                    { new Guid("9fe6971e-e9c3-454f-906c-0d20b10d108c"), "UA-IF", "Ivano-Frankivsk", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Ivano-Frankivsk_in_Ukraine.svg/275px-Ivano-Frankivsk_in_Ukraine.svg.png" },
                    { new Guid("cf973bc0-4e43-4025-b65a-6fabb66ae76c"), "UA-ZP", "Zaporizhzhia", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Zaporizhia_in_Ukraine.svg/1200px-Zaporizhia_in_Ukraine.svg.png" },
                    { new Guid("d3bab1cc-3c75-4b79-bb25-1c9118404e27"), "UA-DP", "Dnipro", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Dnipropetrovsk_in_Ukraine.svg/1200px-Dnipropetrovsk_in_Ukraine.svg.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("3bfd4e70-9d17-4a45-85e6-bac5eff4fb6d"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("51ef0d6a-2c24-4c04-a626-4125aa2a2dc4"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("609c4904-e7f2-4a96-97da-6ee03e4e0a1a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("34d44f1e-4747-45bb-9f1b-f5f2f450f10a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3550e2e4-37cd-40a7-aeed-57fa6f6fc328"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3ea8ea23-cc61-4c60-a4cd-84e3a261b2bf"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("779139d1-9db8-4c4c-a71f-e320193c7d57"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("80530b8c-ce14-4895-8edc-4bf20e86a460"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("9fe6971e-e9c3-454f-906c-0d20b10d108c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cf973bc0-4e43-4025-b65a-6fabb66ae76c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d3bab1cc-3c75-4b79-bb25-1c9118404e27"));
        }
    }
}
