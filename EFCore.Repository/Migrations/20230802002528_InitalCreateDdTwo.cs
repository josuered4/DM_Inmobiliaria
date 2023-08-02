using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreateDdTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Levels = table.Column<int>(type: "int", nullable: false),
                    LivingRoom = table.Column<bool>(type: "bit", nullable: false),
                    Bathrooms = table.Column<int>(type: "int", nullable: false),
                    Garden = table.Column<bool>(type: "bit", nullable: false),
                    Bedrooms = table.Column<int>(type: "int", nullable: false),
                    Kitchen = table.Column<bool>(type: "bit", nullable: false),
                    ServiceYard = table.Column<bool>(type: "bit", nullable: false),
                    ParkingLot = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amenities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
