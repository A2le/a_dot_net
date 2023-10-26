using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DOT_NET.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "albums",
                columns: table => new
                {
                    Album_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Album_name = table.Column<string>(type: "TEXT", nullable: false),
                    Artist_name = table.Column<String>(type: "TEXT", nullable: false),
                    Genre = table.Column<String>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albums", x => x.Album_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "albums");
        }
    }
}
