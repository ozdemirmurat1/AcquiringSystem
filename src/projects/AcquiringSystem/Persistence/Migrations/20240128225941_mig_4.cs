using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "chains.admin", null },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "chains.read", null },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "chains.write", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "chains.add", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "chains.update", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "chains.delete", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 72, 209, 202, 164, 222, 185, 29, 227, 218, 82, 44, 98, 116, 80, 211, 246, 206, 98, 65, 179, 175, 56, 85, 210, 124, 76, 135, 150, 190, 124, 53, 150, 74, 122, 61, 188, 104, 193, 252, 15, 177, 156, 17, 168, 218, 11, 234, 0, 159, 50, 141, 2, 117, 146, 185, 227, 181, 93, 71, 107, 2, 19, 38, 97 }, new byte[] { 96, 128, 70, 154, 149, 111, 161, 178, 118, 203, 197, 249, 229, 193, 147, 1, 247, 196, 103, 195, 128, 151, 88, 231, 144, 138, 118, 172, 119, 84, 108, 205, 115, 73, 239, 6, 220, 40, 241, 147, 28, 100, 87, 113, 107, 165, 41, 215, 57, 242, 90, 128, 185, 231, 167, 144, 87, 84, 141, 182, 48, 173, 208, 56, 238, 63, 185, 31, 128, 151, 185, 33, 1, 221, 39, 206, 182, 85, 92, 150, 217, 142, 221, 170, 220, 121, 205, 6, 235, 204, 254, 207, 226, 175, 5, 222, 7, 212, 194, 15, 17, 124, 51, 179, 74, 166, 208, 230, 47, 110, 199, 197, 241, 170, 156, 19, 140, 190, 56, 211, 170, 169, 108, 233, 33, 124, 115, 122 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 29, 40, 223, 113, 225, 226, 152, 18, 53, 158, 225, 202, 124, 200, 221, 23, 70, 79, 25, 192, 22, 168, 153, 58, 102, 92, 4, 168, 141, 182, 193, 188, 246, 166, 40, 140, 44, 121, 176, 156, 73, 254, 208, 16, 222, 239, 47, 151, 251, 222, 153, 226, 51, 238, 77, 128, 243, 152, 198, 3, 53, 133, 162, 32 }, new byte[] { 183, 247, 144, 7, 176, 32, 180, 221, 188, 236, 205, 254, 150, 98, 216, 208, 8, 178, 194, 56, 10, 52, 90, 101, 29, 10, 189, 15, 164, 172, 140, 206, 132, 69, 217, 245, 113, 61, 148, 181, 251, 230, 178, 68, 111, 196, 210, 42, 68, 107, 191, 202, 117, 175, 207, 72, 214, 114, 16, 80, 153, 219, 250, 49, 124, 206, 152, 93, 116, 11, 54, 171, 253, 71, 171, 189, 56, 129, 17, 209, 154, 33, 224, 98, 17, 200, 58, 4, 117, 243, 101, 184, 16, 82, 234, 131, 88, 217, 113, 183, 94, 215, 230, 236, 171, 245, 104, 133, 136, 91, 89, 123, 171, 119, 25, 40, 118, 233, 110, 113, 209, 17, 6, 28, 198, 95, 89, 23 } });
        }
    }
}
