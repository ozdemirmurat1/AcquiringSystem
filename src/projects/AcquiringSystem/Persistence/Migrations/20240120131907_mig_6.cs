using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MerchantId",
                table: "Terminals",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Terminals_MerchantId",
                table: "Terminals",
                column: "MerchantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Terminals_Merchants_MerchantId",
                table: "Terminals",
                column: "MerchantId",
                principalTable: "Merchants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Terminals_Merchants_MerchantId",
                table: "Terminals");

            migrationBuilder.DropIndex(
                name: "IX_Terminals_MerchantId",
                table: "Terminals");

            migrationBuilder.DropColumn(
                name: "MerchantId",
                table: "Terminals");
        }
    }
}
