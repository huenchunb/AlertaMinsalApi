using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAlertaMinsal.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTestigoAgresor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(2650), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(5410), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(3800), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(7860), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(6430), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(6720), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(7790), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(7480), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(3050), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(510), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(1350), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(240), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(9840), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(8650), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(9620), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(8480), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(7220), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(8140), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(7050), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "RutNormalized",
                table: "Agresor",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rut",
                table: "Agresor",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Agresor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Agresor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(6530), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Agresor",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Agresor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Digito",
                table: "Agresor",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<int>(
                name: "ComunaId",
                table: "Agresor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAgresion",
                table: "Agresion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(1870), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Testigo_RutNormalized",
                table: "Testigo",
                column: "RutNormalized",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agresor_RutNormalized",
                table: "Agresor",
                column: "RutNormalized",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Testigo_RutNormalized",
                table: "Testigo");

            migrationBuilder.DropIndex(
                name: "IX_Agresor_RutNormalized",
                table: "Agresor");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(2650), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(5410), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(3980), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(3800), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(7860), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 930, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(6430), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(6720), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 929, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(7790), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(7480), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(4390), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(3050), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(510), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(240), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 928, DateTimeKind.Unspecified).AddTicks(1350), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(8650), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(9840), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(8480), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(9620), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(7220), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(7050), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(8140), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "RutNormalized",
                table: "Agresor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Rut",
                table: "Agresor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Agresor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Agresor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(6530), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Agresor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Agresor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Digito",
                table: "Agresor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<int>(
                name: "ComunaId",
                table: "Agresor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAgresion",
                table: "Agresion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Local).AddTicks(2350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(1870), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 1, 23, 27, 927, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
