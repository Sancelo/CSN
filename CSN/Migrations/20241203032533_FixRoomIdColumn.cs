using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSN.Migrations
{
    /// <inheritdoc />
    public partial class FixRoomIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbRoom",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbRoom", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "tbUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbUser", x => x.UserId);
                });

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

            migrationBuilder.CreateTable(
                name: "tbMsg",
                columns: table => new
                {
                    IdMsg = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMsg", x => x.IdMsg);
                    table.ForeignKey(
                        name: "FK_tbMsg_tbRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "tbRoom",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbMsg_tbUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tbUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomUser_RoomsRoomId",
                table: "RoomUser",
                column: "RoomsRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMsg_RoomId",
                table: "tbMsg",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMsg_UserId",
                table: "tbMsg",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomUser");

            migrationBuilder.DropTable(
                name: "tbMsg");

            migrationBuilder.DropTable(
                name: "tbRoom");

            migrationBuilder.DropTable(
                name: "tbUser");
        }
    }
}
