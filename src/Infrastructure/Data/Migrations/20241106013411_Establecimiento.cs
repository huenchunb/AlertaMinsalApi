using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAlertaMinsal.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Establecimiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Created",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Regiones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Regiones",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(7010), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Regiones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Created",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Comunas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModified",
                table: "Comunas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Comunas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ComplejidadEstablecimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 62, DateTimeKind.Unspecified).AddTicks(8550), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 62, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplejidadEstablecimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NivelEstablecimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(5000), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(5240), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelEstablecimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAtencionEstablecimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(9290), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAtencionEstablecimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEstablecimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEstablecimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoUrgenciaEstablecimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(2550), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 64, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUrgenciaEstablecimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Establecimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TipoEstablecimientoId = table.Column<int>(type: "int", nullable: false),
                    NivelEstablecimientoId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Urgency = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    TipoUrgenciaEstablecimientoId = table.Column<int>(type: "int", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    ComplejidadEstablecimientoId = table.Column<int>(type: "int", nullable: false),
                    TipoAtencionEstablecimientoId = table.Column<int>(type: "int", nullable: false),
                    ComunaId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, -3, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 11, 5, 22, 34, 11, 63, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, -3, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establecimiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Establecimiento_ComplejidadEstablecimiento_ComplejidadEstablecimientoId",
                        column: x => x.ComplejidadEstablecimientoId,
                        principalTable: "ComplejidadEstablecimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Establecimiento_Comunas_ComunaId",
                        column: x => x.ComunaId,
                        principalTable: "Comunas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Establecimiento_NivelEstablecimiento_NivelEstablecimientoId",
                        column: x => x.NivelEstablecimientoId,
                        principalTable: "NivelEstablecimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Establecimiento_TipoAtencionEstablecimiento_TipoAtencionEstablecimientoId",
                        column: x => x.TipoAtencionEstablecimientoId,
                        principalTable: "TipoAtencionEstablecimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Establecimiento_TipoEstablecimiento_TipoEstablecimientoId",
                        column: x => x.TipoEstablecimientoId,
                        principalTable: "TipoEstablecimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Establecimiento_TipoUrgenciaEstablecimiento_TipoUrgenciaEstablecimientoId",
                        column: x => x.TipoUrgenciaEstablecimientoId,
                        principalTable: "TipoUrgenciaEstablecimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplejidadEstablecimiento_Name",
                table: "ComplejidadEstablecimiento",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Establecimiento_ComplejidadEstablecimientoId",
                table: "Establecimiento",
                column: "ComplejidadEstablecimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Establecimiento_ComunaId",
                table: "Establecimiento",
                column: "ComunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Establecimiento_Name",
                table: "Establecimiento",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Establecimiento_NivelEstablecimientoId",
                table: "Establecimiento",
                column: "NivelEstablecimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Establecimiento_TipoAtencionEstablecimientoId",
                table: "Establecimiento",
                column: "TipoAtencionEstablecimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Establecimiento_TipoEstablecimientoId",
                table: "Establecimiento",
                column: "TipoEstablecimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Establecimiento_TipoUrgenciaEstablecimientoId",
                table: "Establecimiento",
                column: "TipoUrgenciaEstablecimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_NivelEstablecimiento_Name",
                table: "NivelEstablecimiento",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoAtencionEstablecimiento_Name",
                table: "TipoAtencionEstablecimiento",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoEstablecimiento_Name",
                table: "TipoEstablecimiento",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoUrgenciaEstablecimiento_Name",
                table: "TipoUrgenciaEstablecimiento",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Establecimiento");

            migrationBuilder.DropTable(
                name: "ComplejidadEstablecimiento");

            migrationBuilder.DropTable(
                name: "NivelEstablecimiento");

            migrationBuilder.DropTable(
                name: "TipoAtencionEstablecimiento");

            migrationBuilder.DropTable(
                name: "TipoEstablecimiento");

            migrationBuilder.DropTable(
                name: "TipoUrgenciaEstablecimiento");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Regiones");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Regiones");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Regiones");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Regiones");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Comunas");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Comunas");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Comunas");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Comunas");
        }
    }
}
