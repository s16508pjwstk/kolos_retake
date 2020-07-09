using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolos_retake.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtMovements",
                columns: table => new
                {
                    IdArtMovement = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdNextArtMovement = table.Column<int>(nullable: true),
                    IdMovementFounder = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    DateFounded = table.Column<DateTime>(nullable: false),
                    ArtMovementIdArtMovement = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMovements", x => x.IdArtMovement);
                    table.ForeignKey(
                        name: "FK_ArtMovements_ArtMovements_ArtMovementIdArtMovement",
                        column: x => x.ArtMovementIdArtMovement,
                        principalTable: "ArtMovements",
                        principalColumn: "IdArtMovement",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    IdCity = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Population = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.IdCity);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    IdArtist = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdArtMovement = table.Column<int>(nullable: false),
                    IdCityOfBirth = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    NickName = table.Column<string>(maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CityIdCity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.IdArtist);
                    table.ForeignKey(
                        name: "FK_Artists_Cities_CityIdCity",
                        column: x => x.CityIdCity,
                        principalTable: "Cities",
                        principalColumn: "IdCity",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artists_ArtMovements_IdArtMovement",
                        column: x => x.IdArtMovement,
                        principalTable: "ArtMovements",
                        principalColumn: "IdArtMovement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paintings",
                columns: table => new
                {
                    IdPainting = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurfaceType = table.Column<string>(nullable: true),
                    PaintingMedia = table.Column<string>(nullable: true),
                    IdArtist = table.Column<int>(nullable: false),
                    IdCoAuthor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paintings", x => x.IdPainting);
                    table.ForeignKey(
                        name: "FK_Paintings_Artists_IdArtist",
                        column: x => x.IdArtist,
                        principalTable: "Artists",
                        principalColumn: "IdArtist",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_CityIdCity",
                table: "Artists",
                column: "CityIdCity");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_IdArtMovement",
                table: "Artists",
                column: "IdArtMovement",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArtMovements_ArtMovementIdArtMovement",
                table: "ArtMovements",
                column: "ArtMovementIdArtMovement");

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_IdArtist",
                table: "Paintings",
                column: "IdArtist");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paintings");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "ArtMovements");
        }
    }
}
