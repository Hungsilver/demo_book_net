using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_ASP.NET_CORE.Migrations
{
    /// <inheritdoc />
    public partial class mappingBook1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TheLoaiId",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TheLoaiId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
