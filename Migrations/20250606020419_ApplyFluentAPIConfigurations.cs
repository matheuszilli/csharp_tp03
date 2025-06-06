using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityBreaks.Migrations
{
    /// <inheritdoc />
    public partial class ApplyFluentAPIConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Cities_CityId",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "PricePerNight",
                table: "Properties",
                newName: "price_per_night");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Properties",
                newName: "property_name");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Properties",
                newName: "city_id");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_CityId",
                table: "Properties",
                newName: "IX_Properties_city_id");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Countries",
                newName: "country_name");

            migrationBuilder.RenameColumn(
                name: "CountryCode",
                table: "Countries",
                newName: "country_code");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cities",
                newName: "city_name");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Cities",
                newName: "country_id");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                newName: "IX_Cities_country_id");

            migrationBuilder.AlterColumn<decimal>(
                name: "price_per_night",
                table: "Properties",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_country_id",
                table: "Cities",
                column: "country_id",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Cities_city_id",
                table: "Properties",
                column: "city_id",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_country_id",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Cities_city_id",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "property_name",
                table: "Properties",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "price_per_night",
                table: "Properties",
                newName: "PricePerNight");

            migrationBuilder.RenameColumn(
                name: "city_id",
                table: "Properties",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_city_id",
                table: "Properties",
                newName: "IX_Properties_CityId");

            migrationBuilder.RenameColumn(
                name: "country_name",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "country_code",
                table: "Countries",
                newName: "CountryCode");

            migrationBuilder.RenameColumn(
                name: "country_id",
                table: "Cities",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "city_name",
                table: "Cities",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_country_id",
                table: "Cities",
                newName: "IX_Cities_CountryId");

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerNight",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Cities_CityId",
                table: "Properties",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
