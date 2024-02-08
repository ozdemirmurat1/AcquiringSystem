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
            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, null, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 145, 57, 200, 234, 207, 138, 40, 222, 114, 116, 152, 166, 122, 30, 33, 48, 198, 226, 84, 73, 163, 131, 76, 201, 187, 226, 211, 187, 160, 202, 59, 119, 102, 212, 109, 128, 126, 55, 142, 128, 102, 241, 199, 157, 149, 50, 64, 75, 111, 202, 44, 55, 203, 196, 175, 149, 130, 5, 70, 3, 133, 76, 227, 210 }, new byte[] { 158, 129, 70, 48, 13, 124, 85, 236, 202, 32, 243, 213, 138, 38, 21, 254, 160, 136, 78, 7, 43, 13, 135, 124, 166, 44, 223, 248, 99, 193, 134, 178, 182, 218, 65, 152, 175, 87, 185, 73, 18, 63, 214, 146, 105, 97, 106, 162, 209, 184, 151, 166, 79, 151, 68, 148, 70, 240, 212, 22, 41, 62, 191, 228, 243, 219, 18, 145, 123, 144, 137, 78, 193, 239, 169, 145, 62, 115, 54, 225, 112, 160, 223, 171, 96, 28, 63, 77, 138, 64, 237, 93, 46, 167, 193, 92, 102, 166, 168, 86, 147, 115, 165, 131, 48, 35, 255, 135, 6, 25, 230, 199, 168, 76, 227, 175, 203, 161, 16, 5, 248, 183, 170, 66, 221, 79, 156, 236 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 202, 27, 120, 167, 192, 65, 74, 59, 205, 246, 111, 68, 189, 70, 113, 240, 12, 95, 247, 125, 215, 43, 151, 73, 156, 179, 199, 225, 47, 197, 72, 22, 43, 113, 52, 215, 66, 234, 60, 119, 185, 255, 223, 116, 185, 220, 119, 172, 182, 38, 245, 169, 236, 33, 56, 123, 211, 189, 145, 207, 134, 8, 174, 25 }, new byte[] { 226, 7, 167, 239, 213, 32, 30, 172, 187, 72, 58, 187, 249, 183, 43, 63, 129, 239, 156, 185, 16, 249, 238, 73, 128, 151, 200, 210, 8, 164, 157, 107, 248, 199, 32, 252, 93, 16, 180, 49, 1, 74, 168, 56, 116, 189, 209, 221, 51, 147, 190, 225, 16, 150, 157, 85, 36, 158, 251, 120, 121, 121, 165, 208, 175, 23, 236, 55, 167, 93, 5, 252, 15, 67, 172, 226, 186, 201, 110, 162, 68, 38, 145, 99, 78, 22, 198, 37, 157, 78, 181, 209, 126, 183, 121, 172, 93, 150, 255, 115, 135, 96, 129, 175, 136, 244, 32, 35, 162, 2, 128, 138, 218, 31, 110, 51, 165, 248, 152, 22, 191, 229, 79, 161, 89, 27, 135, 160 } });
        }
    }
}
