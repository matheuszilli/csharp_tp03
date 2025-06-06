using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CityBreaks.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "country_code", "country_name" },
                values: new object[,]
                {
                    { 1, "BR", "Brasil" },
                    { 2, "US", "Estados Unidos" },
                    { 3, "FR", "França" },
                    { 4, "IT", "Itália" },
                    { 5, "ES", "Espanha" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "country_id", "city_name" },
                values: new object[,]
                {
                    { 1, 1, "São Paulo" },
                    { 2, 1, "Rio de Janeiro" },
                    { 3, 1, "Salvador" },
                    { 4, 2, "New York" },
                    { 5, 2, "Los Angeles" },
                    { 6, 2, "Miami" },
                    { 7, 3, "Paris" },
                    { 8, 3, "Nice" },
                    { 9, 4, "Roma" },
                    { 10, 4, "Milão" },
                    { 11, 5, "Madrid" },
                    { 12, 5, "Barcelona" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "city_id", "property_name", "price_per_night" },
                values: new object[,]
                {
                    { 1, 1, "Hotel Paulistano", 850.00m },
                    { 2, 1, "Pousada Cóe Velhote", 280.00m },
                    { 3, 2, "Hotel Copacabana", 1200.00m },
                    { 4, 2, "Apartamento em Take a Fire (Botafogo)", 450.00m },
                    { 5, 4, "The Plaza Hotel", 2500.00m },
                    { 6, 4, "Brooklyn Apartment", 180.00m },
                    { 7, 7, "Hotel França", 1800.00m },
                    { 8, 7, "Apartamento Torre", 320.00m },
                    { 9, 9, "Hotel de Italia", 1100.00m },
                    { 10, 9, "B&B Centro Histórico", 150.00m },
                    { 11, 12, "Hotel Casa Fuster", 480.00m },
                    { 12, 12, "Apartamento Sagrada Família", 95.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

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
