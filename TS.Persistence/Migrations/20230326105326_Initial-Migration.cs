using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<int>(type: "int", nullable: false),
                    Longitude = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ports", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<int>(type: "int", nullable: false),
                    Longitude = table.Column<int>(type: "int", nullable: false),
                    Velocity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Ports",
                columns: new[] { "ID", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { 1, 90, 100, "Port 1" },
                    { 2, 120, 130, "Port 2" },
                    { 3, 70, 150, "Port 3" }
                });

            migrationBuilder.InsertData(
                table: "Ships",
                columns: new[] { "ID", "Latitude", "Longitude", "Name", "Velocity" },
                values: new object[,]
                {
                    { 1, 20, 30, "Ship 1", 0m },
                    { 2, 40, 25, "Ship 2", 0m },
                    { 3, 26, 57, "Ship 3", 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ports");

            migrationBuilder.DropTable(
                name: "Ships");
        }
    }
}
