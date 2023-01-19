using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppLicenseManager.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarTablasLicenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LicRelAppModuleIdApplication",
                table: "LicModules",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LicRelAppModuleIdModule",
                table: "LicModules",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LicRelAppModules",
                columns: table => new
                {
                    IdApplication = table.Column<int>(type: "int", nullable: false),
                    IdModule = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicRelAppModules", x => new { x.IdApplication, x.IdModule });
                });

            migrationBuilder.CreateTable(
                name: "LicApplicationLicRelAppModule",
                columns: table => new
                {
                    LicApplicationsId = table.Column<long>(type: "bigint", nullable: false),
                    LicRelAppModulesIdApplication = table.Column<int>(type: "int", nullable: false),
                    LicRelAppModulesIdModule = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicApplicationLicRelAppModule", x => new { x.LicApplicationsId, x.LicRelAppModulesIdApplication, x.LicRelAppModulesIdModule });
                    table.ForeignKey(
                        name: "FK_LicApplicationLicRelAppModule_LicApplications_LicApplicationsId",
                        column: x => x.LicApplicationsId,
                        principalTable: "LicApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LicApplicationLicRelAppModule_LicRelAppModules_LicRelAppModulesIdApplication_LicRelAppModulesIdModule",
                        columns: x => new { x.LicRelAppModulesIdApplication, x.LicRelAppModulesIdModule },
                        principalTable: "LicRelAppModules",
                        principalColumns: new[] { "IdApplication", "IdModule" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LicModules_LicRelAppModuleIdApplication_LicRelAppModuleIdModule",
                table: "LicModules",
                columns: new[] { "LicRelAppModuleIdApplication", "LicRelAppModuleIdModule" });

            migrationBuilder.CreateIndex(
                name: "IX_LicApplicationLicRelAppModule_LicRelAppModulesIdApplication_LicRelAppModulesIdModule",
                table: "LicApplicationLicRelAppModule",
                columns: new[] { "LicRelAppModulesIdApplication", "LicRelAppModulesIdModule" });

            migrationBuilder.AddForeignKey(
                name: "FK_LicModules_LicRelAppModules_LicRelAppModuleIdApplication_LicRelAppModuleIdModule",
                table: "LicModules",
                columns: new[] { "LicRelAppModuleIdApplication", "LicRelAppModuleIdModule" },
                principalTable: "LicRelAppModules",
                principalColumns: new[] { "IdApplication", "IdModule" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LicModules_LicRelAppModules_LicRelAppModuleIdApplication_LicRelAppModuleIdModule",
                table: "LicModules");

            migrationBuilder.DropTable(
                name: "LicApplicationLicRelAppModule");

            migrationBuilder.DropTable(
                name: "LicRelAppModules");

            migrationBuilder.DropIndex(
                name: "IX_LicModules_LicRelAppModuleIdApplication_LicRelAppModuleIdModule",
                table: "LicModules");

            migrationBuilder.DropColumn(
                name: "LicRelAppModuleIdApplication",
                table: "LicModules");

            migrationBuilder.DropColumn(
                name: "LicRelAppModuleIdModule",
                table: "LicModules");
        }
    }
}
