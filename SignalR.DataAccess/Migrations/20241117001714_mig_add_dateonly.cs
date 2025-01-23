using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_dateonly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "MoneyCases",
                newName: "TotalAmout");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalAmout",
                table: "MoneyCases",
                newName: "TotalAmount");
        }
    }
}
