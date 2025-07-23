using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApontaMe.Migrations
{
    /// <inheritdoc />
    public partial class AddApontamento_Tarefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Apontamentos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Apontamentos");

            migrationBuilder.RenameColumn(
                name: "Observacoes",
                table: "Apontamentos",
                newName: "Mes");

            migrationBuilder.AddColumn<string>(
                name: "Nome_Usuario",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Saida",
                table: "Apontamentos",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Intervalo",
                table: "Apontamentos",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Entrada",
                table: "Apontamentos",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Apontamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Apontamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ApontamentoTarefas",
                columns: table => new
                {
                    ApontamentoTarefaID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ApontamentoID = table.Column<int>(type: "INTEGER", nullable: false),
                    Inicio = table.Column<int>(type: "INTEGER", nullable: false),
                    Fim = table.Column<int>(type: "INTEGER", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApontamentoTarefas", x => x.ApontamentoTarefaID);
                    table.ForeignKey(
                        name: "FK_ApontamentoTarefas_Apontamentos_ApontamentoID",
                        column: x => x.ApontamentoID,
                        principalTable: "Apontamentos",
                        principalColumn: "ApontamentoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apontamentos_UsuarioID",
                table: "Apontamentos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_ApontamentoTarefas_ApontamentoID",
                table: "ApontamentoTarefas",
                column: "ApontamentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Apontamentos_Usuarios_UsuarioID",
                table: "Apontamentos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apontamentos_Usuarios_UsuarioID",
                table: "Apontamentos");

            migrationBuilder.DropTable(
                name: "ApontamentoTarefas");

            migrationBuilder.DropIndex(
                name: "IX_Apontamentos_UsuarioID",
                table: "Apontamentos");

            migrationBuilder.DropColumn(
                name: "Nome_Usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Apontamentos");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Apontamentos");

            migrationBuilder.RenameColumn(
                name: "Mes",
                table: "Apontamentos",
                newName: "Observacoes");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Saida",
                table: "Apontamentos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Intervalo",
                table: "Apontamentos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Entrada",
                table: "Apontamentos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "TEXT");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Apontamentos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Apontamentos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
