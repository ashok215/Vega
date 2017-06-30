using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Self Driving')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Automation')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Remodel')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("DELETE FROM Features WHERE Name IN ('Feature1', 'Feature2', 'Feature3')");
        }
    }
}
