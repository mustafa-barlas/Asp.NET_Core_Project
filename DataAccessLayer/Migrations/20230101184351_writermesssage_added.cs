using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class writermesssage_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_writerMessages",
                table: "writerMessages");

            migrationBuilder.RenameTable(
                name: "writerMessages",
                newName: "WriterMessages");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "WriterMessages",
                newName: "MessageContent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriterMessages",
                table: "WriterMessages",
                column: "WriterMessageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WriterMessages",
                table: "WriterMessages");

            migrationBuilder.RenameTable(
                name: "WriterMessages",
                newName: "writerMessages");

            migrationBuilder.RenameColumn(
                name: "MessageContent",
                table: "writerMessages",
                newName: "Content");

            migrationBuilder.AddPrimaryKey(
                name: "PK_writerMessages",
                table: "writerMessages",
                column: "WriterMessageID");
        }
    }
}
