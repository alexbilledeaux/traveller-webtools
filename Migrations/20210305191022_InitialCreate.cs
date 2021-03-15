using Microsoft.EntityFrameworkCore.Migrations;

namespace Traveller.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Atmosphere = table.Column<int>(type: "int", nullable: false),
                    Hydrology = table.Column<int>(type: "int", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    Government = table.Column<int>(type: "int", nullable: false),
                    Law_Level = table.Column<int>(type: "int", nullable: false),
                    Starport = table.Column<int>(type: "int", nullable: false),
                    Technology_Level = table.Column<int>(type: "int", nullable: false),
                    Pirate_Base = table.Column<bool>(type: "bit", nullable: false),
                    TAS_Base = table.Column<bool>(type: "bit", nullable: false),
                    Naval_Base = table.Column<bool>(type: "bit", nullable: false),
                    Scout_Base = table.Column<bool>(type: "bit", nullable: false),
                    Research_Base = table.Column<bool>(type: "bit", nullable: false),
                    Imperial_Base = table.Column<bool>(type: "bit", nullable: false),
                    Size_As_Km = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hydrographic_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surface_Gravity_As_Double = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atmosphere_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Government_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Government_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technology_Level_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surface_CSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size_CSS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planet");
        }
    }
}
