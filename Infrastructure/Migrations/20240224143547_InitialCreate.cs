using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("2c9fcbb0-139e-4417-b08c-7c300484c86d"));

            migrationBuilder.DeleteData(
                table: "T_Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("30e66da6-9598-4e02-8caf-2f163a427e2b"));

            migrationBuilder.DeleteData(
                table: "T_Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("5fd4aad9-4a90-4b1e-9a3d-e0a025fbeae0"));

            migrationBuilder.DeleteData(
                table: "T_Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("e30d8264-235c-4e0c-bfeb-cb87e3fd7050"));

            migrationBuilder.InsertData(
                table: "T_Addresses",
                columns: new[] { "AddressID", "Address", "City", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "pincode" },
                values: new object[,]
                {
                    { new Guid("2e39c92f-f2a0-4198-bc9f-ececf08ac1c1"), "c", "c_city", "", new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3009), "", new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3009), 0 },
                    { new Guid("51efd840-f536-4db7-b4c2-4029f062c62b"), "d", "d_city", "", new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3010), "", new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3011), 0 },
                    { new Guid("52176271-763e-49ef-8244-998deac4b262"), "b", "b_city", "", new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3007), "", new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3008), 0 },
                    { new Guid("c5e3d81b-e445-494d-98c2-2b46d47cf2a1"), "a", "a_city", "", new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3005), "", new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3005), 0 }
                });

            migrationBuilder.UpdateData(
                table: "T_Company",
                keyColumn: "companyId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(2869), new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "T_Company",
                keyColumn: "companyId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(2874), new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "T_Company",
                keyColumn: "companyId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(2875), new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "T_Company",
                keyColumn: "companyId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(2876), new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 2709L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3038), new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 3901L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3036), new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 6101L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3034), new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 7206L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3035), new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 8517L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3032), new DateTime(2024, 2, 24, 14, 35, 47, 19, DateTimeKind.Utc).AddTicks(3032) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("2e39c92f-f2a0-4198-bc9f-ececf08ac1c1"));

            migrationBuilder.DeleteData(
                table: "T_Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("51efd840-f536-4db7-b4c2-4029f062c62b"));

            migrationBuilder.DeleteData(
                table: "T_Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("52176271-763e-49ef-8244-998deac4b262"));

            migrationBuilder.DeleteData(
                table: "T_Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("c5e3d81b-e445-494d-98c2-2b46d47cf2a1"));

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

            migrationBuilder.UpdateData(
                table: "T_Company",
                keyColumn: "companyId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2053), new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "T_Company",
                keyColumn: "companyId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2056), new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "T_Company",
                keyColumn: "companyId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2090), new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "T_Company",
                keyColumn: "companyId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2092), new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 2709L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2247), new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 3901L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2245), new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 6101L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2242), new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 7206L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2244), new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "T_MaterialCommodityMapping",
                keyColumn: "CommodityCode",
                keyValue: 8517L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2240), new DateTime(2024, 2, 24, 10, 50, 5, 981, DateTimeKind.Utc).AddTicks(2241) });
        }
    }
}
