using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieReviewLib.Migrations
{
    /// <inheritdoc />
    public partial class AddPublishDateTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "Movies",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "Movies");
        }
    }
}
