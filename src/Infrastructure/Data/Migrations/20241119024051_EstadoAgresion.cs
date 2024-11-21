using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAlertaMinsal.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class EstadoAgresion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(5800), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(5620), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(5410), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(4230), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(3800), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(900), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(9660), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(9490), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(6720), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(5640), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(5430), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(8040), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(7790), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(7480), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(4760), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(4530), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(1350), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(9840), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(9910), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(9620), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(8570), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(8140), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(6880), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(6530), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(6660), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(3080), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAgresion",
                table: "Agresion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Local).AddTicks(3280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(2790), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "EstadoAgresionId",
                table: "Agresion",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EstadoAgresion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(10), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoAgresion", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agresion_EstadoAgresionId",
                table: "Agresion",
                column: "EstadoAgresionId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoAgresion_Name",
                table: "EstadoAgresion",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Agresion_EstadoAgresion_EstadoAgresionId",
                table: "Agresion",
                column: "EstadoAgresionId",
                principalTable: "EstadoAgresion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agresion_EstadoAgresion_EstadoAgresionId",
                table: "Agresion");

            migrationBuilder.DropTable(
                name: "EstadoAgresion");

            migrationBuilder.DropIndex(
                name: "IX_Agresion_EstadoAgresionId",
                table: "Agresion");

            migrationBuilder.DropColumn(
                name: "EstadoAgresionId",
                table: "Agresion");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(5800), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(5410), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(5620), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(4230), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(3800), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 380, DateTimeKind.Unspecified).AddTicks(900), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(9660), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(9490), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(6720), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(5640), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(5430), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 379, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(7790), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(8040), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(7480), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(4760), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(4530), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(1350), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(9840), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 378, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(9620), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(9910), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(8570), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(8140), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(6530), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(6880), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(6660), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(3080), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAgresion",
                table: "Agresion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 18, 23, 40, 51, 377, DateTimeKind.Unspecified).AddTicks(2790), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
