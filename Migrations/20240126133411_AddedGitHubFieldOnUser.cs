using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FundamentosEF_Blog.Migrations
{
    /// <inheritdoc />
    public partial class AddedGitHubFieldOnUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "User",
                type: "VARCHAR(2083)",
                maxLength: 2083,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 13, 34, 11, 186, DateTimeKind.Utc).AddTicks(3637),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2024, 1, 25, 18, 33, 40, 833, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 13, 34, 11, 186, DateTimeKind.Utc).AddTicks(2339),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2024, 1, 25, 18, 33, 40, 833, DateTimeKind.Utc).AddTicks(3753));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 18, 33, 40, 833, DateTimeKind.Utc).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2024, 1, 26, 13, 34, 11, 186, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 18, 33, 40, 833, DateTimeKind.Utc).AddTicks(3753),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2024, 1, 26, 13, 34, 11, 186, DateTimeKind.Utc).AddTicks(2339));
        }
    }
}
