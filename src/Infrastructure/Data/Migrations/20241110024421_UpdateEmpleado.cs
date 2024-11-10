using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAlertaMinsal.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmpleado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 84, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(3960), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 84, DateTimeKind.Unspecified).AddTicks(660), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(2530), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(9080), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(700), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(8590), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(5350), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(8350), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(6970), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(3840), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(3660), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(9980), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(2800), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "StreetNumber",
                table: "Empleados",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 778, DateTimeKind.Unspecified).AddTicks(9610), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(6610), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 778, DateTimeKind.Unspecified).AddTicks(9390), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(6320), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 778, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(4710), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 778, DateTimeKind.Unspecified).AddTicks(7460), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, -3, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetNumber",
                table: "Empleados");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 84, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 84, DateTimeKind.Unspecified).AddTicks(660), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(3960), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(2530), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(9080), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 780, DateTimeKind.Unspecified).AddTicks(700), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(5350), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(8590), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(8350), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(3840), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(6970), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 83, DateTimeKind.Unspecified).AddTicks(3660), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(9980), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 779, DateTimeKind.Unspecified).AddTicks(2800), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(6610), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 778, DateTimeKind.Unspecified).AddTicks(9610), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(6320), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 778, DateTimeKind.Unspecified).AddTicks(9390), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(4710), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 778, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 22, 43, 16, 82, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 9, 23, 44, 21, 778, DateTimeKind.Unspecified).AddTicks(7460), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
