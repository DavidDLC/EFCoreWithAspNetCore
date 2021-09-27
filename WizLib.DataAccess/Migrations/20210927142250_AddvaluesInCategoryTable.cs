using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib.DataAccess.Migrations
{
    public partial class AddvaluesInCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO tbl_category VALUES('cat 1')");
            migrationBuilder.Sql("INSERT INTO tbl_category VALUES('cat 2')");
            migrationBuilder.Sql("INSERT INTO tbl_category VALUES('cat 3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
