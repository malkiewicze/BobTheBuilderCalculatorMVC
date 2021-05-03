using Microsoft.EntityFrameworkCore.Migrations;

namespace BuilderCalculatorMVC.Infrastructure.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_ModifiedByAppUserId1",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_ModifiedByAppUserId1",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientTypes_AspNetUsers_ModifiedByAppUserId1",
                table: "ClientTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactDetails_AspNetUsers_ModifiedByAppUserId1",
                table: "ContactDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactTypes_AspNetUsers_ModifiedByAppUserId1",
                table: "ContactTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRooms_AspNetUsers_ModifiedByAppUserId1",
                table: "OrderRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ModifiedByAppUserId1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_ModifiedByAppUserId1",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomWorks_AspNetUsers_ModifiedByAppUserId1",
                table: "RoomWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_AspNetUsers_ModifiedByAppUserId1",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_ModifiedByAppUserId1",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_RoomWorks_ModifiedByAppUserId1",
                table: "RoomWorks");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_ModifiedByAppUserId1",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ModifiedByAppUserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderRooms_ModifiedByAppUserId1",
                table: "OrderRooms");

            migrationBuilder.DropIndex(
                name: "IX_ContactTypes_ModifiedByAppUserId1",
                table: "ContactTypes");

            migrationBuilder.DropIndex(
                name: "IX_ContactDetails_ModifiedByAppUserId1",
                table: "ContactDetails");

            migrationBuilder.DropIndex(
                name: "IX_ClientTypes_ModifiedByAppUserId1",
                table: "ClientTypes");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ModifiedByAppUserId1",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ModifiedByAppUserId1",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "RoomWorks");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "OrderRooms");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "ContactTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "ContactDetails");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "ClientTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ModifiedByAppUserId1",
                table: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "Works",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "RoomWorks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "OrderRooms",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "ContactTypes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "ContactDetails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "ClientTypes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByAppUserId",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Works_ModifiedByAppUserId",
                table: "Works",
                column: "ModifiedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomWorks_ModifiedByAppUserId",
                table: "RoomWorks",
                column: "ModifiedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ModifiedByAppUserId",
                table: "Rooms",
                column: "ModifiedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ModifiedByAppUserId",
                table: "Orders",
                column: "ModifiedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRooms_ModifiedByAppUserId",
                table: "OrderRooms",
                column: "ModifiedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactTypes_ModifiedByAppUserId",
                table: "ContactTypes",
                column: "ModifiedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_ModifiedByAppUserId",
                table: "ContactDetails",
                column: "ModifiedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTypes_ModifiedByAppUserId",
                table: "ClientTypes",
                column: "ModifiedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ModifiedByAppUserId",
                table: "Clients",
                column: "ModifiedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ModifiedByAppUserId",
                table: "Addresses",
                column: "ModifiedByAppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_ModifiedByAppUserId",
                table: "Addresses",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_ModifiedByAppUserId",
                table: "Clients",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientTypes_AspNetUsers_ModifiedByAppUserId",
                table: "ClientTypes",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetails_AspNetUsers_ModifiedByAppUserId",
                table: "ContactDetails",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactTypes_AspNetUsers_ModifiedByAppUserId",
                table: "ContactTypes",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRooms_AspNetUsers_ModifiedByAppUserId",
                table: "OrderRooms",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ModifiedByAppUserId",
                table: "Orders",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_ModifiedByAppUserId",
                table: "Rooms",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomWorks_AspNetUsers_ModifiedByAppUserId",
                table: "RoomWorks",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_AspNetUsers_ModifiedByAppUserId",
                table: "Works",
                column: "ModifiedByAppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_ModifiedByAppUserId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_ModifiedByAppUserId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientTypes_AspNetUsers_ModifiedByAppUserId",
                table: "ClientTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactDetails_AspNetUsers_ModifiedByAppUserId",
                table: "ContactDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactTypes_AspNetUsers_ModifiedByAppUserId",
                table: "ContactTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRooms_AspNetUsers_ModifiedByAppUserId",
                table: "OrderRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ModifiedByAppUserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_ModifiedByAppUserId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomWorks_AspNetUsers_ModifiedByAppUserId",
                table: "RoomWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_AspNetUsers_ModifiedByAppUserId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_ModifiedByAppUserId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_RoomWorks_ModifiedByAppUserId",
                table: "RoomWorks");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_ModifiedByAppUserId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ModifiedByAppUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderRooms_ModifiedByAppUserId",
                table: "OrderRooms");

            migrationBuilder.DropIndex(
                name: "IX_ContactTypes_ModifiedByAppUserId",
                table: "ContactTypes");

            migrationBuilder.DropIndex(
                name: "IX_ContactDetails_ModifiedByAppUserId",
                table: "ContactDetails");

            migrationBuilder.DropIndex(
                name: "IX_ClientTypes_ModifiedByAppUserId",
                table: "ClientTypes");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ModifiedByAppUserId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ModifiedByAppUserId",
                table: "Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "Works",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "Works",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "RoomWorks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "RoomWorks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "Rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "OrderRooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "OrderRooms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "ContactTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "ContactTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "ContactDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "ContactDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "ClientTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "ClientTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "Clients",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedByAppUserId",
                table: "Addresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByAppUserId1",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_ModifiedByAppUserId1",
                table: "Works",
                column: "ModifiedByAppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_RoomWorks_ModifiedByAppUserId1",
                table: "RoomWorks",
                column: "ModifiedByAppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ModifiedByAppUserId1",
                table: "Rooms",
                column: "ModifiedByAppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ModifiedByAppUserId1",
                table: "Orders",
                column: "ModifiedByAppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRooms_ModifiedByAppUserId1",
                table: "OrderRooms",
                column: "ModifiedByAppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ContactTypes_ModifiedByAppUserId1",
                table: "ContactTypes",
                column: "ModifiedByAppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_ModifiedByAppUserId1",
                table: "ContactDetails",
                column: "ModifiedByAppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTypes_ModifiedByAppUserId1",
                table: "ClientTypes",
                column: "ModifiedByAppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ModifiedByAppUserId1",
                table: "Clients",
                column: "ModifiedByAppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ModifiedByAppUserId1",
                table: "Addresses",
                column: "ModifiedByAppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_ModifiedByAppUserId1",
                table: "Addresses",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_ModifiedByAppUserId1",
                table: "Clients",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientTypes_AspNetUsers_ModifiedByAppUserId1",
                table: "ClientTypes",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetails_AspNetUsers_ModifiedByAppUserId1",
                table: "ContactDetails",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactTypes_AspNetUsers_ModifiedByAppUserId1",
                table: "ContactTypes",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRooms_AspNetUsers_ModifiedByAppUserId1",
                table: "OrderRooms",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ModifiedByAppUserId1",
                table: "Orders",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_ModifiedByAppUserId1",
                table: "Rooms",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomWorks_AspNetUsers_ModifiedByAppUserId1",
                table: "RoomWorks",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_AspNetUsers_ModifiedByAppUserId1",
                table: "Works",
                column: "ModifiedByAppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
