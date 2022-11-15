using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesApi.Migrations
{
    /// <inheritdoc />
    public partial class sessoesfilmes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessao_Filmes_FilmeId",
                table: "Sessao");

            migrationBuilder.DropIndex(
                name: "IX_Sessao_FilmeId",
                table: "Sessao");

            migrationBuilder.DropColumn(
                name: "FilmeId",
                table: "Sessao");

            migrationBuilder.AddColumn<int>(
                name: "idFilme",
                table: "Sessao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sessao_idFilme",
                table: "Sessao",
                column: "idFilme");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessao_Filmes_idFilme",
                table: "Sessao",
                column: "idFilme",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessao_Filmes_idFilme",
                table: "Sessao");

            migrationBuilder.DropIndex(
                name: "IX_Sessao_idFilme",
                table: "Sessao");

            migrationBuilder.DropColumn(
                name: "idFilme",
                table: "Sessao");

            migrationBuilder.AddColumn<int>(
                name: "FilmeId",
                table: "Sessao",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessao_FilmeId",
                table: "Sessao",
                column: "FilmeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessao_Filmes_FilmeId",
                table: "Sessao",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id");
        }
    }
}
