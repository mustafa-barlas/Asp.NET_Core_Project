﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class update_portfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Portfolios",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Portfolios",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Portfolios",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Portfolios",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Portfolios",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Portfolios",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Portfolios",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Portfolios",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Portfolios");
        }
    }
}
