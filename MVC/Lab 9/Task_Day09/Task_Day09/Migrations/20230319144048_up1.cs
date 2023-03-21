using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_Day09.Migrations
{
    /// <inheritdoc />
    public partial class up1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_trainees_TraineeID",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_TraineeID",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "TraineeID",
                table: "courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "trainees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_trainees_CourseID",
                table: "trainees",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_trainees_courses_CourseID",
                table: "trainees",
                column: "CourseID",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainees_courses_CourseID",
                table: "trainees");

            migrationBuilder.DropIndex(
                name: "IX_trainees_CourseID",
                table: "trainees");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "trainees");

            migrationBuilder.AddColumn<int>(
                name: "TraineeID",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_courses_TraineeID",
                table: "courses",
                column: "TraineeID");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_trainees_TraineeID",
                table: "courses",
                column: "TraineeID",
                principalTable: "trainees",
                principalColumn: "TraineeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
