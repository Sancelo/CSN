using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSN.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMsgModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbMsg_tbUser_UserId",
                table: "tbMsg");

            migrationBuilder.DropTable(
                name: "RoomUser");

            migrationBuilder.DropIndex(
                name: "IX_tbMsg_UserId",
                table: "tbMsg");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tbMsg");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbUser",
                newName: "User");

            migrationBuilder.AddColumn<int>(
                name: "tbUserUserId",
                table: "tbRoom",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "tbMsg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tbUserUserId",
                table: "tbMsg",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbRoom_tbUserUserId",
                table: "tbRoom",
                column: "tbUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMsg_tbUserUserId",
                table: "tbMsg",
                column: "tbUserUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbMsg_tbUser_tbUserUserId",
                table: "tbMsg",
                column: "tbUserUserId",
                principalTable: "tbUser",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbRoom_tbUser_tbUserUserId",
                table: "tbRoom",
                column: "tbUserUserId",
                principalTable: "tbUser",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbMsg_tbUser_tbUserUserId",
                table: "tbMsg");

            migrationBuilder.DropForeignKey(
                name: "FK_tbRoom_tbUser_tbUserUserId",
                table: "tbRoom");

            migrationBuilder.DropIndex(
                name: "IX_tbRoom_tbUserUserId",
                table: "tbRoom");

            migrationBuilder.DropIndex(
                name: "IX_tbMsg_tbUserUserId",
                table: "tbMsg");

            migrationBuilder.DropColumn(
                name: "tbUserUserId",
                table: "tbRoom");

            migrationBuilder.DropColumn(
                name: "User",
                table: "tbMsg");

            migrationBuilder.DropColumn(
                name: "tbUserUserId",
                table: "tbMsg");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "tbUser",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "tbMsg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RoomUser",
                columns: table => new
                {
                    RoomUsersUserId = table.Column<int>(type: "int", nullable: false),
                    RoomsRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomUser", x => new { x.RoomUsersUserId, x.RoomsRoomId });
                    table.ForeignKey(
                        name: "FK_RoomUser_tbRoom_RoomsRoomId",
                        column: x => x.RoomsRoomId,
                        principalTable: "tbRoom",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomUser_tbUser_RoomUsersUserId",
                        column: x => x.RoomUsersUserId,
                        principalTable: "tbUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbMsg_UserId",
                table: "tbMsg",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomUser_RoomsRoomId",
                table: "RoomUser",
                column: "RoomsRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbMsg_tbUser_UserId",
                table: "tbMsg",
                column: "UserId",
                principalTable: "tbUser",
                principalColumn: "UserId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
