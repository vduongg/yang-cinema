using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.API.Migrations
{
    /// <inheritdoc />
    public partial class DbV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actors",
                columns: table => new
                {
                    actorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actors", x => x.actorId);
                });

            migrationBuilder.CreateTable(
                name: "citys",
                columns: table => new
                {
                    cityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citys", x => x.cityId);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    countryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.countryId);
                });

            migrationBuilder.CreateTable(
                name: "directors",
                columns: table => new
                {
                    directorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    directorIdName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directors", x => x.directorId);
                });

            migrationBuilder.CreateTable(
                name: "movieTypes",
                columns: table => new
                {
                    movieTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieTypes", x => x.movieTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    roomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roomName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.roomID);
                });

            migrationBuilder.CreateTable(
                name: "wards",
                columns: table => new
                {
                    wardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wardCode = table.Column<int>(type: "int", nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wards", x => x.wardId);
                    table.ForeignKey(
                        name: "FK_wards_citys_cityId",
                        column: x => x.cityId,
                        principalTable: "citys",
                        principalColumn: "cityId");
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    releaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false),
                    directorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movieId);
                    table.ForeignKey(
                        name: "FK_Movies_Country_countryId",
                        column: x => x.countryId,
                        principalTable: "Country",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_directors_directorId",
                        column: x => x.directorId,
                        principalTable: "directors",
                        principalColumn: "directorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    cinemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cinemaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.cinemaId);
                    table.ForeignKey(
                        name: "FK_Cinema_wards_wardId",
                        column: x => x.wardId,
                        principalTable: "wards",
                        principalColumn: "wardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    actorListactorId = table.Column<int>(type: "int", nullable: false),
                    moviesmovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.actorListactorId, x.moviesmovieId });
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movies_moviesmovieId",
                        column: x => x.moviesmovieId,
                        principalTable: "Movies",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_actors_actorListactorId",
                        column: x => x.actorListactorId,
                        principalTable: "actors",
                        principalColumn: "actorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cinemaSessons",
                columns: table => new
                {
                    cinemaSessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cinemaId = table.Column<int>(type: "int", nullable: false),
                    startedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    startedTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    movieId = table.Column<int>(type: "int", nullable: false),
                    roomID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cinemaSessons", x => x.cinemaSessonId);
                    table.ForeignKey(
                        name: "FK_cinemaSessons_Movies_movieId",
                        column: x => x.movieId,
                        principalTable: "Movies",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cinemaSessons_Room_roomID",
                        column: x => x.roomID,
                        principalTable: "Room",
                        principalColumn: "roomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieMovieType",
                columns: table => new
                {
                    moviesmovieId = table.Column<int>(type: "int", nullable: false),
                    typeListmovieTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieMovieType", x => new { x.moviesmovieId, x.typeListmovieTypeId });
                    table.ForeignKey(
                        name: "FK_MovieMovieType_Movies_moviesmovieId",
                        column: x => x.moviesmovieId,
                        principalTable: "Movies",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieMovieType_movieTypes_typeListmovieTypeId",
                        column: x => x.typeListmovieTypeId,
                        principalTable: "movieTypes",
                        principalColumn: "movieTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_moviesmovieId",
                table: "ActorMovie",
                column: "moviesmovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Cinema_wardId",
                table: "Cinema",
                column: "wardId");

            migrationBuilder.CreateIndex(
                name: "IX_cinemaSessons_movieId",
                table: "cinemaSessons",
                column: "movieId");

            migrationBuilder.CreateIndex(
                name: "IX_cinemaSessons_roomID",
                table: "cinemaSessons",
                column: "roomID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovieType_typeListmovieTypeId",
                table: "MovieMovieType",
                column: "typeListmovieTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_countryId",
                table: "Movies",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_directorId",
                table: "Movies",
                column: "directorId");

            migrationBuilder.CreateIndex(
                name: "IX_wards_cityId",
                table: "wards",
                column: "cityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.DropTable(
                name: "Cinema");

            migrationBuilder.DropTable(
                name: "cinemaSessons");

            migrationBuilder.DropTable(
                name: "MovieMovieType");

            migrationBuilder.DropTable(
                name: "actors");

            migrationBuilder.DropTable(
                name: "wards");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "movieTypes");

            migrationBuilder.DropTable(
                name: "citys");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "directors");
        }
    }
}
