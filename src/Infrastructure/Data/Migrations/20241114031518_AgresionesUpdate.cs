using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAlertaMinsal.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgresionesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agresion_Empleados_EmpleadoId",
                table: "Agresion");

            migrationBuilder.DropForeignKey(
                name: "FK_AgresionCategoria_Agresion_AgresionId",
                table: "AgresionCategoria");

            migrationBuilder.DropForeignKey(
                name: "FK_AgresionCategoria_CategoriaAgresion_CategoriaAgresionId",
                table: "AgresionCategoria");

            migrationBuilder.DropForeignKey(
                name: "FK_AgresionTestigo_Agresion_AgresionId",
                table: "AgresionTestigo");

            migrationBuilder.DropForeignKey(
                name: "FK_AgresionTestigo_Testigo_TestigoId",
                table: "AgresionTestigo");

            migrationBuilder.DropForeignKey(
                name: "FK_Agresor_Comunas_ComunaId",
                table: "Agresor");

            migrationBuilder.DropForeignKey(
                name: "FK_Agresor_TipoAgresor_TipoAgresorId",
                table: "Agresor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaAgresion_TipoAgresion_TipoAgresionId",
                table: "CategoriaAgresion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoAgresor",
                table: "TipoAgresor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoAgresion",
                table: "TipoAgresion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testigo",
                table: "Testigo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriaAgresion",
                table: "CategoriaAgresion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agresor",
                table: "Agresor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgresionTestigo",
                table: "AgresionTestigo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgresionCategoria",
                table: "AgresionCategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agresion",
                table: "Agresion");

            migrationBuilder.RenameTable(
                name: "TipoAgresor",
                newName: "TiposAgresores");

            migrationBuilder.RenameTable(
                name: "TipoAgresion",
                newName: "TiposAgresiones");

            migrationBuilder.RenameTable(
                name: "Testigo",
                newName: "Testigos");

            migrationBuilder.RenameTable(
                name: "CategoriaAgresion",
                newName: "TipoAgresionCategorias");

            migrationBuilder.RenameTable(
                name: "Agresor",
                newName: "Agresores");

            migrationBuilder.RenameTable(
                name: "AgresionTestigo",
                newName: "AgresionesTestigos");

            migrationBuilder.RenameTable(
                name: "AgresionCategoria",
                newName: "AgresionesCategorias");

            migrationBuilder.RenameTable(
                name: "Agresion",
                newName: "Agresiones");

            migrationBuilder.RenameIndex(
                name: "IX_TipoAgresor_Name",
                table: "TiposAgresores",
                newName: "IX_TiposAgresores_Name");

            migrationBuilder.RenameIndex(
                name: "IX_TipoAgresion_Name",
                table: "TiposAgresiones",
                newName: "IX_TiposAgresiones_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Testigo_Email",
                table: "Testigos",
                newName: "IX_Testigos_Email");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaAgresion_TipoAgresionId",
                table: "TipoAgresionCategorias",
                newName: "IX_TipoAgresionCategorias_TipoAgresionId");

            migrationBuilder.RenameIndex(
                name: "IX_Agresor_TipoAgresorId",
                table: "Agresores",
                newName: "IX_Agresores_TipoAgresorId");

            migrationBuilder.RenameIndex(
                name: "IX_Agresor_ComunaId",
                table: "Agresores",
                newName: "IX_Agresores_ComunaId");

            migrationBuilder.RenameIndex(
                name: "IX_AgresionTestigo_TestigoId",
                table: "AgresionesTestigos",
                newName: "IX_AgresionesTestigos_TestigoId");

            migrationBuilder.RenameIndex(
                name: "IX_AgresionCategoria_CategoriaAgresionId",
                table: "AgresionesCategorias",
                newName: "IX_AgresionesCategorias_CategoriaAgresionId");

            migrationBuilder.RenameIndex(
                name: "IX_Agresion_EmpleadoId",
                table: "Agresiones",
                newName: "IX_Agresiones_EmpleadoId");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(9210), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(5200), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(5030), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(3540), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(3370), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(1890), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(5500), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(1720), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(6700), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(2400), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(8010), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(8530), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(4630), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(8260), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(5300), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(1170), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAgresores",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(150), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAgresores",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(9910), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAgresiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAgresiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Testigos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(6450), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Testigos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresionCategorias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresionCategorias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(7880), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresores",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(840), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(6800), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresores",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(610), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(6530), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(3030), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAgresion",
                table: "Agresiones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Local).AddTicks(7460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(2670), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposAgresores",
                table: "TiposAgresores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposAgresiones",
                table: "TiposAgresiones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testigos",
                table: "Testigos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoAgresionCategorias",
                table: "TipoAgresionCategorias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agresores",
                table: "Agresores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgresionesTestigos",
                table: "AgresionesTestigos",
                columns: new[] { "AgresionId", "TestigoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgresionesCategorias",
                table: "AgresionesCategorias",
                columns: new[] { "AgresionId", "CategoriaAgresionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agresiones",
                table: "Agresiones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agresiones_Empleados_EmpleadoId",
                table: "Agresiones",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AgresionesCategorias_Agresiones_AgresionId",
                table: "AgresionesCategorias",
                column: "AgresionId",
                principalTable: "Agresiones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AgresionesCategorias_TipoAgresionCategorias_CategoriaAgresionId",
                table: "AgresionesCategorias",
                column: "CategoriaAgresionId",
                principalTable: "TipoAgresionCategorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgresionesTestigos_Agresiones_AgresionId",
                table: "AgresionesTestigos",
                column: "AgresionId",
                principalTable: "Agresiones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AgresionesTestigos_Testigos_TestigoId",
                table: "AgresionesTestigos",
                column: "TestigoId",
                principalTable: "Testigos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agresores_Comunas_ComunaId",
                table: "Agresores",
                column: "ComunaId",
                principalTable: "Comunas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agresores_TiposAgresores_TipoAgresorId",
                table: "Agresores",
                column: "TipoAgresorId",
                principalTable: "TiposAgresores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoAgresionCategorias_TiposAgresiones_TipoAgresionId",
                table: "TipoAgresionCategorias",
                column: "TipoAgresionId",
                principalTable: "TiposAgresiones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agresiones_Empleados_EmpleadoId",
                table: "Agresiones");

            migrationBuilder.DropForeignKey(
                name: "FK_AgresionesCategorias_Agresiones_AgresionId",
                table: "AgresionesCategorias");

            migrationBuilder.DropForeignKey(
                name: "FK_AgresionesCategorias_TipoAgresionCategorias_CategoriaAgresionId",
                table: "AgresionesCategorias");

            migrationBuilder.DropForeignKey(
                name: "FK_AgresionesTestigos_Agresiones_AgresionId",
                table: "AgresionesTestigos");

            migrationBuilder.DropForeignKey(
                name: "FK_AgresionesTestigos_Testigos_TestigoId",
                table: "AgresionesTestigos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agresores_Comunas_ComunaId",
                table: "Agresores");

            migrationBuilder.DropForeignKey(
                name: "FK_Agresores_TiposAgresores_TipoAgresorId",
                table: "Agresores");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoAgresionCategorias_TiposAgresiones_TipoAgresionId",
                table: "TipoAgresionCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposAgresores",
                table: "TiposAgresores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposAgresiones",
                table: "TiposAgresiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoAgresionCategorias",
                table: "TipoAgresionCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testigos",
                table: "Testigos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agresores",
                table: "Agresores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgresionesTestigos",
                table: "AgresionesTestigos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AgresionesCategorias",
                table: "AgresionesCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agresiones",
                table: "Agresiones");

            migrationBuilder.RenameTable(
                name: "TiposAgresores",
                newName: "TipoAgresor");

            migrationBuilder.RenameTable(
                name: "TiposAgresiones",
                newName: "TipoAgresion");

            migrationBuilder.RenameTable(
                name: "TipoAgresionCategorias",
                newName: "CategoriaAgresion");

            migrationBuilder.RenameTable(
                name: "Testigos",
                newName: "Testigo");

            migrationBuilder.RenameTable(
                name: "Agresores",
                newName: "Agresor");

            migrationBuilder.RenameTable(
                name: "AgresionesTestigos",
                newName: "AgresionTestigo");

            migrationBuilder.RenameTable(
                name: "AgresionesCategorias",
                newName: "AgresionCategoria");

            migrationBuilder.RenameTable(
                name: "Agresiones",
                newName: "Agresion");

            migrationBuilder.RenameIndex(
                name: "IX_TiposAgresores_Name",
                table: "TipoAgresor",
                newName: "IX_TipoAgresor_Name");

            migrationBuilder.RenameIndex(
                name: "IX_TiposAgresiones_Name",
                table: "TipoAgresion",
                newName: "IX_TipoAgresion_Name");

            migrationBuilder.RenameIndex(
                name: "IX_TipoAgresionCategorias_TipoAgresionId",
                table: "CategoriaAgresion",
                newName: "IX_CategoriaAgresion_TipoAgresionId");

            migrationBuilder.RenameIndex(
                name: "IX_Testigos_Email",
                table: "Testigo",
                newName: "IX_Testigo_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Agresores_TipoAgresorId",
                table: "Agresor",
                newName: "IX_Agresor_TipoAgresorId");

            migrationBuilder.RenameIndex(
                name: "IX_Agresores_ComunaId",
                table: "Agresor",
                newName: "IX_Agresor_ComunaId");

            migrationBuilder.RenameIndex(
                name: "IX_AgresionesTestigos_TestigoId",
                table: "AgresionTestigo",
                newName: "IX_AgresionTestigo_TestigoId");

            migrationBuilder.RenameIndex(
                name: "IX_AgresionesCategorias_CategoriaAgresionId",
                table: "AgresionCategoria",
                newName: "IX_AgresionCategoria_CategoriaAgresionId");

            migrationBuilder.RenameIndex(
                name: "IX_Agresiones_EmpleadoId",
                table: "Agresion",
                newName: "IX_Agresion_EmpleadoId");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(5200), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(9210), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(5030), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(3540), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(3370), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(1890), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(1720), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(5500), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(2400), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(6700), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(8010), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(4630), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(8530), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(8260), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 896, DateTimeKind.Unspecified).AddTicks(1170), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(5300), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 898, DateTimeKind.Unspecified).AddTicks(150), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(9910), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(7880), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(6450), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 897, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(6800), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(840), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(6530), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(610), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(3030), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAgresion",
                table: "Agresion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Local).AddTicks(3290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 25, 15, 895, DateTimeKind.Unspecified).AddTicks(2670), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoAgresor",
                table: "TipoAgresor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoAgresion",
                table: "TipoAgresion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriaAgresion",
                table: "CategoriaAgresion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testigo",
                table: "Testigo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agresor",
                table: "Agresor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgresionTestigo",
                table: "AgresionTestigo",
                columns: new[] { "AgresionId", "TestigoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgresionCategoria",
                table: "AgresionCategoria",
                columns: new[] { "AgresionId", "CategoriaAgresionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agresion",
                table: "Agresion",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agresion_Empleados_EmpleadoId",
                table: "Agresion",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AgresionCategoria_Agresion_AgresionId",
                table: "AgresionCategoria",
                column: "AgresionId",
                principalTable: "Agresion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AgresionCategoria_CategoriaAgresion_CategoriaAgresionId",
                table: "AgresionCategoria",
                column: "CategoriaAgresionId",
                principalTable: "CategoriaAgresion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AgresionTestigo_Agresion_AgresionId",
                table: "AgresionTestigo",
                column: "AgresionId",
                principalTable: "Agresion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AgresionTestigo_Testigo_TestigoId",
                table: "AgresionTestigo",
                column: "TestigoId",
                principalTable: "Testigo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agresor_Comunas_ComunaId",
                table: "Agresor",
                column: "ComunaId",
                principalTable: "Comunas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agresor_TipoAgresor_TipoAgresorId",
                table: "Agresor",
                column: "TipoAgresorId",
                principalTable: "TipoAgresor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaAgresion_TipoAgresion_TipoAgresionId",
                table: "CategoriaAgresion",
                column: "TipoAgresionId",
                principalTable: "TipoAgresion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
