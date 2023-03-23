using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERModeling_SQL.Migrations
{
    public partial class Fixedconnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Results_FkAdministrationId",
                table: "Results",
                column: "FkAdministrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_FkClassListId",
                table: "Results",
                column: "FkClassListId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_FkCourseListId",
                table: "Results",
                column: "FkCourseListId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_FkGradeListId",
                table: "Results",
                column: "FkGradeListId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_FkStudentId",
                table: "Results",
                column: "FkStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Administrations_FkAdministrationId",
                table: "Results",
                column: "FkAdministrationId",
                principalTable: "Administrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_ClassLists_FkClassListId",
                table: "Results",
                column: "FkClassListId",
                principalTable: "ClassLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_CourseLists_FkCourseListId",
                table: "Results",
                column: "FkCourseListId",
                principalTable: "CourseLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_GradeLists_FkGradeListId",
                table: "Results",
                column: "FkGradeListId",
                principalTable: "GradeLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_FkStudentId",
                table: "Results",
                column: "FkStudentId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Administrations_FkAdministrationId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_ClassLists_FkClassListId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_CourseLists_FkCourseListId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_GradeLists_FkGradeListId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_FkStudentId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_FkAdministrationId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_FkClassListId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_FkCourseListId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_FkGradeListId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_FkStudentId",
                table: "Results");
        }
    }
}
