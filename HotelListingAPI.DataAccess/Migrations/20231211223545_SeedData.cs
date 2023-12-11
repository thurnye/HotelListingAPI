using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListingAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "Countries",
                newName: "ISOCode");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ISOCode", "Name" },
                values: new object[,]
                {
                    { 4, "ATG", "Antigua and Barbuda" },
                    { 5, "AIA", "Anguilla" },
                    { 14, "ABW", "Aruba" },
                    { 18, "BRB", "Barbados" },
                    { 26, "BLM", "Saint Barthélemy" },
                    { 27, "BMU", "Bermuda" },
                    { 30, "BES", "Bonaire, Sint Eustatius and Saba" },
                    { 32, "BHS", "Bahamas" },
                    { 37, "BLZ", "Belize" },
                    { 38, "CAN", "Canada" },
                    { 50, "CRI", "Costa Rica" },
                    { 51, "CUB", "Cuba" },
                    { 53, "CUW", "Curaçao" },
                    { 60, "DMA", "Dominica" },
                    { 61, "DOM", "Dominican Republic" },
                    { 78, "GRD", "Grenada" },
                    { 84, "GRL", "Greenland" },
                    { 87, "GLP", "Guadeloupe" },
                    { 91, "GTM", "Guatemala" },
                    { 97, "HND", "Honduras" },
                    { 99, "HTI", "Haiti" },
                    { 112, "JAM", "Jamaica" },
                    { 120, "KNA", "Saint Kitts and Nevis" },
                    { 124, "CYM", "Cayman Islands" },
                    { 128, "LCA", "Saint Lucia" },
                    { 141, "MAF", "Saint Martin" },
                    { 150, "MTQ", "Martinique" },
                    { 152, "MSR", "Montserrat" },
                    { 157, "MEX", "Mexico" },
                    { 165, "NIC", "Nicaragua" },
                    { 173, "PAN", "Panama" },
                    { 180, "SPM", "Saint Pierre and Miquelon" },
                    { 182, "PRI", "Puerto Rico" },
                    { 210, "SLV", "El Salvador" },
                    { 211, "SXM", "Sint Maarten" },
                    { 214, "TCA", "Turks and Caicos Islands" },
                    { 226, "TTO", "Trinidad and Tobago" },
                    { 233, "USA", "United States" },
                    { 237, "VCT", "Saint Vincent and the Grenadines" },
                    { 239, "VGB", "British Virgin Islands" },
                    { 240, "VIR", "U.S. Virgin Islands" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Toronto", 38, "Sandfals Resort and Spa", 4.5 },
                    { 2, "Toronto", 38, "Hotel 2", 4.5 },
                    { 3, "Toronto", 38, "Hotel 3", 4.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.RenameColumn(
                name: "ISOCode",
                table: "Countries",
                newName: "ShortName");
        }
    }
}
