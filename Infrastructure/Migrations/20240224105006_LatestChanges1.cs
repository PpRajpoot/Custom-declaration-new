using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class LatestChanges1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Addresses",
                columns: table => new
                {
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pincode = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Addresses", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "T_Company",
                columns: table => new
                {
                    companyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIN = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Company", x => x.companyId);
                });

            migrationBuilder.CreateTable(
                name: "T_Declaration",
                columns: table => new
                {
                    DeclarationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeclarationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    payerTin = table.Column<long>(type: "bigint", nullable: false),
                    consigneeTin = table.Column<long>(type: "bigint", nullable: false),
                    consignerTin = table.Column<long>(type: "bigint", nullable: false),
                    ImportCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExportCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    transportationMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expectedDateOfDelivery = table.Column<DateTime>(type: "datetime2", nullable: false),
                    totalCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Declaration", x => x.DeclarationId);
                });

            migrationBuilder.CreateTable(
                name: "T_Event",
                columns: table => new
                {
                    eventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    events = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Event", x => x.eventId);
                });

            migrationBuilder.CreateTable(
                name: "T_GoodsItem",
                columns: table => new
                {
                    GoodsItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeclarationID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DutyCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommodityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_GoodsItem", x => x.GoodsItemId);
                });

            migrationBuilder.CreateTable(
                name: "T_MaterialCommodityMapping",
                columns: table => new
                {
                    CommodityCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DutyPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MaterialCommodityMapping", x => x.CommodityCode);
                });

            migrationBuilder.CreateTable(
                name: "T_Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    delcaration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Message", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "T_Addresses",
                columns: new[] { "AddressID", "Address", "City", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "pincode" },
                values: new object[,]
                {
                    { new Guid("2c9fcbb0-139e-4417-b08c-7c300484c86d"), "d", "d_city", "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2218), "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2219), 0 },
                    { new Guid("30e66da6-9598-4e02-8caf-2f163a427e2b"), "a", "a_city", "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2205), "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2206), 0 },
                    { new Guid("5fd4aad9-4a90-4b1e-9a3d-e0a025fbeae0"), "c", "c_city", "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2216), "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2217), 0 },
                    { new Guid("e30d8264-235c-4e0c-bfeb-cb87e3fd7050"), "b", "b_city", "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2208), "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2208), 0 }
                });

            migrationBuilder.InsertData(
                table: "T_Company",
                columns: new[] { "companyId", "AddressID", "CreatedBy", "CreatedOn", "Email", "Name", "TIN", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2053), "globalConnect@gmail.com", "Global Connect", 10001L, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2055) },
                    { 2, 2, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2056), "swiftImports@gmail.com", "Swift Imports", 10002L, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2057) },
                    { 3, 3, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2090), "exportExperts@gmail.com", "Export Experts", 10003L, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2091) },
                    { 4, 4, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2092), "tradeNavigation@gmail.com", "Trade Navigation", 10004L, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2092) }
                });

            migrationBuilder.InsertData(
                table: "T_MaterialCommodityMapping",
                columns: new[] { "CommodityCode", "CreatedBy", "CreatedOn", "DutyPercentage", "MaterialType", "Price", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 2709L, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2247), 0.5m, "CrudeOil", 5000m, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2247) },
                    { 3901L, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2245), 0.1m, "Plastic", 4000m, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2245) },
                    { 6101L, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2242), 0.3m, "Clothing", 2000m, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2243) },
                    { 7206L, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2244), 0.2m, "Steel", 3000m, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2244) },
                    { 8517L, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2240), 0.4m, "Electronic", 1000m, "", new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2241) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Addresses");

            migrationBuilder.DropTable(
                name: "T_Company");

            migrationBuilder.DropTable(
                name: "T_Declaration");

            migrationBuilder.DropTable(
                name: "T_Event");

            migrationBuilder.DropTable(
                name: "T_GoodsItem");

            migrationBuilder.DropTable(
                name: "T_MaterialCommodityMapping");

            migrationBuilder.DropTable(
                name: "T_Message");
        }
    }
}
