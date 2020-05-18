using Microsoft.EntityFrameworkCore.Migrations;

namespace KellerApi.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] {  "Answer", "Quest" },
                values: new object[] {  "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ipsa culpa ea suscipit animi, reprehenderit incidunt nostrum voluptas, nihil ipsum quaerat, dolore magni veritatis aliquid? Illo delectus eligendi ullam nobis sint ad possimus! Expedita id asperiores veniam sunt dolores corrupti, quam odit blanditiis est enim distinctio quidem ut dignissimos, vel harum?", "Q. Dummy text lorem ipsum dolor sit amet" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] {  "Answer", "Quest" },
                values: new object[] {  "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ipsa culpa ea suscipit animi, reprehenderit incidunt nostrum voluptas, nihil ipsum quaerat, dolore magni veritatis aliquid? Illo delectus eligendi ullam nobis sint ad possimus! Expedita id asperiores veniam sunt dolores corrupti, quam odit blanditiis est enim distinctio quidem ut dignissimos, vel harum?", "Q. Dummy text lorem ipsum dolor sit amet" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
