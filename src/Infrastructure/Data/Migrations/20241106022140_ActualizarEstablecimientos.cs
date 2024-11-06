using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAlertaMinsal.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarEstablecimientos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Establecimiento_ComplejidadEstablecimiento_ComplejidadEstablecimientoId",
                table: "Establecimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimiento_Comunas_ComunaId",
                table: "Establecimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimiento_NivelEstablecimiento_NivelEstablecimientoId",
                table: "Establecimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimiento_TipoAtencionEstablecimiento_TipoAtencionEstablecimientoId",
                table: "Establecimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimiento_TipoEstablecimiento_TipoEstablecimientoId",
                table: "Establecimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimiento_TipoUrgenciaEstablecimiento_TipoUrgenciaEstablecimientoId",
                table: "Establecimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoUrgenciaEstablecimiento",
                table: "TipoUrgenciaEstablecimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoEstablecimiento",
                table: "TipoEstablecimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoAtencionEstablecimiento",
                table: "TipoAtencionEstablecimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NivelEstablecimiento",
                table: "NivelEstablecimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Establecimiento",
                table: "Establecimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComplejidadEstablecimiento",
                table: "ComplejidadEstablecimiento");

            migrationBuilder.RenameTable(
                name: "TipoUrgenciaEstablecimiento",
                newName: "TiposUrgencias");

            migrationBuilder.RenameTable(
                name: "TipoEstablecimiento",
                newName: "TiposEstablecimientos");

            migrationBuilder.RenameTable(
                name: "TipoAtencionEstablecimiento",
                newName: "TiposAtenciones");

            migrationBuilder.RenameTable(
                name: "NivelEstablecimiento",
                newName: "Niveles");

            migrationBuilder.RenameTable(
                name: "Establecimiento",
                newName: "Establecimientos");

            migrationBuilder.RenameTable(
                name: "ComplejidadEstablecimiento",
                newName: "Complejidades");

            migrationBuilder.RenameIndex(
                name: "IX_TipoUrgenciaEstablecimiento_Name",
                table: "TiposUrgencias",
                newName: "IX_TiposUrgencias_Name");

            migrationBuilder.RenameIndex(
                name: "IX_TipoEstablecimiento_Name",
                table: "TiposEstablecimientos",
                newName: "IX_TiposEstablecimientos_Name");

            migrationBuilder.RenameIndex(
                name: "IX_TipoAtencionEstablecimiento_Name",
                table: "TiposAtenciones",
                newName: "IX_TiposAtenciones_Name");

            migrationBuilder.RenameIndex(
                name: "IX_NivelEstablecimiento_Name",
                table: "Niveles",
                newName: "IX_Niveles_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimiento_TipoUrgenciaEstablecimientoId",
                table: "Establecimientos",
                newName: "IX_Establecimientos_TipoUrgenciaEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimiento_TipoEstablecimientoId",
                table: "Establecimientos",
                newName: "IX_Establecimientos_TipoEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimiento_TipoAtencionEstablecimientoId",
                table: "Establecimientos",
                newName: "IX_Establecimientos_TipoAtencionEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimiento_NivelEstablecimientoId",
                table: "Establecimientos",
                newName: "IX_Establecimientos_NivelEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimiento_Name",
                table: "Establecimientos",
                newName: "IX_Establecimientos_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimiento_ComunaId",
                table: "Establecimientos",
                newName: "IX_Establecimientos_ComunaId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimiento_ComplejidadEstablecimientoId",
                table: "Establecimientos",
                newName: "IX_Establecimientos_ComplejidadEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_ComplejidadEstablecimiento_Name",
                table: "Complejidades",
                newName: "IX_Complejidades_Name");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(6830), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(7010), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(1510), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 741, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 741, DateTimeKind.Unspecified).AddTicks(1940), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(2550), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 741, DateTimeKind.Unspecified).AddTicks(540), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 741, DateTimeKind.Unspecified).AddTicks(350), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(9020), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(9290), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(5240), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(5000), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 739, DateTimeKind.Unspecified).AddTicks(9930), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 62, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 739, DateTimeKind.Unspecified).AddTicks(9650), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 62, DateTimeKind.Unspecified).AddTicks(8550), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposUrgencias",
                table: "TiposUrgencias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposEstablecimientos",
                table: "TiposEstablecimientos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposAtenciones",
                table: "TiposAtenciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Niveles",
                table: "Niveles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Establecimientos",
                table: "Establecimientos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complejidades",
                table: "Complejidades",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimientos_Complejidades_ComplejidadEstablecimientoId",
                table: "Establecimientos",
                column: "ComplejidadEstablecimientoId",
                principalTable: "Complejidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimientos_Comunas_ComunaId",
                table: "Establecimientos",
                column: "ComunaId",
                principalTable: "Comunas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimientos_Niveles_NivelEstablecimientoId",
                table: "Establecimientos",
                column: "NivelEstablecimientoId",
                principalTable: "Niveles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimientos_TiposAtenciones_TipoAtencionEstablecimientoId",
                table: "Establecimientos",
                column: "TipoAtencionEstablecimientoId",
                principalTable: "TiposAtenciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimientos_TiposEstablecimientos_TipoEstablecimientoId",
                table: "Establecimientos",
                column: "TipoEstablecimientoId",
                principalTable: "TiposEstablecimientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimientos_TiposUrgencias_TipoUrgenciaEstablecimientoId",
                table: "Establecimientos",
                column: "TipoUrgenciaEstablecimientoId",
                principalTable: "TiposUrgencias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Establecimientos_Complejidades_ComplejidadEstablecimientoId",
                table: "Establecimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimientos_Comunas_ComunaId",
                table: "Establecimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimientos_Niveles_NivelEstablecimientoId",
                table: "Establecimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimientos_TiposAtenciones_TipoAtencionEstablecimientoId",
                table: "Establecimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimientos_TiposEstablecimientos_TipoEstablecimientoId",
                table: "Establecimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimientos_TiposUrgencias_TipoUrgenciaEstablecimientoId",
                table: "Establecimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposUrgencias",
                table: "TiposUrgencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposEstablecimientos",
                table: "TiposEstablecimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposAtenciones",
                table: "TiposAtenciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Niveles",
                table: "Niveles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Establecimientos",
                table: "Establecimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complejidades",
                table: "Complejidades");

            migrationBuilder.RenameTable(
                name: "TiposUrgencias",
                newName: "TipoUrgenciaEstablecimiento");

            migrationBuilder.RenameTable(
                name: "TiposEstablecimientos",
                newName: "TipoEstablecimiento");

            migrationBuilder.RenameTable(
                name: "TiposAtenciones",
                newName: "TipoAtencionEstablecimiento");

            migrationBuilder.RenameTable(
                name: "Niveles",
                newName: "NivelEstablecimiento");

            migrationBuilder.RenameTable(
                name: "Establecimientos",
                newName: "Establecimiento");

            migrationBuilder.RenameTable(
                name: "Complejidades",
                newName: "ComplejidadEstablecimiento");

            migrationBuilder.RenameIndex(
                name: "IX_TiposUrgencias_Name",
                table: "TipoUrgenciaEstablecimiento",
                newName: "IX_TipoUrgenciaEstablecimiento_Name");

            migrationBuilder.RenameIndex(
                name: "IX_TiposEstablecimientos_Name",
                table: "TipoEstablecimiento",
                newName: "IX_TipoEstablecimiento_Name");

            migrationBuilder.RenameIndex(
                name: "IX_TiposAtenciones_Name",
                table: "TipoAtencionEstablecimiento",
                newName: "IX_TipoAtencionEstablecimiento_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Niveles_Name",
                table: "NivelEstablecimiento",
                newName: "IX_NivelEstablecimiento_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimientos_TipoUrgenciaEstablecimientoId",
                table: "Establecimiento",
                newName: "IX_Establecimiento_TipoUrgenciaEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimientos_TipoEstablecimientoId",
                table: "Establecimiento",
                newName: "IX_Establecimiento_TipoEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimientos_TipoAtencionEstablecimientoId",
                table: "Establecimiento",
                newName: "IX_Establecimiento_TipoAtencionEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimientos_NivelEstablecimientoId",
                table: "Establecimiento",
                newName: "IX_Establecimiento_NivelEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimientos_Name",
                table: "Establecimiento",
                newName: "IX_Establecimiento_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimientos_ComunaId",
                table: "Establecimiento",
                newName: "IX_Establecimiento_ComunaId");

            migrationBuilder.RenameIndex(
                name: "IX_Establecimientos_ComplejidadEstablecimientoId",
                table: "Establecimiento",
                newName: "IX_Establecimiento_ComplejidadEstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Complejidades_Name",
                table: "ComplejidadEstablecimiento",
                newName: "IX_ComplejidadEstablecimiento_Name");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(7010), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(6830), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(1510), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 741, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(2550), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 741, DateTimeKind.Unspecified).AddTicks(1940), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 741, DateTimeKind.Unspecified).AddTicks(540), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 741, DateTimeKind.Unspecified).AddTicks(350), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(9290), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(9020), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(5240), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(5000), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 740, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 62, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 739, DateTimeKind.Unspecified).AddTicks(9930), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 62, DateTimeKind.Unspecified).AddTicks(8550), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 23, 21, 40, 739, DateTimeKind.Unspecified).AddTicks(9650), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoUrgenciaEstablecimiento",
                table: "TipoUrgenciaEstablecimiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoEstablecimiento",
                table: "TipoEstablecimiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoAtencionEstablecimiento",
                table: "TipoAtencionEstablecimiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NivelEstablecimiento",
                table: "NivelEstablecimiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Establecimiento",
                table: "Establecimiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComplejidadEstablecimiento",
                table: "ComplejidadEstablecimiento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimiento_ComplejidadEstablecimiento_ComplejidadEstablecimientoId",
                table: "Establecimiento",
                column: "ComplejidadEstablecimientoId",
                principalTable: "ComplejidadEstablecimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimiento_Comunas_ComunaId",
                table: "Establecimiento",
                column: "ComunaId",
                principalTable: "Comunas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimiento_NivelEstablecimiento_NivelEstablecimientoId",
                table: "Establecimiento",
                column: "NivelEstablecimientoId",
                principalTable: "NivelEstablecimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimiento_TipoAtencionEstablecimiento_TipoAtencionEstablecimientoId",
                table: "Establecimiento",
                column: "TipoAtencionEstablecimientoId",
                principalTable: "TipoAtencionEstablecimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimiento_TipoEstablecimiento_TipoEstablecimientoId",
                table: "Establecimiento",
                column: "TipoEstablecimientoId",
                principalTable: "TipoEstablecimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimiento_TipoUrgenciaEstablecimiento_TipoUrgenciaEstablecimientoId",
                table: "Establecimiento",
                column: "TipoUrgenciaEstablecimientoId",
                principalTable: "TipoUrgenciaEstablecimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
