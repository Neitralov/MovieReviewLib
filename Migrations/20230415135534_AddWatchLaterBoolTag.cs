using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieReviewLib.Migrations
{
    /// <inheritdoc />
    public partial class AddWatchLaterBoolTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "WatchLater",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WatchLater",
                table: "Movies");
        }
    }
}
