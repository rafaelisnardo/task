using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ddd.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: true),
                    DataEdicao = table.Column<DateTime>(nullable: true),
                    DataExclusao = table.Column<DateTime>(nullable: true),
                    DataConclusao = table.Column<DateTime>(nullable: true),
                    TaskConcluida = table.Column<bool>(nullable: false, defaultValue: false),
                    TaskExcluida = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task");
        }
    }
}
