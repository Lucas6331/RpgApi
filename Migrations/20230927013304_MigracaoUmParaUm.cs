using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 197, 254, 203, 125, 169, 168, 128, 155, 47, 45, 100, 198, 233, 20, 69, 162, 221, 168, 19, 82, 200, 32, 148, 148, 169, 248, 190, 157, 37, 219, 55, 190, 58, 229, 69, 8, 36, 0, 81, 113, 53, 14, 39, 231, 137, 223, 147, 180, 9, 191, 195, 229, 166, 168, 191, 184, 34, 159, 63, 81, 46, 165, 187, 131 }, new byte[] { 160, 143, 12, 47, 207, 87, 112, 46, 92, 20, 28, 70, 3, 63, 124, 35, 242, 31, 158, 230, 147, 232, 84, 152, 101, 1, 108, 2, 222, 15, 164, 109, 216, 34, 113, 115, 110, 247, 123, 118, 116, 224, 0, 119, 53, 130, 240, 166, 135, 105, 109, 120, 51, 180, 177, 129, 224, 218, 153, 224, 80, 252, 69, 71, 26, 86, 215, 240, 181, 229, 2, 244, 236, 154, 18, 214, 108, 29, 139, 0, 198, 72, 12, 28, 107, 168, 248, 193, 150, 116, 66, 125, 165, 231, 101, 201, 7, 95, 185, 186, 249, 203, 207, 70, 138, 77, 66, 12, 171, 35, 81, 214, 244, 12, 153, 86, 86, 234, 154, 93, 194, 146, 106, 34, 166, 25, 161, 230 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 11, 145, 26, 160, 147, 59, 187, 12, 39, 241, 145, 23, 70, 213, 247, 36, 199, 3, 161, 101, 110, 46, 220, 172, 208, 116, 161, 243, 54, 24, 230, 25, 2, 68, 206, 12, 61, 123, 153, 51, 250, 58, 109, 55, 28, 24, 156, 236, 75, 173, 191, 134, 8, 154, 4, 213, 154, 224, 159, 50, 199, 226, 160, 179 }, new byte[] { 87, 120, 216, 144, 50, 120, 234, 87, 22, 169, 177, 91, 57, 53, 189, 20, 86, 121, 251, 237, 115, 182, 129, 250, 253, 221, 4, 171, 188, 160, 125, 75, 93, 89, 187, 209, 234, 135, 20, 225, 207, 236, 198, 108, 8, 208, 148, 67, 97, 247, 175, 174, 58, 24, 6, 139, 228, 180, 249, 245, 80, 87, 194, 42, 37, 6, 8, 42, 144, 32, 35, 15, 76, 139, 158, 252, 140, 151, 114, 173, 45, 135, 3, 219, 143, 201, 146, 169, 100, 214, 51, 141, 74, 63, 164, 26, 1, 81, 142, 182, 246, 40, 232, 95, 243, 104, 145, 162, 208, 199, 78, 45, 202, 42, 83, 201, 82, 158, 188, 53, 117, 222, 255, 197, 18, 97, 101, 191 } });
        }
    }
}
