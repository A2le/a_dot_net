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
                name: "Musica_CDs",
                columns: table => new
                {
                    album_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    album_name = table.Column<string>(type: "TEXT", nullable: false),
                    artist_name = table.Column<String>(type: "TEXT", nullable: false),
                    genre = table.Column<String>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musica_CDs", x => x.album_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musica_CDs");
        }
    }
}
