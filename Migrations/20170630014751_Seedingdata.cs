using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class Seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Tesla')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Ford')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('BMW')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Tesla-SEX', (SELECT ID FROM Makes WHERE Name = 'Tesla'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Tesla-SEY', (SELECT ID FROM Makes WHERE Name = 'Tesla'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Tesla-SEA', (SELECT ID FROM Makes WHERE Name = 'Tesla'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Ford-Mustang', (SELECT ID FROM Makes WHERE Name = 'Ford'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Ford-Focus', (SELECT ID FROM Makes WHERE Name = 'Ford'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Ford-Fiesta', (SELECT ID FROM Makes WHERE Name = 'Ford'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('BMW-X5', (SELECT ID FROM Makes WHERE Name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('BMW-X3', (SELECT ID FROM Makes WHERE Name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('BMW-3', (SELECT ID FROM Makes WHERE Name = 'BMW'))");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Tesla', 'Ford', 'BMW')");
        }
    }
}
