using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlem.Data.Migrations
{
    public partial class SimpleRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SimpleRoleId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SimpleRoleId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SimpleRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleRoles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SimpleRoleId",
                table: "Customers",
                column: "SimpleRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_SimpleRoleId",
                table: "Clients",
                column: "SimpleRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleRoles_IsDeleted",
                table: "SimpleRoles",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_SimpleRoles_SimpleRoleId",
                table: "Clients",
                column: "SimpleRoleId",
                principalTable: "SimpleRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SimpleRoles_SimpleRoleId",
                table: "Customers",
                column: "SimpleRoleId",
                principalTable: "SimpleRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_SimpleRoles_SimpleRoleId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SimpleRoles_SimpleRoleId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "SimpleRoles");

            migrationBuilder.DropIndex(
                name: "IX_Customers_SimpleRoleId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Clients_SimpleRoleId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SimpleRoleId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SimpleRoleId",
                table: "Clients");
        }
    }
}
