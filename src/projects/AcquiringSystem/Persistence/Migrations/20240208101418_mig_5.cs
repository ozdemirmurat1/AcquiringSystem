﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 202, 27, 120, 167, 192, 65, 74, 59, 205, 246, 111, 68, 189, 70, 113, 240, 12, 95, 247, 125, 215, 43, 151, 73, 156, 179, 199, 225, 47, 197, 72, 22, 43, 113, 52, 215, 66, 234, 60, 119, 185, 255, 223, 116, 185, 220, 119, 172, 182, 38, 245, 169, 236, 33, 56, 123, 211, 189, 145, 207, 134, 8, 174, 25 }, new byte[] { 226, 7, 167, 239, 213, 32, 30, 172, 187, 72, 58, 187, 249, 183, 43, 63, 129, 239, 156, 185, 16, 249, 238, 73, 128, 151, 200, 210, 8, 164, 157, 107, 248, 199, 32, 252, 93, 16, 180, 49, 1, 74, 168, 56, 116, 189, 209, 221, 51, 147, 190, 225, 16, 150, 157, 85, 36, 158, 251, 120, 121, 121, 165, 208, 175, 23, 236, 55, 167, 93, 5, 252, 15, 67, 172, 226, 186, 201, 110, 162, 68, 38, 145, 99, 78, 22, 198, 37, 157, 78, 181, 209, 126, 183, 121, 172, 93, 150, 255, 115, 135, 96, 129, 175, 136, 244, 32, 35, 162, 2, 128, 138, 218, 31, 110, 51, 165, 248, 152, 22, 191, 229, 79, 161, 89, 27, 135, 160 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 72, 209, 202, 164, 222, 185, 29, 227, 218, 82, 44, 98, 116, 80, 211, 246, 206, 98, 65, 179, 175, 56, 85, 210, 124, 76, 135, 150, 190, 124, 53, 150, 74, 122, 61, 188, 104, 193, 252, 15, 177, 156, 17, 168, 218, 11, 234, 0, 159, 50, 141, 2, 117, 146, 185, 227, 181, 93, 71, 107, 2, 19, 38, 97 }, new byte[] { 96, 128, 70, 154, 149, 111, 161, 178, 118, 203, 197, 249, 229, 193, 147, 1, 247, 196, 103, 195, 128, 151, 88, 231, 144, 138, 118, 172, 119, 84, 108, 205, 115, 73, 239, 6, 220, 40, 241, 147, 28, 100, 87, 113, 107, 165, 41, 215, 57, 242, 90, 128, 185, 231, 167, 144, 87, 84, 141, 182, 48, 173, 208, 56, 238, 63, 185, 31, 128, 151, 185, 33, 1, 221, 39, 206, 182, 85, 92, 150, 217, 142, 221, 170, 220, 121, 205, 6, 235, 204, 254, 207, 226, 175, 5, 222, 7, 212, 194, 15, 17, 124, 51, 179, 74, 166, 208, 230, 47, 110, 199, 197, 241, 170, 156, 19, 140, 190, 56, 211, 170, 169, 108, 233, 33, 124, 115, 122 } });
        }
    }
}