using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SL.VehicleMaintenance.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserTable_ChangeColumn_Name_ColumnType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "VARCHAR(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(75)",
                oldMaxLength: 75);
        }
    }
}
