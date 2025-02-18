﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pruebaApiBackend.Migrations
{
    /// <inheritdoc />
    public partial class createpruebaproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Product");
        }
    }
}
