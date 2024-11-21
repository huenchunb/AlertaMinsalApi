using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAlertaMinsal.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgresionSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Comunas_ComunaId",
                table: "Empleados");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(3690), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 51, DateTimeKind.Unspecified).AddTicks(3320), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(3500), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 51, DateTimeKind.Unspecified).AddTicks(3110), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(2080), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 51, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(1920), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 51, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(440), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(2670), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(7500), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(7300), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(1090), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(5930), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(5750), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(1150), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(3170), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(370), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 49, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(110), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 49, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 420, DateTimeKind.Unspecified).AddTicks(8580), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 49, DateTimeKind.Unspecified).AddTicks(4990), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 420, DateTimeKind.Unspecified).AddTicks(8430), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 49, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.CreateTable(
                name: "Agresion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAgresion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 11, 13, 22, 1, 11, 419, DateTimeKind.Local).AddTicks(1610)),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 419, DateTimeKind.Unspecified).AddTicks(970), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 419, DateTimeKind.Unspecified).AddTicks(1350), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agresion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agresion_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Testigo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Digito = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    RutNormalized = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testigo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAgresion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(6770), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(7010), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAgresion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAgresor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(8530), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAgresor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgresionTestigo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgresionId = table.Column<int>(type: "int", nullable: false),
                    TestigoId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 419, DateTimeKind.Unspecified).AddTicks(3120), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 419, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgresionTestigo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgresionTestigo_Agresion_AgresionId",
                        column: x => x.AgresionId,
                        principalTable: "Agresion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgresionTestigo_Testigo_TestigoId",
                        column: x => x.TestigoId,
                        principalTable: "Testigo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaAgresion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TipoAgresionId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 420, DateTimeKind.Unspecified).AddTicks(7250), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 420, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaAgresion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriaAgresion_TipoAgresion_TipoAgresionId",
                        column: x => x.TipoAgresionId,
                        principalTable: "TipoAgresion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agresor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoAgresorId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Digito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RutNormalized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComunaId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 419, DateTimeKind.Unspecified).AddTicks(4530), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 419, DateTimeKind.Unspecified).AddTicks(4800), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agresor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agresor_Comunas_ComunaId",
                        column: x => x.ComunaId,
                        principalTable: "Comunas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agresor_TipoAgresor_TipoAgresorId",
                        column: x => x.TipoAgresorId,
                        principalTable: "TipoAgresor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agresion_EmpleadoId",
                table: "Agresion",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_AgresionTestigo_AgresionId",
                table: "AgresionTestigo",
                column: "AgresionId");

            migrationBuilder.CreateIndex(
                name: "IX_AgresionTestigo_TestigoId",
                table: "AgresionTestigo",
                column: "TestigoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agresor_ComunaId",
                table: "Agresor",
                column: "ComunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Agresor_TipoAgresorId",
                table: "Agresor",
                column: "TipoAgresorId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaAgresion_TipoAgresionId",
                table: "CategoriaAgresion",
                column: "TipoAgresionId");

            migrationBuilder.CreateIndex(
                name: "IX_Testigo_Email",
                table: "Testigo",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoAgresion_Name",
                table: "TipoAgresion",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoAgresor_Name",
                table: "TipoAgresor",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Comunas_ComunaId",
                table: "Empleados",
                column: "ComunaId",
                principalTable: "Comunas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Comunas_ComunaId",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "AgresionTestigo");

            migrationBuilder.DropTable(
                name: "Agresor");

            migrationBuilder.DropTable(
                name: "CategoriaAgresion");

            migrationBuilder.DropTable(
                name: "Agresion");

            migrationBuilder.DropTable(
                name: "Testigo");

            migrationBuilder.DropTable(
                name: "TipoAgresor");

            migrationBuilder.DropTable(
                name: "TipoAgresion");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 51, DateTimeKind.Unspecified).AddTicks(3320), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(3690), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposUrgencias",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 51, DateTimeKind.Unspecified).AddTicks(3110), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(3500), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 51, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(2080), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposEstablecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 51, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(1920), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(440), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "TiposAtenciones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 423, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(7500), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(2670), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(7300), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(5930), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(1090), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Niveles",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(5750), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 422, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Establecimientos",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 50, DateTimeKind.Unspecified).AddTicks(1150), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(3170), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Empleados",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 49, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(370), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 49, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 421, DateTimeKind.Unspecified).AddTicks(110), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 49, DateTimeKind.Unspecified).AddTicks(4990), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 420, DateTimeKind.Unspecified).AddTicks(8580), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Complejidades",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 10, 12, 23, 52, 49, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, -3, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 11, 13, 22, 1, 11, 420, DateTimeKind.Unspecified).AddTicks(8430), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Comunas_ComunaId",
                table: "Empleados",
                column: "ComunaId",
                principalTable: "Comunas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
