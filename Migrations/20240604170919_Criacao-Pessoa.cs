using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Desaparecidos.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoPessoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioSenha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaRoupa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaCor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaObservacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaLocalDesaparecimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaDtDesaparecimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PessoaDtEncontro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PessoaStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_Pessoa_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Observacoes",
                columns: table => new
                {
                    ObservacoesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservacoesDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservacoesLocal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservacoesData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observacoes", x => x.ObservacoesId);
                    table.ForeignKey(
                        name: "FK_Observacoes_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId");
                    table.ForeignKey(
                        name: "FK_Observacoes_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Observacoes_PessoaId",
                table: "Observacoes",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacoes_UsuarioId",
                table: "Observacoes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_UsuarioId",
                table: "Pessoa",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Observacoes");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
