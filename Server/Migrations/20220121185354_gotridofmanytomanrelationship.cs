using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KidsClubApp.Server.Migrations
{
    public partial class gotridofmanytomanrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Addresses_AddressId",
                table: "Children");

            migrationBuilder.DropTable(
                name: "ChildParent");

            migrationBuilder.DropIndex(
                name: "IX_Children_AddressId",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Children");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Children",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 10, 53, 53, 576, DateTimeKind.Local).AddTicks(4234), new DateTime(2022, 1, 21, 10, 53, 53, 578, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 10, 53, 53, 578, DateTimeKind.Local).AddTicks(4795), new DateTime(2022, 1, 21, 10, 53, 53, 578, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b65ab1-4f28-437f-8c2d-013a5ee87863",
                column: "ConcurrencyStamp",
                value: "d9b87c5c-4ada-429d-8404-759cf62d0192");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6b1931e-a519-45cc-9124-174566883005",
                column: "ConcurrencyStamp",
                value: "14514636-2aac-4c1e-9cbe-4c7fb4272566");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67fee137-8980-4cce-9b4e-935c2d36974d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24174104-abb4-4753-9a9c-72e0c5a16804", "AQAAAAEAACcQAAAAEL+Vec1VNnxqS0nEIHvEc5S9t2+Jtf5z4FuDXtQv8IpjX6PCqPyBLoNgjnalwHf28A==", "fb9b92a8-a70e-40d9-9da0-fe79d5e54b6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "723f57f2-4191-4383-9b24-2a8c0c181873",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "001a296f-6c49-47dc-9dee-fd52aa04ebe2", "AQAAAAEAACcQAAAAEF10Eqbbnp3Q7NqeTKiB0E2IOjLRosfCcTMABpifqTP25RBlEPlKtMnWRZtPsAMgrw==", "d1ad2990-0613-45c4-bda3-ddf1442b416a" });

            migrationBuilder.UpdateData(
                table: "Children",
                keyColumn: "ChildId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 10, 53, 53, 580, DateTimeKind.Local).AddTicks(1979), new DateTime(2022, 1, 21, 10, 53, 53, 580, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Children",
                keyColumn: "ChildId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 10, 53, 53, 580, DateTimeKind.Local).AddTicks(4021), new DateTime(2022, 1, 21, 10, 53, 53, 580, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 10, 53, 53, 579, DateTimeKind.Local).AddTicks(5964), new DateTime(2022, 1, 21, 10, 53, 53, 579, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 10, 53, 53, 579, DateTimeKind.Local).AddTicks(8782), new DateTime(2022, 1, 21, 10, 53, 53, 579, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "SignInSheetEntry",
                keyColumn: "SignInSheetEntryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "SignInTime", "SignOutTime" },
                values: new object[] { new DateTime(2022, 1, 21, 10, 53, 53, 580, DateTimeKind.Local).AddTicks(6462), new DateTime(2022, 1, 21, 10, 53, 53, 580, DateTimeKind.Local).AddTicks(6475), new DateTime(2022, 1, 21, 10, 53, 53, 580, DateTimeKind.Local).AddTicks(6712), new DateTime(2022, 1, 21, 10, 53, 53, 580, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.CreateIndex(
                name: "IX_Children_ParentId",
                table: "Children",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Parents_ParentId",
                table: "Children",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "ParentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Parents_ParentId",
                table: "Children");

            migrationBuilder.DropIndex(
                name: "IX_Children_ParentId",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Children");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Children",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ChildParent",
                columns: table => new
                {
                    ChildrenChildId = table.Column<int>(type: "int", nullable: false),
                    ParentsParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildParent", x => new { x.ChildrenChildId, x.ParentsParentId });
                    table.ForeignKey(
                        name: "FK_ChildParent_Children_ChildrenChildId",
                        column: x => x.ChildrenChildId,
                        principalTable: "Children",
                        principalColumn: "ChildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildParent_Parents_ParentsParentId",
                        column: x => x.ParentsParentId,
                        principalTable: "Parents",
                        principalColumn: "ParentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 0, 29, 9, 876, DateTimeKind.Local).AddTicks(2687), new DateTime(2022, 1, 21, 0, 29, 9, 877, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 0, 29, 9, 878, DateTimeKind.Local).AddTicks(1840), new DateTime(2022, 1, 21, 0, 29, 9, 878, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b65ab1-4f28-437f-8c2d-013a5ee87863",
                column: "ConcurrencyStamp",
                value: "ce092c08-6b9e-4ac2-aac6-258152d65c65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6b1931e-a519-45cc-9124-174566883005",
                column: "ConcurrencyStamp",
                value: "3a6734b4-7c55-49a8-905f-76b5f7c33485");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67fee137-8980-4cce-9b4e-935c2d36974d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1a9b99f-c883-47ad-8144-1de3fc24b613", "AQAAAAEAACcQAAAAEKgsE+dBA4k939J/nufwjhVdvEYCvsRySPLS7oklhOqb3dyFHK9CbNZBpksmKL1XYw==", "9ee3b4e5-acad-434b-aa05-584d505435eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "723f57f2-4191-4383-9b24-2a8c0c181873",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49f934ec-6504-4bc3-a445-a98d3055d45a", "AQAAAAEAACcQAAAAECWelCsLdmo32EV4Cgo2ECURJFbnFLEZiJPyyeOjvrMlC16RE89ZoGv1jS1B/4lWpQ==", "5bbb7e9f-32ad-46b0-a6d4-87351bbc28b6" });

            migrationBuilder.InsertData(
                table: "ChildParent",
                columns: new[] { "ChildrenChildId", "ParentsParentId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Children",
                keyColumn: "ChildId",
                keyValue: 1,
                columns: new[] { "AddressId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 1, 21, 0, 29, 9, 879, DateTimeKind.Local).AddTicks(8798), new DateTime(2022, 1, 21, 0, 29, 9, 879, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Children",
                keyColumn: "ChildId",
                keyValue: 2,
                columns: new[] { "AddressId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 1, 21, 0, 29, 9, 880, DateTimeKind.Local).AddTicks(898), new DateTime(2022, 1, 21, 0, 29, 9, 880, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 0, 29, 9, 879, DateTimeKind.Local).AddTicks(2787), new DateTime(2022, 1, 21, 0, 29, 9, 879, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 0, 29, 9, 879, DateTimeKind.Local).AddTicks(5521), new DateTime(2022, 1, 21, 0, 29, 9, 879, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "SignInSheetEntry",
                keyColumn: "SignInSheetEntryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "SignInTime", "SignOutTime" },
                values: new object[] { new DateTime(2022, 1, 21, 0, 29, 9, 880, DateTimeKind.Local).AddTicks(3272), new DateTime(2022, 1, 21, 0, 29, 9, 880, DateTimeKind.Local).AddTicks(3284), new DateTime(2022, 1, 21, 0, 29, 9, 880, DateTimeKind.Local).AddTicks(3515), new DateTime(2022, 1, 21, 0, 29, 9, 880, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.CreateIndex(
                name: "IX_Children_AddressId",
                table: "Children",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildParent_ParentsParentId",
                table: "ChildParent",
                column: "ParentsParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Addresses_AddressId",
                table: "Children",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
