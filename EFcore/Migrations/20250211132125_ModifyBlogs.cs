using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    /// <inheritdoc />
    public partial class ModifyBlogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "url",
                table: "Blogs",
                type:"nvarchar(max)",
                defaultValue:"",
                nullable: false, // This ensures NOT NULL in the DB
                oldClrType: typeof(string),
                oldNullable: true);
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "url",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true, // This ensures NOT NULL in the DB
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: false);
        }

    }
}
