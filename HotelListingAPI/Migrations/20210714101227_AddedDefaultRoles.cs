using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListingAPI.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "984a72ac-2534-4cc9-99a3-87bec8a3a70e", "3e4ecc0f-1711-453c-a9d8-052415527d3a", "User", "USER" },
                    { "ab415330-2716-4517-8645-86e13d7ad9d7", "4b41b656-fa99-439b-bbfe-6b9c6bb2ec68", "Administrator", "ADMINISTRATOR" },
                    { "d2f654be-5858-4a95-a545-f1ff9b40883a", "2d1395a3-f343-4cb9-88e9-e4269b077257", "Guest", "GUEST" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 4, "Tanzania", "TZ" },
                    { 5, "Mauritius", "MUS" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 4, "Zanzibar-Bwejuu", 4, "Baraza Resort & Spa", 4.5 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 5, "North Coast", 5, "Grand Gaube", 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "984a72ac-2534-4cc9-99a3-87bec8a3a70e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab415330-2716-4517-8645-86e13d7ad9d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2f654be-5858-4a95-a545-f1ff9b40883a");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
