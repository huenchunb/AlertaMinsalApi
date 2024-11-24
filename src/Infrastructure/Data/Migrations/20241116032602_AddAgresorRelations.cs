using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAlertaMinsal.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAgresorRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Comunas_Regiones_IdRegion",
                table: "Comunas");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Comunas_ComunaId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Establecimientos_EstablecimientoId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Estamentos_EstamentoId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Mutualidades_MutualidadId",
                table: "Empleados");

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

            migrationBuilder.DropForeignKey(
                name: "FK_TipoAgresionCategorias_TiposAgresiones_TipoAgresionId",
                table: "TipoAgresionCategorias");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_TodoLists_ListId",
                table: "TodoItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoLists",
                table: "TodoLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoItems",
                table: "TodoItems");

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
                name: "PK_Regiones",
                table: "Regiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Niveles",
                table: "Niveles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mutualidades",
                table: "Mutualidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estamentos",
                table: "Estamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Establecimientos",
                table: "Establecimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comunas",
                table: "Comunas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complejidades",
                table: "Complejidades");

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
                name: "TodoLists",
                newName: "TodoList");

            migrationBuilder.RenameTable(
                name: "TodoItems",
                newName: "TodoItem");

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
                name: "Regiones",
                newName: "Region");

            migrationBuilder.RenameTable(
                name: "Niveles",
                newName: "NivelEstablecimiento");

            migrationBuilder.RenameTable(
                name: "Mutualidades",
                newName: "Mutualidad");

            migrationBuilder.RenameTable(
                name: "Estamentos",
                newName: "Estamento");

            migrationBuilder.RenameTable(
                name: "Establecimientos",
                newName: "Establecimiento");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "Empleado");

            migrationBuilder.RenameTable(
                name: "Comunas",
                newName: "Comuna");

            migrationBuilder.RenameTable(
                name: "Complejidades",
                newName: "ComplejidadEstablecimiento");

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
                name: "IX_TodoItems_ListId",
                table: "TodoItem",
                newName: "IX_TodoItem_ListId");

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
                name: "IX_Regiones_Name",
                table: "Region",
                newName: "IX_Region_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Niveles_Name",
                table: "NivelEstablecimiento",
                newName: "IX_NivelEstablecimiento_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Mutualidades_Name",
                table: "Mutualidad",
                newName: "IX_Mutualidad_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Estamentos_Name",
                table: "Estamento",
                newName: "IX_Estamento_Name");

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
                name: "IX_Empleados_RutNormalized",
                table: "Empleado",
                newName: "IX_Empleado_RutNormalized");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_MutualidadId",
                table: "Empleado",
                newName: "IX_Empleado_MutualidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_EstamentoId",
                table: "Empleado",
                newName: "IX_Empleado_EstamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_EstablecimientoId",
                table: "Empleado",
                newName: "IX_Empleado_EstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_Email",
                table: "Empleado",
                newName: "IX_Empleado_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_ComunaId",
                table: "Empleado",
                newName: "IX_Empleado_ComunaId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_AccountId",
                table: "Empleado",
                newName: "IX_Empleado_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Comunas_Name",
                table: "Comuna",
                newName: "IX_Comuna_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Comunas_IdRegion",
                table: "Comuna",
                newName: "IX_Comuna_IdRegion");

            migrationBuilder.RenameIndex(
                name: "IX_Complejidades_Name",
                table: "ComplejidadEstablecimiento",
                newName: "IX_ComplejidadEstablecimiento_Name");

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
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(2650), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(9210), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoUrgenciaEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAtencionEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(5500), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(7860), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(6430), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(7220), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "CategoriaAgresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(7050), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Testigo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Region",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(6700), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "NivelEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(8530), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleado",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(3050), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(8260), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(510), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comuna",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(240), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(5300), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(8650), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "ComplejidadEstablecimiento",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(8480), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(840), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresor",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(610), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "AgresionId",
                table: "Agresor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAgresion",
                table: "Agresion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Local).AddTicks(2350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresion",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(1870), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoList",
                table: "TodoList",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoItem",
                table: "TodoItem",
                column: "Id");

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
                name: "PK_Region",
                table: "Region",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NivelEstablecimiento",
                table: "NivelEstablecimiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mutualidad",
                table: "Mutualidad",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estamento",
                table: "Estamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Establecimiento",
                table: "Establecimiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comuna",
                table: "Comuna",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComplejidadEstablecimiento",
                table: "ComplejidadEstablecimiento",
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

            migrationBuilder.CreateIndex(
                name: "IX_Agresor_AgresionId",
                table: "Agresor",
                column: "AgresionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agresion_Empleado_EmpleadoId",
                table: "Agresion",
                column: "EmpleadoId",
                principalTable: "Empleado",
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
                name: "FK_Agresor_Agresion_AgresionId",
                table: "Agresor",
                column: "AgresionId",
                principalTable: "Agresion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agresor_Comuna_ComunaId",
                table: "Agresor",
                column: "ComunaId",
                principalTable: "Comuna",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Comuna_Region_IdRegion",
                table: "Comuna",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Comuna_ComunaId",
                table: "Empleado",
                column: "ComunaId",
                principalTable: "Comuna",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Establecimiento_EstablecimientoId",
                table: "Empleado",
                column: "EstablecimientoId",
                principalTable: "Establecimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Estamento_EstamentoId",
                table: "Empleado",
                column: "EstamentoId",
                principalTable: "Estamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Mutualidad_MutualidadId",
                table: "Empleado",
                column: "MutualidadId",
                principalTable: "Mutualidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimiento_ComplejidadEstablecimiento_ComplejidadEstablecimientoId",
                table: "Establecimiento",
                column: "ComplejidadEstablecimientoId",
                principalTable: "ComplejidadEstablecimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Establecimiento_Comuna_ComunaId",
                table: "Establecimiento",
                column: "ComunaId",
                principalTable: "Comuna",
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

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItem_TodoList_ListId",
                table: "TodoItem",
                column: "ListId",
                principalTable: "TodoList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agresion_Empleado_EmpleadoId",
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
                name: "FK_Agresor_Agresion_AgresionId",
                table: "Agresor");

            migrationBuilder.DropForeignKey(
                name: "FK_Agresor_Comuna_ComunaId",
                table: "Agresor");

            migrationBuilder.DropForeignKey(
                name: "FK_Agresor_TipoAgresor_TipoAgresorId",
                table: "Agresor");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaAgresion_TipoAgresion_TipoAgresionId",
                table: "CategoriaAgresion");

            migrationBuilder.DropForeignKey(
                name: "FK_Comuna_Region_IdRegion",
                table: "Comuna");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Comuna_ComunaId",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Establecimiento_EstablecimientoId",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Estamento_EstamentoId",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Mutualidad_MutualidadId",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimiento_ComplejidadEstablecimiento_ComplejidadEstablecimientoId",
                table: "Establecimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Establecimiento_Comuna_ComunaId",
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

            migrationBuilder.DropForeignKey(
                name: "FK_TodoItem_TodoList_ListId",
                table: "TodoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoList",
                table: "TodoList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoItem",
                table: "TodoItem");

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
                name: "PK_TipoAgresor",
                table: "TipoAgresor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoAgresion",
                table: "TipoAgresion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testigo",
                table: "Testigo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NivelEstablecimiento",
                table: "NivelEstablecimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mutualidad",
                table: "Mutualidad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estamento",
                table: "Estamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Establecimiento",
                table: "Establecimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comuna",
                table: "Comuna");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComplejidadEstablecimiento",
                table: "ComplejidadEstablecimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriaAgresion",
                table: "CategoriaAgresion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agresor",
                table: "Agresor");

            migrationBuilder.DropIndex(
                name: "IX_Agresor_AgresionId",
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

            migrationBuilder.DropColumn(
                name: "AgresionId",
                table: "Agresor");

            migrationBuilder.RenameTable(
                name: "TodoList",
                newName: "TodoLists");

            migrationBuilder.RenameTable(
                name: "TodoItem",
                newName: "TodoItems");

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
                name: "TipoAgresor",
                newName: "TiposAgresores");

            migrationBuilder.RenameTable(
                name: "TipoAgresion",
                newName: "TiposAgresiones");

            migrationBuilder.RenameTable(
                name: "Testigo",
                newName: "Testigos");

            migrationBuilder.RenameTable(
                name: "Region",
                newName: "Regiones");

            migrationBuilder.RenameTable(
                name: "NivelEstablecimiento",
                newName: "Niveles");

            migrationBuilder.RenameTable(
                name: "Mutualidad",
                newName: "Mutualidades");

            migrationBuilder.RenameTable(
                name: "Estamento",
                newName: "Estamentos");

            migrationBuilder.RenameTable(
                name: "Establecimiento",
                newName: "Establecimientos");

            migrationBuilder.RenameTable(
                name: "Empleado",
                newName: "Empleados");

            migrationBuilder.RenameTable(
                name: "Comuna",
                newName: "Comunas");

            migrationBuilder.RenameTable(
                name: "ComplejidadEstablecimiento",
                newName: "Complejidades");

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
                name: "IX_TodoItem_ListId",
                table: "TodoItems",
                newName: "IX_TodoItems_ListId");

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
                name: "IX_Region_Name",
                table: "Regiones",
                newName: "IX_Regiones_Name");

            migrationBuilder.RenameIndex(
                name: "IX_NivelEstablecimiento_Name",
                table: "Niveles",
                newName: "IX_Niveles_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Mutualidad_Name",
                table: "Mutualidades",
                newName: "IX_Mutualidades_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Estamento_Name",
                table: "Estamentos",
                newName: "IX_Estamentos_Name");

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
                name: "IX_Empleado_RutNormalized",
                table: "Empleados",
                newName: "IX_Empleados_RutNormalized");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_MutualidadId",
                table: "Empleados",
                newName: "IX_Empleados_MutualidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_EstamentoId",
                table: "Empleados",
                newName: "IX_Empleados_EstamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_EstablecimientoId",
                table: "Empleados",
                newName: "IX_Empleados_EstablecimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_Email",
                table: "Empleados",
                newName: "IX_Empleados_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_ComunaId",
                table: "Empleados",
                newName: "IX_Empleados_ComunaId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_AccountId",
                table: "Empleados",
                newName: "IX_Empleados_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Comuna_Name",
                table: "Comunas",
                newName: "IX_Comunas_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Comuna_IdRegion",
                table: "Comunas",
                newName: "IX_Comunas_IdRegion");

            migrationBuilder.RenameIndex(
                name: "IX_ComplejidadEstablecimiento_Name",
                table: "Complejidades",
                newName: "IX_Complejidades_Name");

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(2650), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 75, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(5500), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAgresores",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(7860), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAgresores",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAgresiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(2560), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(6430), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAgresiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Testigos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Testigos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 514, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(6700), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 513, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(8530), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(8260), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(3050), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(510), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(5300), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 73, DateTimeKind.Unspecified).AddTicks(240), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(8650), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(8480), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TipoAgresionCategorias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(7220), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TipoAgresionCategorias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(7050), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresores",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(840), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresores",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 512, DateTimeKind.Unspecified).AddTicks(610), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Agresiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAgresion",
                table: "Agresiones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Local).AddTicks(7460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Agresiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 14, 0, 15, 18, 511, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 16, 0, 26, 2, 72, DateTimeKind.Unspecified).AddTicks(1870), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoLists",
                table: "TodoLists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoItems",
                table: "TodoItems",
                column: "Id");

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
                name: "PK_Regiones",
                table: "Regiones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Niveles",
                table: "Niveles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mutualidades",
                table: "Mutualidades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estamentos",
                table: "Estamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Establecimientos",
                table: "Establecimientos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comunas",
                table: "Comunas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complejidades",
                table: "Complejidades",
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
                name: "FK_Comunas_Regiones_IdRegion",
                table: "Comunas",
                column: "IdRegion",
                principalTable: "Regiones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Comunas_ComunaId",
                table: "Empleados",
                column: "ComunaId",
                principalTable: "Comunas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Establecimientos_EstablecimientoId",
                table: "Empleados",
                column: "EstablecimientoId",
                principalTable: "Establecimientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Estamentos_EstamentoId",
                table: "Empleados",
                column: "EstamentoId",
                principalTable: "Estamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Mutualidades_MutualidadId",
                table: "Empleados",
                column: "MutualidadId",
                principalTable: "Mutualidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_TipoAgresionCategorias_TiposAgresiones_TipoAgresionId",
                table: "TipoAgresionCategorias",
                column: "TipoAgresionId",
                principalTable: "TiposAgresiones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_TodoLists_ListId",
                table: "TodoItems",
                column: "ListId",
                principalTable: "TodoLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
