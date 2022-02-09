using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLearnAPI.Migrations
{
    public partial class AddDonHangSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DonGia",
                table: "ChiTietDonHang",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DonGia",
                table: "ChiTietDonHang");
        }
    }
}
