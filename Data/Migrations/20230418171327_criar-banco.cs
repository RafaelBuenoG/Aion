﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Aion.Data.Migrations
{
    /// <inheritdoc />
    public partial class criarbanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserNameLimitChange = table.Column<int>(type: "int", nullable: false),
                    FotoPerfil = table.Column<byte[]>(type: "longblob", nullable: true),
                    DataNasc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QtdeSem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "disciplina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disciplina", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PeriodoLetivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Semestre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoLetivo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usuario = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grade_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Disponibilidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiaSemana = table.Column<int>(type: "int", nullable: false),
                    HoraInicio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoraFim = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    AnoSemIngresso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disponibilidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disponibilidade_PeriodoLetivo_AnoSemIngresso",
                        column: x => x.AnoSemIngresso,
                        principalTable: "PeriodoLetivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disponibilidade_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GradeDisciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    DisciplinaId = table.Column<int>(type: "int", nullable: false),
                    Semestre = table.Column<int>(type: "int", nullable: false),
                    TemDivisao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CargaHoraria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeDisciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GradeDisciplinas_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GradeDisciplinas_disciplina_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "disciplina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnoSemIngresso = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turma_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turma_PeriodoLetivo_AnoSemIngresso",
                        column: x => x.AnoSemIngresso,
                        principalTable: "PeriodoLetivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Atribuicao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    GradeDisciplinasId = table.Column<int>(type: "int", nullable: false),
                    TurmaId = table.Column<int>(type: "int", nullable: false),
                    Matriz = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    GradeDisciplinaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atribuicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atribuicao_GradeDisciplinas_GradeDisciplinaId",
                        column: x => x.GradeDisciplinaId,
                        principalTable: "GradeDisciplinas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Atribuicao_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atribuicao_Turma_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5519ba39-e4e0-4537-8d6b-bb3c4bf9efc7", "42b2c9af-47f5-431d-b457-7fd56b4a6026", "Administrador", "ADMINISTRADOR" },
                    { "5f863392-eb62-48bf-8ff0-dd2b3d3146b2", "abb459c9-0245-4533-9f9a-33b4f21c3b65", "Professor", "PROFESSOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNasc", "Email", "EmailConfirmed", "FotoPerfil", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserNameLimitChange" },
                values: new object[] { "4c1ca73b-6b47-46d5-932a-52b199aadd22", 0, "5de35388-14bb-4c79-b6fc-9670f12b63eb", new DateTime(2005, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "rafaelbuenog2020@gmail.com", true, new byte[] { 255, 216, 255, 225, 0, 24, 69, 120, 105, 102, 0, 0, 73, 73, 42, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 236, 0, 17, 68, 117, 99, 107, 121, 0, 1, 0, 4, 0, 0, 0, 30, 0, 0, 255, 225, 3, 47, 104, 116, 116, 112, 58, 47, 47, 110, 115, 46, 97, 100, 111, 98, 101, 46, 99, 111, 109, 47, 120, 97, 112, 47, 49, 46, 48, 47, 0, 60, 63, 120, 112, 97, 99, 107, 101, 116, 32, 98, 101, 103, 105, 110, 61, 34, 239, 187, 191, 34, 32, 105, 100, 61, 34, 87, 53, 77, 48, 77, 112, 67, 101, 104, 105, 72, 122, 114, 101, 83, 122, 78, 84, 99, 122, 107, 99, 57, 100, 34, 63, 62, 32, 60, 120, 58, 120, 109, 112, 109, 101, 116, 97, 32, 120, 109, 108, 110, 115, 58, 120, 61, 34, 97, 100, 111, 98, 101, 58, 110, 115, 58, 109, 101, 116, 97, 47, 34, 32, 120, 58, 120, 109, 112, 116, 107, 61, 34, 65, 100, 111, 98, 101, 32, 88, 77, 80, 32, 67, 111, 114, 101, 32, 57, 46, 48, 45, 99, 48, 48, 48, 32, 55, 57, 46, 100, 97, 52, 97, 55, 101, 53, 101, 102, 44, 32, 50, 48, 50, 50, 47, 49, 49, 47, 50, 50, 45, 49, 51, 58, 53, 48, 58, 48, 55, 32, 32, 32, 32, 32, 32, 32, 32, 34, 62, 32, 60, 114, 100, 102, 58, 82, 68, 70, 32, 120, 109, 108, 110, 115, 58, 114, 100, 102, 61, 34, 104, 116, 116, 112, 58, 47, 47, 119, 119, 119, 46, 119, 51, 46, 111, 114, 103, 47, 49, 57, 57, 57, 47, 48, 50, 47, 50, 50, 45, 114, 100, 102, 45, 115, 121, 110, 116, 97, 120, 45, 110, 115, 35, 34, 62, 32, 60, 114, 100, 102, 58, 68, 101, 115, 99, 114, 105, 112, 116, 105, 111, 110, 32, 114, 100, 102, 58, 97, 98, 111, 117, 116, 61, 34, 34, 32, 120, 109, 108, 110, 115, 58, 120, 109, 112, 61, 34, 104, 116, 116, 112, 58, 47, 47, 110, 115, 46, 97, 100, 111, 98, 101, 46, 99, 111, 109, 47, 120, 97, 112, 47, 49, 46, 48, 47, 34, 32, 120, 109, 108, 110, 115, 58, 120, 109, 112, 77, 77, 61, 34, 104, 116, 116, 112, 58, 47, 47, 110, 115, 46, 97, 100, 111, 98, 101, 46, 99, 111, 109, 47, 120, 97, 112, 47, 49, 46, 48, 47, 109, 109, 47, 34, 32, 120, 109, 108, 110, 115, 58, 115, 116, 82, 101, 102, 61, 34, 104, 116, 116, 112, 58, 47, 47, 110, 115, 46, 97, 100, 111, 98, 101, 46, 99, 111, 109, 47, 120, 97, 112, 47, 49, 46, 48, 47, 115, 84, 121, 112, 101, 47, 82, 101, 115, 111, 117, 114, 99, 101, 82, 101, 102, 35, 34, 32, 120, 109, 112, 58, 67, 114, 101, 97, 116, 111, 114, 84, 111, 111, 108, 61, 34, 65, 100, 111, 98, 101, 32, 80, 104, 111, 116, 111, 115, 104, 111, 112, 32, 50, 52, 46, 49, 32, 40, 87, 105, 110, 100, 111, 119, 115, 41, 34, 32, 120, 109, 112, 77, 77, 58, 73, 110, 115, 116, 97, 110, 99, 101, 73, 68, 61, 34, 120, 109, 112, 46, 105, 105, 100, 58, 57, 68, 50, 53, 50, 51, 51, 48, 65, 56, 57, 54, 49, 49, 69, 68, 57, 68, 56, 56, 69, 57, 53, 54, 66, 66, 56, 52, 48, 67, 51, 48, 34, 32, 120, 109, 112, 77, 77, 58, 68, 111, 99, 117, 109, 101, 110, 116, 73, 68, 61, 34, 120, 109, 112, 46, 100, 105, 100, 58, 57, 68, 50, 53, 50, 51, 51, 49, 65, 56, 57, 54, 49, 49, 69, 68, 57, 68, 56, 56, 69, 57, 53, 54, 66, 66, 56, 52, 48, 67, 51, 48, 34, 62, 32, 60, 120, 109, 112, 77, 77, 58, 68, 101, 114, 105, 118, 101, 100, 70, 114, 111, 109, 32, 115, 116, 82, 101, 102, 58, 105, 110, 115, 116, 97, 110, 99, 101, 73, 68, 61, 34, 120, 109, 112, 46, 105, 105, 100, 58, 57, 68, 50, 53, 50, 51, 50, 69, 65, 56, 57, 54, 49, 49, 69, 68, 57, 68, 56, 56, 69, 57, 53, 54, 66, 66, 56, 52, 48, 67, 51, 48, 34, 32, 115, 116, 82, 101, 102, 58, 100, 111, 99, 117, 109, 101, 110, 116, 73, 68, 61, 34, 120, 109, 112, 46, 100, 105, 100, 58, 57, 68, 50, 53, 50, 51, 50, 70, 65, 56, 57, 54, 49, 49, 69, 68, 57, 68, 56, 56, 69, 57, 53, 54, 66, 66, 56, 52, 48, 67, 51, 48, 34, 47, 62, 32, 60, 47, 114, 100, 102, 58, 68, 101, 115, 99, 114, 105, 112, 116, 105, 111, 110, 62, 32, 60, 47, 114, 100, 102, 58, 82, 68, 70, 62, 32, 60, 47, 120, 58, 120, 109, 112, 109, 101, 116, 97, 62, 32, 60, 63, 120, 112, 97, 99, 107, 101, 116, 32, 101, 110, 100, 61, 34, 114, 34, 63, 62, 255, 238, 0, 14, 65, 100, 111, 98, 101, 0, 100, 192, 0, 0, 0, 1, 255, 219, 0, 132, 0, 16, 11, 11, 11, 12, 11, 16, 12, 12, 16, 23, 15, 13, 15, 23, 27, 20, 16, 16, 20, 27, 31, 23, 23, 23, 23, 23, 31, 30, 23, 26, 26, 26, 26, 23, 30, 30, 35, 37, 39, 37, 35, 30, 47, 47, 51, 51, 47, 47, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 1, 17, 15, 15, 17, 19, 17, 21, 18, 18, 21, 20, 17, 20, 17, 20, 26, 20, 22, 22, 20, 26, 38, 26, 26, 28, 26, 26, 38, 48, 35, 30, 30, 30, 30, 35, 48, 43, 46, 39, 39, 39, 46, 43, 53, 53, 48, 48, 53, 53, 64, 64, 63, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 255, 192, 0, 17, 8, 1, 94, 1, 94, 3, 1, 34, 0, 2, 17, 1, 3, 17, 1, 255, 196, 0, 166, 0, 0, 1, 5, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 1, 2, 4, 5, 6, 7, 1, 0, 3, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 16, 0, 2, 1, 2, 4, 4, 3, 4, 7, 5, 8, 1, 3, 5, 0, 0, 1, 2, 3, 0, 17, 33, 49, 18, 4, 65, 81, 19, 5, 97, 113, 34, 129, 145, 50, 6, 161, 177, 193, 66, 82, 35, 20, 209, 98, 114, 130, 51, 240, 225, 146, 162, 67, 83, 36, 21, 99, 194, 52, 22, 241, 178, 210, 131, 147, 17, 0, 2, 2, 2, 1, 2, 4, 5, 2, 3, 9, 0, 0, 0, 0, 0, 0, 1, 17, 2, 33, 3, 49, 65, 18, 81, 34, 50, 4, 97, 113, 129, 66, 19, 145, 114, 35, 51, 147, 161, 193, 82, 98, 146, 67, 83, 20, 5, 255, 218, 0, 12, 3, 1, 0, 2, 17, 3, 17, 0, 63, 0, 192, 192, 139, 95, 42, 123, 233, 32, 140, 232, 104, 77, 20, 217, 151, 10, 232, 103, 45, 120, 11, 132, 139, 113, 241, 12, 252, 106, 206, 209, 25, 206, 149, 93, 70, 224, 91, 204, 213, 37, 58, 108, 70, 98, 180, 98, 146, 22, 80, 110, 81, 185, 140, 43, 59, 112, 107, 67, 163, 61, 134, 35, 16, 93, 118, 127, 189, 134, 23, 172, 14, 225, 179, 59, 103, 120, 240, 244, 228, 120, 214, 246, 199, 187, 32, 129, 82, 99, 173, 212, 91, 87, 18, 43, 31, 187, 206, 147, 207, 36, 201, 128, 107, 125, 21, 53, 228, 183, 193, 141, 206, 149, 240, 169, 48, 212, 11, 12, 198, 44, 60, 40, 90, 135, 178, 181, 131, 9, 39, 113, 83, 73, 222, 63, 132, 225, 200, 208, 11, 99, 75, 85, 62, 208, 238, 131, 70, 41, 149, 237, 127, 73, 225, 70, 185, 172, 157, 100, 98, 56, 81, 99, 221, 72, 153, 155, 175, 35, 80, 234, 203, 91, 23, 83, 72, 49, 23, 28, 243, 164, 26, 214, 170, 201, 186, 133, 236, 53, 105, 62, 52, 81, 34, 131, 108, 239, 82, 209, 114, 91, 149, 200, 218, 109, 49, 248, 140, 164, 251, 197, 7, 80, 224, 106, 91, 135, 252, 189, 146, 228, 122, 76, 109, 252, 79, 253, 212, 34, 108, 41, 33, 147, 213, 72, 183, 42, 31, 87, 11, 1, 237, 166, 18, 220, 129, 84, 38, 94, 237, 146, 44, 123, 179, 35, 157, 42, 176, 203, 143, 137, 20, 37, 184, 141, 65, 206, 194, 130, 175, 166, 66, 163, 142, 21, 41, 24, 216, 90, 154, 193, 149, 179, 128, 158, 218, 96, 228, 12, 232, 37, 223, 1, 80, 58, 237, 99, 122, 98, 224, 177, 168, 83, 150, 21, 85, 110, 79, 141, 22, 96, 66, 165, 197, 185, 208, 18, 16, 184, 166, 36, 231, 65, 8, 196, 92, 84, 131, 176, 244, 240, 160, 36, 118, 109, 56, 154, 148, 111, 169, 88, 1, 158, 30, 250, 131, 161, 97, 114, 125, 148, 125, 156, 90, 217, 6, 56, 186, 223, 222, 41, 198, 9, 156, 151, 155, 243, 59, 218, 139, 88, 9, 163, 81, 252, 139, 89, 211, 34, 201, 60, 210, 224, 122, 146, 187, 227, 226, 107, 82, 16, 173, 220, 68, 182, 197, 90, 89, 47, 127, 194, 13, 171, 62, 40, 127, 44, 18, 139, 169, 177, 245, 49, 57, 227, 89, 193, 209, 94, 10, 155, 141, 162, 78, 1, 66, 18, 81, 145, 24, 6, 240, 53, 87, 105, 60, 155, 55, 104, 220, 94, 35, 253, 72, 179, 43, 127, 188, 191, 104, 173, 126, 154, 131, 143, 76, 31, 5, 191, 214, 104, 59, 141, 188, 51, 128, 175, 32, 87, 95, 233, 186, 168, 22, 62, 54, 204, 80, 48, 123, 93, 196, 189, 166, 67, 184, 218, 126, 127, 110, 155, 25, 160, 83, 113, 252, 113, 242, 53, 209, 36, 176, 110, 182, 195, 113, 182, 113, 46, 222, 65, 129, 30, 57, 169, 228, 69, 113, 65, 247, 27, 25, 200, 211, 232, 185, 18, 39, 220, 113, 204, 114, 53, 161, 176, 222, 254, 138, 83, 190, 218, 19, 38, 198, 92, 55, 123, 113, 152, 63, 140, 47, 6, 31, 77, 75, 67, 54, 165, 219, 133, 23, 76, 173, 136, 170, 236, 128, 231, 136, 60, 43, 73, 94, 41, 98, 93, 196, 44, 30, 22, 93, 106, 235, 145, 22, 172, 244, 86, 117, 14, 69, 139, 99, 166, 164, 162, 230, 195, 125, 211, 35, 111, 185, 107, 161, 194, 41, 15, 221, 253, 214, 63, 85, 104, 48, 198, 213, 148, 187, 20, 101, 6, 113, 112, 49, 211, 251, 107, 88, 15, 134, 244, 0, 65, 149, 69, 206, 149, 213, 192, 2, 125, 194, 245, 42, 22, 232, 219, 111, 41, 229, 27, 159, 242, 154, 16, 143, 57, 219, 57, 146, 82, 236, 111, 173, 157, 143, 243, 19, 141, 92, 112, 231, 106, 231, 253, 38, 146, 203, 143, 223, 69, 253, 149, 71, 99, 96, 7, 240, 147, 239, 171, 66, 87, 48, 164, 39, 21, 141, 218, 69, 60, 125, 98, 214, 173, 90, 33, 50, 223, 202, 234, 127, 238, 33, 57, 133, 134, 82, 124, 46, 0, 174, 186, 213, 205, 252, 171, 17, 61, 195, 115, 41, 22, 17, 192, 20, 31, 23, 108, 126, 170, 233, 106, 31, 168, 190, 135, 157, 33, 20, 84, 149, 85, 134, 188, 80, 224, 109, 195, 198, 171, 162, 147, 113, 122, 114, 167, 42, 222, 78, 88, 242, 134, 18, 139, 27, 103, 206, 136, 187, 167, 181, 137, 184, 224, 106, 162, 169, 214, 5, 20, 15, 86, 156, 232, 132, 74, 179, 241, 45, 46, 237, 128, 182, 162, 69, 38, 220, 234, 4, 80, 180, 98, 71, 58, 58, 237, 139, 56, 81, 129, 53, 56, 53, 243, 62, 160, 4, 134, 247, 25, 140, 168, 114, 185, 176, 101, 24, 113, 21, 99, 115, 181, 48, 49, 210, 73, 67, 145, 160, 187, 1, 24, 3, 62, 53, 117, 51, 187, 107, 144, 58, 137, 202, 162, 75, 140, 40, 130, 195, 30, 21, 23, 187, 54, 21, 68, 116, 24, 234, 181, 206, 70, 164, 136, 197, 73, 25, 84, 138, 59, 170, 233, 90, 36, 113, 73, 211, 210, 6, 116, 155, 26, 171, 4, 182, 226, 104, 233, 44, 176, 38, 171, 234, 10, 47, 99, 246, 83, 199, 183, 149, 46, 65, 23, 181, 143, 182, 154, 104, 164, 104, 156, 27, 1, 164, 229, 229, 81, 102, 107, 84, 209, 167, 186, 117, 255, 0, 138, 160, 216, 141, 180, 109, 111, 226, 36, 212, 64, 44, 132, 158, 21, 30, 235, 182, 7, 121, 24, 13, 109, 27, 93, 186, 143, 240, 84, 97, 44, 170, 21, 137, 43, 81, 6, 178, 17, 0, 55, 39, 42, 136, 62, 170, 34, 170, 17, 233, 189, 39, 141, 85, 110, 6, 52, 9, 162, 17, 49, 59, 168, 172, 109, 109, 68, 251, 5, 88, 156, 221, 69, 168, 48, 160, 253, 92, 100, 224, 22, 55, 37, 142, 2, 230, 192, 92, 210, 155, 123, 180, 91, 0, 76, 132, 103, 167, 225, 247, 154, 163, 62, 172, 154, 176, 184, 189, 39, 55, 22, 91, 147, 198, 213, 69, 251, 155, 12, 149, 35, 28, 1, 26, 143, 188, 208, 31, 184, 78, 223, 234, 18, 57, 15, 79, 213, 77, 85, 147, 107, 212, 211, 141, 72, 107, 144, 69, 78, 77, 78, 70, 145, 168, 15, 109, 98, 117, 156, 241, 250, 77, 48, 150, 217, 97, 228, 72, 63, 69, 62, 214, 71, 228, 70, 242, 171, 5, 182, 131, 122, 143, 70, 82, 215, 211, 129, 172, 216, 59, 158, 238, 34, 0, 126, 162, 15, 244, 229, 55, 247, 54, 98, 182, 54, 91, 221, 190, 243, 210, 151, 142, 97, 137, 133, 179, 243, 83, 196, 82, 105, 162, 211, 173, 186, 145, 232, 76, 195, 43, 85, 189, 134, 214, 69, 96, 77, 174, 13, 234, 90, 48, 22, 204, 213, 221, 166, 216, 20, 44, 109, 123, 219, 18, 104, 111, 4, 165, 230, 64, 98, 219, 21, 18, 187, 105, 7, 67, 139, 150, 226, 220, 232, 11, 181, 141, 64, 198, 48, 124, 217, 135, 215, 90, 191, 163, 77, 37, 72, 66, 31, 48, 67, 26, 75, 219, 225, 83, 112, 170, 7, 130, 15, 180, 214, 114, 116, 163, 44, 69, 8, 192, 52, 118, 240, 75, 253, 102, 157, 81, 53, 0, 172, 204, 47, 134, 132, 3, 236, 173, 129, 182, 69, 248, 73, 30, 65, 71, 217, 79, 209, 210, 9, 187, 224, 15, 222, 253, 148, 164, 103, 31, 52, 1, 139, 146, 46, 11, 49, 4, 248, 154, 171, 209, 109, 188, 157, 88, 78, 146, 71, 173, 79, 194, 195, 196, 86, 201, 219, 122, 1, 60, 113, 170, 178, 196, 182, 98, 114, 0, 138, 82, 56, 13, 216, 160, 221, 136, 119, 157, 54, 211, 12, 140, 150, 139, 53, 93, 98, 236, 201, 202, 181, 227, 137, 35, 3, 139, 14, 38, 151, 105, 140, 71, 180, 123, 12, 228, 3, 252, 42, 22, 173, 148, 7, 49, 82, 198, 138, 228, 92, 170, 241, 36, 85, 209, 137, 189, 87, 16, 254, 114, 158, 0, 220, 85, 133, 22, 24, 231, 64, 201, 80, 119, 64, 182, 222, 96, 56, 198, 224, 123, 84, 209, 170, 36, 2, 108, 114, 56, 31, 110, 20, 196, 121, 166, 204, 17, 211, 183, 43, 85, 185, 20, 218, 227, 2, 77, 173, 202, 171, 11, 195, 60, 145, 219, 24, 165, 116, 62, 198, 52, 102, 145, 241, 118, 193, 87, 28, 124, 43, 103, 201, 149, 103, 175, 137, 209, 252, 173, 9, 88, 55, 115, 240, 121, 22, 37, 242, 65, 115, 244, 154, 217, 121, 18, 51, 26, 177, 245, 76, 197, 16, 120, 133, 46, 126, 133, 170, 157, 154, 6, 219, 118, 157, 180, 110, 45, 35, 169, 149, 199, 140, 135, 87, 213, 85, 247, 243, 234, 239, 253, 175, 104, 62, 226, 77, 51, 15, 52, 101, 21, 151, 221, 38, 189, 14, 61, 99, 112, 114, 164, 200, 224, 22, 124, 124, 104, 217, 249, 211, 73, 96, 184, 243, 173, 100, 231, 107, 4, 18, 13, 94, 160, 192, 30, 85, 63, 211, 149, 185, 98, 73, 52, 104, 81, 101, 33, 65, 196, 224, 45, 79, 41, 48, 177, 64, 117, 10, 36, 59, 82, 201, 99, 99, 179, 73, 219, 83, 234, 17, 160, 212, 228, 103, 110, 85, 211, 118, 190, 217, 179, 253, 58, 238, 30, 16, 90, 81, 169, 65, 199, 74, 240, 174, 123, 99, 188, 16, 22, 35, 1, 34, 233, 32, 10, 234, 59, 84, 197, 182, 145, 68, 248, 72, 171, 233, 28, 89, 70, 68, 86, 118, 228, 214, 176, 11, 125, 217, 54, 83, 196, 198, 53, 232, 200, 61, 64, 175, 194, 72, 230, 181, 202, 238, 246, 130, 9, 94, 50, 1, 43, 98, 8, 201, 129, 200, 138, 238, 55, 50, 172, 48, 73, 35, 228, 20, 251, 200, 194, 185, 30, 234, 99, 188, 110, 138, 65, 17, 105, 55, 230, 13, 58, 55, 34, 186, 80, 100, 105, 185, 39, 238, 229, 106, 137, 141, 71, 60, 104, 170, 184, 97, 198, 151, 135, 42, 218, 76, 85, 23, 82, 80, 139, 32, 22, 162, 168, 199, 10, 100, 22, 81, 229, 72, 54, 153, 2, 12, 142, 117, 12, 180, 76, 140, 41, 152, 2, 164, 91, 49, 111, 125, 16, 140, 41, 149, 25, 217, 85, 69, 201, 35, 203, 58, 76, 176, 251, 251, 190, 254, 96, 79, 194, 17, 7, 128, 84, 20, 12, 240, 224, 40, 187, 167, 118, 220, 205, 169, 66, 49, 115, 173, 65, 189, 136, 195, 58, 173, 11, 29, 78, 185, 216, 253, 20, 33, 76, 48, 171, 129, 169, 73, 56, 84, 58, 241, 252, 35, 198, 160, 206, 136, 157, 71, 193, 71, 188, 214, 110, 227, 112, 211, 57, 109, 58, 84, 96, 163, 194, 154, 172, 145, 179, 98, 170, 133, 150, 26, 93, 219, 200, 44, 198, 192, 125, 209, 149, 87, 50, 94, 220, 168, 101, 174, 105, 86, 138, 169, 24, 59, 55, 200, 228, 220, 211, 19, 74, 149, 169, 136, 87, 167, 6, 152, 41, 164, 5, 0, 209, 32, 113, 21, 105, 13, 244, 144, 108, 202, 110, 172, 51, 7, 152, 53, 88, 38, 23, 171, 155, 45, 180, 187, 169, 163, 218, 193, 99, 44, 167, 74, 220, 216, 11, 102, 79, 149, 77, 222, 13, 53, 87, 39, 71, 218, 55, 77, 184, 68, 253, 98, 52, 122, 137, 17, 110, 109, 100, 154, 220, 60, 27, 235, 173, 244, 141, 81, 66, 142, 21, 86, 13, 180, 112, 237, 211, 98, 35, 208, 136, 160, 116, 88, 234, 70, 3, 138, 183, 59, 213, 181, 200, 91, 135, 60, 235, 6, 228, 233, 85, 72, 122, 85, 19, 34, 11, 93, 128, 190, 94, 202, 93, 72, 249, 210, 40, 149, 46, 21, 30, 162, 120, 159, 97, 168, 153, 211, 82, 173, 154, 236, 108, 9, 22, 20, 1, 66, 125, 190, 133, 0, 219, 211, 194, 179, 165, 81, 170, 214, 204, 143, 174, 182, 119, 40, 2, 155, 155, 147, 198, 178, 228, 79, 204, 92, 205, 141, 207, 242, 227, 64, 205, 30, 222, 63, 226, 33, 252, 108, 237, 244, 218, 172, 26, 30, 209, 116, 237, 32, 83, 158, 128, 125, 248, 209, 13, 75, 4, 69, 69, 222, 252, 168, 162, 160, 131, 19, 68, 160, 108, 85, 19, 82, 166, 160, 71, 13, 243, 7, 110, 147, 109, 220, 230, 145, 84, 244, 55, 103, 171, 27, 0, 77, 159, 39, 76, 56, 222, 141, 218, 59, 92, 253, 206, 72, 219, 113, 11, 195, 181, 142, 198, 119, 144, 21, 234, 91, 37, 64, 121, 241, 174, 193, 148, 28, 120, 140, 69, 57, 185, 204, 222, 155, 176, 42, 145, 108, 77, 242, 228, 57, 87, 60, 210, 7, 249, 221, 84, 255, 0, 165, 16, 136, 123, 98, 115, 246, 215, 65, 246, 215, 38, 146, 19, 243, 164, 135, 148, 225, 63, 201, 166, 133, 212, 102, 93, 66, 98, 52, 211, 184, 3, 11, 222, 212, 38, 10, 111, 108, 47, 91, 35, 153, 143, 27, 48, 55, 83, 136, 225, 81, 154, 86, 38, 249, 19, 152, 169, 71, 232, 58, 188, 40, 107, 98, 247, 98, 44, 78, 38, 244, 201, 180, 193, 169, 30, 227, 105, 28, 27, 86, 23, 121, 13, 142, 224, 15, 186, 6, 98, 173, 44, 236, 251, 215, 49, 57, 40, 20, 188, 124, 192, 28, 47, 194, 178, 84, 139, 216, 101, 70, 131, 114, 97, 50, 161, 23, 89, 227, 49, 3, 248, 73, 55, 189, 67, 169, 106, 198, 215, 234, 91, 113, 24, 47, 35, 48, 86, 3, 212, 111, 194, 249, 86, 126, 239, 112, 36, 200, 221, 110, 116, 213, 62, 188, 250, 84, 35, 88, 169, 225, 151, 42, 27, 146, 136, 215, 107, 185, 227, 78, 181, 11, 91, 1, 174, 1, 194, 152, 145, 149, 5, 92, 28, 14, 4, 209, 163, 56, 252, 55, 195, 49, 84, 197, 87, 33, 131, 5, 24, 228, 6, 52, 182, 209, 150, 145, 156, 140, 5, 1, 152, 20, 178, 182, 39, 133, 91, 217, 15, 200, 39, 137, 108, 252, 41, 62, 7, 92, 216, 41, 26, 188, 233, 224, 31, 159, 18, 14, 50, 40, 62, 250, 140, 210, 70, 138, 64, 62, 165, 225, 204, 26, 110, 220, 203, 39, 112, 219, 162, 147, 153, 145, 135, 240, 11, 210, 232, 88, 167, 33, 183, 19, 55, 57, 28, 253, 53, 91, 90, 199, 184, 55, 192, 50, 234, 39, 202, 162, 179, 199, 212, 45, 124, 203, 97, 226, 88, 208, 119, 115, 6, 123, 47, 194, 48, 62, 38, 173, 35, 29, 151, 140, 174, 72, 207, 59, 76, 218, 142, 10, 62, 17, 200, 85, 118, 108, 42, 36, 156, 234, 36, 154, 188, 24, 195, 110, 89, 43, 154, 112, 212, 59, 219, 26, 123, 209, 35, 130, 119, 246, 210, 185, 247, 212, 70, 116, 247, 162, 70, 170, 74, 230, 212, 227, 202, 152, 101, 79, 82, 217, 125, 168, 144, 202, 173, 246, 239, 209, 254, 178, 35, 191, 37, 118, 227, 81, 4, 18, 182, 146, 223, 150, 88, 166, 33, 111, 157, 83, 21, 46, 53, 47, 37, 172, 29, 92, 61, 219, 182, 237, 2, 40, 145, 76, 147, 122, 183, 34, 13, 91, 132, 22, 195, 72, 119, 177, 199, 49, 70, 78, 255, 0, 219, 112, 64, 147, 71, 26, 130, 16, 133, 182, 55, 207, 3, 122, 229, 98, 214, 236, 177, 70, 166, 73, 15, 195, 26, 2, 204, 125, 130, 180, 163, 236, 189, 249, 236, 203, 178, 112, 15, 9, 25, 83, 235, 53, 155, 70, 189, 207, 192, 222, 220, 110, 210, 104, 163, 155, 101, 56, 145, 98, 191, 84, 3, 105, 44, 120, 219, 60, 56, 208, 134, 245, 237, 115, 46, 7, 196, 208, 32, 249, 115, 185, 128, 174, 242, 199, 20, 139, 136, 42, 11, 176, 240, 190, 2, 174, 127, 208, 74, 73, 61, 70, 0, 227, 165, 85, 108, 60, 174, 106, 74, 64, 78, 237, 206, 114, 220, 115, 196, 212, 246, 114, 201, 46, 241, 58, 109, 212, 42, 25, 138, 252, 56, 90, 215, 198, 137, 255, 0, 64, 120, 188, 167, 252, 3, 236, 160, 203, 38, 207, 177, 177, 148, 177, 151, 115, 32, 208, 33, 50, 41, 125, 55, 185, 58, 64, 194, 128, 46, 77, 22, 248, 226, 21, 60, 139, 127, 117, 82, 117, 220, 43, 158, 170, 42, 128, 172, 73, 13, 126, 20, 57, 190, 107, 80, 190, 157, 174, 159, 22, 144, 95, 232, 21, 69, 190, 99, 218, 56, 55, 134, 69, 213, 157, 138, 183, 28, 105, 195, 9, 71, 88, 23, 74, 40, 28, 20, 15, 162, 162, 106, 174, 199, 188, 246, 238, 228, 116, 237, 101, 29, 95, 246, 95, 210, 254, 192, 115, 171, 95, 88, 206, 161, 141, 14, 156, 106, 117, 20, 203, 206, 165, 64, 10, 152, 211, 210, 160, 8, 154, 6, 235, 119, 182, 217, 195, 214, 220, 190, 132, 190, 149, 226, 88, 242, 2, 172, 26, 227, 254, 99, 221, 153, 251, 171, 66, 173, 249, 91, 69, 8, 7, 239, 182, 44, 104, 129, 201, 170, 126, 103, 237, 145, 186, 245, 214, 72, 162, 98, 0, 148, 128, 64, 191, 226, 3, 16, 43, 25, 0, 255, 0, 230, 114, 27, 141, 61, 113, 38, 187, 225, 167, 70, 171, 223, 200, 86, 62, 236, 187, 72, 161, 177, 138, 69, 244, 248, 240, 52, 242, 75, 34, 69, 22, 232, 231, 44, 38, 32, 222, 41, 120, 15, 215, 85, 16, 76, 135, 100, 212, 9, 30, 202, 138, 194, 120, 251, 106, 114, 101, 113, 198, 160, 141, 96, 202, 126, 240, 181, 234, 220, 153, 40, 146, 222, 223, 105, 181, 150, 68, 233, 158, 163, 223, 75, 68, 217, 99, 90, 18, 109, 251, 116, 80, 244, 153, 35, 18, 149, 233, 0, 241, 221, 142, 56, 232, 183, 17, 89, 146, 239, 206, 230, 72, 162, 59, 120, 212, 197, 16, 137, 72, 58, 117, 21, 251, 237, 227, 86, 223, 117, 250, 169, 164, 155, 103, 183, 156, 197, 181, 82, 10, 161, 26, 22, 227, 27, 49, 198, 247, 172, 173, 221, 37, 168, 31, 254, 143, 106, 208, 59, 108, 137, 157, 193, 208, 204, 239, 164, 167, 239, 233, 226, 43, 57, 251, 111, 114, 133, 65, 154, 11, 5, 58, 110, 24, 27, 248, 129, 90, 93, 41, 226, 105, 55, 161, 99, 218, 238, 35, 129, 111, 20, 13, 173, 136, 144, 219, 91, 223, 233, 162, 67, 44, 251, 201, 140, 59, 195, 213, 104, 86, 236, 136, 2, 130, 56, 184, 144, 113, 28, 169, 173, 150, 95, 18, 93, 107, 211, 6, 53, 165, 219, 234, 142, 116, 104, 156, 98, 67, 97, 133, 87, 150, 109, 103, 195, 233, 174, 171, 121, 12, 27, 141, 178, 178, 56, 212, 128, 33, 154, 97, 168, 89, 191, 118, 177, 119, 93, 174, 56, 163, 146, 84, 157, 37, 104, 109, 170, 37, 6, 245, 165, 54, 39, 206, 25, 23, 163, 131, 53, 27, 212, 56, 213, 205, 164, 152, 200, 215, 176, 2, 198, 220, 170, 187, 70, 99, 1, 153, 10, 41, 200, 176, 183, 215, 78, 172, 2, 155, 96, 8, 242, 173, 27, 38, 170, 2, 22, 93, 122, 148, 146, 188, 205, 104, 237, 172, 177, 42, 248, 147, 239, 172, 223, 211, 186, 168, 32, 223, 28, 64, 225, 90, 27, 117, 54, 24, 90, 227, 11, 212, 89, 154, 81, 101, 129, 157, 151, 83, 106, 22, 191, 31, 42, 181, 216, 12, 45, 220, 36, 114, 78, 184, 182, 179, 56, 229, 144, 161, 110, 33, 137, 103, 180, 146, 11, 128, 3, 37, 232, 221, 185, 54, 241, 79, 60, 176, 144, 80, 237, 165, 86, 177, 185, 0, 139, 227, 74, 112, 91, 70, 58, 202, 157, 4, 117, 31, 152, 195, 6, 243, 204, 208, 73, 189, 39, 117, 102, 178, 124, 10, 0, 81, 228, 42, 4, 231, 91, 46, 14, 75, 101, 136, 154, 137, 52, 212, 168, 28, 15, 122, 122, 141, 43, 208, 56, 39, 122, 66, 245, 21, 60, 42, 98, 214, 196, 219, 149, 3, 36, 47, 194, 158, 223, 77, 71, 80, 2, 217, 10, 141, 221, 176, 30, 145, 207, 141, 73, 72, 41, 96, 182, 190, 124, 5, 56, 103, 60, 52, 143, 26, 130, 170, 174, 32, 99, 196, 212, 181, 94, 144, 195, 67, 44, 208, 22, 104, 38, 146, 34, 246, 14, 81, 180, 150, 3, 43, 218, 137, 250, 141, 193, 255, 0, 94, 99, 255, 0, 236, 127, 219, 85, 129, 167, 189, 76, 22, 155, 44, 117, 231, 255, 0, 122, 83, 231, 35, 254, 218, 70, 105, 120, 203, 39, 255, 0, 209, 255, 0, 252, 168, 23, 165, 124, 46, 105, 66, 240, 27, 144, 226, 105, 15, 250, 178, 91, 248, 223, 246, 208, 100, 220, 172, 100, 148, 248, 219, 226, 99, 137, 247, 154, 4, 179, 218, 224, 103, 64, 189, 241, 227, 84, 146, 51, 118, 124, 6, 121, 157, 205, 203, 83, 106, 52, 58, 87, 170, 35, 62, 33, 20, 149, 112, 232, 74, 186, 155, 171, 3, 98, 15, 48, 107, 185, 249, 119, 189, 183, 115, 137, 182, 251, 146, 63, 91, 0, 4, 182, 93, 84, 203, 85, 185, 243, 174, 17, 77, 94, 237, 187, 182, 217, 119, 29, 166, 233, 77, 130, 72, 171, 39, 140, 110, 116, 176, 250, 106, 46, 164, 215, 78, 36, 238, 123, 204, 189, 30, 213, 43, 228, 196, 170, 131, 123, 27, 179, 12, 141, 7, 182, 119, 129, 41, 27, 125, 205, 245, 131, 160, 74, 69, 141, 248, 9, 7, 51, 192, 228, 106, 231, 116, 211, 209, 17, 216, 48, 103, 30, 150, 23, 82, 60, 111, 89, 155, 109, 130, 157, 246, 214, 88, 219, 76, 104, 229, 250, 100, 92, 139, 3, 233, 86, 252, 62, 6, 161, 58, 195, 79, 147, 102, 156, 73, 187, 74, 145, 165, 82, 3, 92, 47, 168, 228, 160, 177, 242, 2, 245, 231, 45, 49, 220, 73, 44, 231, 57, 221, 228, 63, 204, 112, 250, 43, 189, 238, 146, 244, 123, 110, 238, 92, 180, 66, 230, 254, 202, 224, 54, 106, 214, 64, 23, 168, 66, 95, 79, 60, 49, 166, 144, 54, 62, 248, 151, 93, 184, 101, 210, 208, 166, 130, 60, 248, 248, 222, 180, 34, 130, 57, 62, 83, 154, 70, 64, 90, 29, 215, 162, 249, 141, 82, 70, 13, 189, 245, 157, 53, 153, 35, 208, 127, 46, 254, 149, 57, 168, 229, 91, 112, 166, 159, 147, 231, 63, 143, 114, 28, 123, 38, 140, 125, 148, 62, 132, 174, 166, 54, 62, 202, 102, 24, 114, 164, 9, 52, 204, 113, 21, 161, 144, 51, 241, 98, 111, 86, 182, 219, 233, 246, 219, 119, 130, 7, 233, 134, 147, 171, 168, 115, 182, 146, 8, 170, 250, 67, 30, 85, 18, 150, 227, 133, 13, 39, 200, 38, 59, 54, 33, 128, 34, 67, 168, 59, 130, 125, 97, 184, 31, 42, 210, 237, 59, 221, 182, 211, 110, 209, 142, 160, 118, 184, 212, 214, 49, 41, 108, 13, 151, 59, 86, 81, 186, 225, 111, 42, 48, 244, 197, 97, 202, 147, 170, 120, 4, 203, 203, 187, 59, 129, 18, 161, 211, 187, 87, 211, 49, 62, 148, 154, 21, 200, 1, 149, 235, 65, 66, 196, 12, 215, 8, 243, 184, 45, 112, 11, 50, 46, 70, 176, 246, 72, 37, 221, 71, 19, 29, 42, 247, 212, 220, 70, 30, 52, 115, 35, 152, 227, 214, 61, 17, 130, 67, 169, 196, 128, 214, 36, 26, 202, 213, 206, 11, 78, 81, 104, 198, 136, 76, 143, 31, 85, 131, 22, 70, 147, 213, 233, 39, 145, 165, 62, 212, 74, 177, 238, 55, 42, 72, 118, 42, 132, 16, 167, 12, 109, 160, 83, 237, 247, 7, 112, 138, 240, 41, 125, 188, 78, 82, 117, 147, 22, 185, 30, 146, 14, 86, 21, 56, 216, 168, 47, 186, 113, 44, 197, 181, 168, 182, 35, 72, 176, 176, 30, 20, 165, 161, 192, 32, 176, 184, 84, 100, 114, 99, 55, 44, 69, 135, 182, 216, 81, 158, 198, 66, 5, 173, 96, 112, 241, 168, 44, 146, 74, 132, 27, 172, 97, 175, 96, 110, 9, 57, 6, 169, 92, 153, 92, 156, 9, 182, 3, 42, 104, 164, 84, 220, 109, 163, 121, 93, 203, 217, 173, 233, 0, 94, 246, 225, 82, 216, 33, 138, 46, 229, 33, 248, 151, 104, 64, 62, 102, 166, 66, 126, 98, 74, 1, 91, 151, 141, 151, 7, 189, 173, 166, 160, 141, 32, 217, 119, 38, 181, 129, 129, 82, 231, 155, 53, 170, 211, 19, 49, 9, 246, 83, 94, 154, 248, 90, 151, 141, 110, 114, 138, 154, 145, 165, 64, 10, 149, 53, 47, 237, 106, 6, 75, 135, 149, 53, 201, 203, 223, 77, 107, 231, 135, 133, 72, 120, 10, 0, 146, 47, 19, 137, 169, 222, 162, 48, 203, 26, 87, 169, 41, 112, 74, 244, 247, 168, 211, 210, 41, 18, 6, 158, 245, 27, 129, 137, 195, 206, 137, 12, 51, 207, 110, 138, 217, 56, 202, 216, 47, 179, 157, 38, 210, 228, 210, 149, 111, 129, 175, 108, 79, 176, 80, 228, 46, 70, 57, 86, 130, 236, 116, 15, 196, 78, 108, 104, 51, 237, 202, 11, 182, 35, 141, 74, 186, 146, 222, 187, 37, 147, 54, 149, 232, 143, 25, 213, 128, 183, 157, 71, 162, 250, 67, 220, 16, 77, 136, 7, 16, 124, 170, 228, 231, 237, 126, 4, 111, 74, 174, 237, 59, 54, 251, 122, 174, 240, 8, 244, 198, 218, 78, 182, 210, 111, 107, 242, 171, 81, 124, 169, 223, 38, 102, 9, 20, 94, 155, 92, 245, 71, 28, 168, 238, 94, 35, 252, 118, 240, 50, 133, 91, 217, 109, 223, 123, 187, 219, 236, 226, 4, 201, 44, 139, 151, 5, 83, 169, 152, 248, 0, 43, 87, 111, 242, 63, 118, 118, 255, 0, 145, 60, 59, 116, 226, 84, 153, 91, 220, 44, 43, 167, 237, 61, 143, 99, 218, 16, 141, 190, 169, 39, 147, 9, 55, 18, 124, 108, 7, 1, 200, 120, 84, 90, 200, 170, 81, 174, 77, 9, 138, 0, 67, 174, 168, 142, 13, 133, 199, 182, 129, 22, 209, 83, 112, 179, 70, 215, 136, 41, 1, 73, 189, 137, 226, 57, 209, 221, 180, 6, 108, 194, 140, 135, 26, 175, 17, 148, 171, 58, 21, 87, 190, 40, 63, 166, 195, 194, 249, 26, 204, 215, 48, 90, 165, 72, 210, 166, 6, 119, 204, 6, 221, 143, 126, 127, 240, 145, 239, 174, 39, 107, 35, 68, 233, 34, 62, 135, 80, 52, 183, 15, 35, 225, 93, 183, 204, 42, 91, 177, 239, 192, 255, 0, 100, 159, 118, 53, 195, 192, 77, 245, 5, 12, 2, 93, 149, 133, 212, 169, 231, 251, 105, 174, 4, 195, 110, 186, 45, 50, 52, 113, 152, 159, 19, 44, 103, 21, 212, 49, 186, 158, 70, 183, 206, 214, 65, 242, 104, 140, 15, 204, 49, 25, 200, 241, 215, 213, 251, 43, 159, 233, 153, 61, 16, 234, 245, 218, 56, 213, 141, 200, 46, 116, 218, 252, 109, 93, 233, 219, 39, 233, 198, 206, 222, 129, 23, 71, 252, 186, 40, 124, 130, 60, 242, 237, 167, 87, 58, 68, 18, 186, 201, 202, 160, 92, 132, 183, 10, 131, 59, 91, 78, 66, 180, 50, 104, 40, 5, 147, 93, 237, 75, 73, 43, 171, 128, 160, 165, 203, 5, 45, 96, 106, 210, 109, 193, 4, 164, 161, 135, 26, 36, 73, 2, 11, 172, 150, 22, 4, 112, 164, 25, 228, 36, 95, 42, 183, 22, 213, 85, 28, 53, 152, 216, 219, 157, 232, 157, 231, 99, 6, 206, 46, 222, 208, 174, 137, 55, 16, 150, 148, 143, 188, 220, 205, 19, 145, 246, 190, 76, 244, 93, 100, 174, 85, 36, 0, 250, 121, 100, 42, 49, 69, 35, 137, 25, 5, 250, 107, 118, 60, 133, 18, 40, 237, 109, 95, 17, 23, 169, 176, 234, 104, 199, 14, 229, 187, 102, 179, 186, 209, 183, 70, 17, 172, 43, 101, 23, 99, 155, 28, 201, 198, 157, 164, 134, 13, 196, 145, 74, 26, 63, 211, 161, 83, 50, 250, 217, 164, 0, 88, 159, 11, 213, 23, 93, 67, 75, 55, 167, 240, 240, 39, 157, 168, 65, 156, 6, 69, 185, 78, 34, 162, 13, 32, 183, 177, 155, 174, 171, 22, 237, 244, 43, 74, 92, 216, 88, 22, 35, 13, 85, 113, 80, 43, 27, 113, 57, 86, 92, 37, 76, 122, 8, 58, 203, 2, 166, 220, 171, 74, 22, 118, 58, 154, 230, 252, 105, 49, 162, 41, 211, 105, 140, 147, 16, 65, 244, 234, 92, 109, 253, 245, 8, 52, 75, 179, 238, 97, 46, 126, 5, 199, 150, 54, 172, 246, 158, 118, 200, 24, 193, 205, 84, 96, 79, 51, 227, 86, 163, 29, 30, 215, 41, 12, 89, 166, 220, 68, 175, 110, 22, 82, 109, 84, 144, 140, 68, 197, 71, 149, 72, 212, 218, 46, 148, 178, 165, 240, 70, 176, 62, 7, 17, 67, 38, 245, 186, 103, 51, 78, 71, 166, 189, 53, 56, 4, 144, 56, 156, 168, 4, 134, 38, 150, 163, 107, 211, 232, 32, 95, 141, 34, 70, 84, 72, 224, 90, 240, 202, 156, 56, 229, 81, 54, 164, 40, 8, 9, 212, 94, 70, 151, 81, 106, 22, 164, 5, 233, 52, 90, 10, 30, 172, 69, 181, 121, 115, 112, 131, 192, 92, 213, 100, 141, 206, 42, 9, 171, 10, 210, 38, 54, 56, 84, 89, 248, 26, 85, 46, 168, 187, 14, 198, 4, 96, 197, 58, 140, 50, 105, 49, 250, 50, 171, 194, 54, 32, 16, 48, 172, 133, 221, 238, 134, 10, 214, 60, 200, 171, 123, 109, 244, 247, 211, 41, 4, 112, 181, 97, 100, 250, 157, 84, 117, 225, 40, 52, 4, 42, 115, 169, 29, 164, 108, 44, 227, 82, 158, 4, 84, 99, 153, 95, 142, 116, 13, 246, 229, 163, 80, 138, 72, 191, 42, 138, 242, 93, 184, 51, 119, 155, 88, 162, 152, 172, 50, 235, 28, 80, 227, 163, 219, 83, 135, 102, 26, 36, 157, 172, 7, 222, 10, 61, 88, 27, 84, 246, 155, 19, 52, 186, 167, 101, 69, 99, 253, 37, 55, 102, 254, 46, 84, 111, 212, 69, 212, 39, 110, 44, 129, 138, 130, 112, 22, 24, 26, 215, 185, 156, 253, 153, 150, 139, 123, 16, 32, 133, 205, 198, 146, 215, 86, 28, 87, 133, 252, 171, 162, 237, 94, 168, 229, 144, 230, 197, 23, 220, 183, 251, 107, 154, 27, 149, 3, 166, 51, 34, 254, 66, 186, 158, 218, 45, 183, 63, 189, 35, 27, 248, 11, 10, 16, 173, 201, 106, 151, 17, 79, 77, 247, 168, 16, 206, 109, 110, 68, 227, 85, 246, 72, 203, 2, 43, 222, 246, 22, 7, 59, 18, 72, 191, 141, 18, 102, 12, 173, 27, 1, 123, 250, 111, 145, 182, 54, 167, 133, 10, 168, 44, 44, 204, 110, 84, 29, 65, 71, 1, 171, 141, 1, 208, 41, 165, 74, 149, 49, 2, 220, 194, 55, 27, 121, 118, 231, 41, 145, 147, 31, 222, 22, 21, 231, 91, 104, 217, 92, 67, 37, 213, 151, 84, 82, 243, 244, 103, 245, 87, 164, 156, 171, 39, 115, 242, 255, 0, 110, 221, 110, 223, 115, 60, 111, 121, 49, 145, 81, 202, 163, 183, 226, 32, 80, 152, 25, 95, 47, 108, 198, 231, 126, 38, 181, 224, 217, 250, 141, 242, 50, 156, 16, 123, 51, 174, 167, 27, 223, 141, 67, 107, 182, 219, 109, 33, 16, 109, 98, 88, 97, 92, 66, 47, 51, 196, 248, 212, 248, 138, 83, 145, 164, 121, 241, 85, 189, 237, 64, 221, 5, 5, 64, 206, 172, 241, 160, 75, 24, 121, 213, 120, 90, 173, 51, 54, 138, 224, 19, 142, 23, 2, 156, 23, 92, 112, 191, 49, 87, 23, 103, 30, 68, 97, 71, 78, 213, 179, 113, 142, 234, 40, 216, 100, 173, 33, 66, 106, 165, 19, 218, 202, 2, 119, 11, 128, 252, 192, 110, 30, 255, 0, 69, 170, 91, 189, 246, 235, 122, 98, 59, 139, 126, 66, 116, 208, 46, 2, 220, 235, 67, 254, 139, 111, 111, 70, 246, 12, 178, 235, 143, 180, 83, 31, 151, 212, 99, 250, 152, 136, 225, 105, 211, 237, 20, 212, 10, 25, 157, 28, 114, 27, 132, 182, 88, 227, 106, 178, 183, 8, 6, 1, 215, 28, 120, 212, 119, 187, 33, 178, 40, 186, 214, 64, 247, 197, 93, 94, 214, 254, 26, 82, 40, 178, 176, 194, 194, 198, 162, 198, 148, 34, 250, 141, 153, 133, 131, 139, 169, 242, 168, 171, 186, 216, 134, 181, 169, 94, 226, 216, 159, 10, 96, 49, 176, 207, 133, 73, 101, 189, 182, 233, 132, 129, 93, 67, 158, 6, 181, 96, 117, 104, 75, 129, 97, 99, 127, 117, 98, 64, 167, 168, 24, 140, 44, 192, 142, 55, 171, 143, 60, 145, 109, 36, 211, 134, 148, 54, 36, 115, 169, 31, 8, 146, 162, 216, 0, 49, 182, 38, 140, 80, 38, 200, 41, 3, 213, 57, 54, 254, 20, 170, 61, 189, 229, 153, 75, 177, 5, 70, 76, 48, 199, 143, 186, 172, 200, 88, 109, 97, 13, 155, 73, 43, 27, 231, 128, 2, 168, 131, 47, 186, 71, 166, 99, 34, 139, 117, 20, 22, 60, 53, 15, 79, 213, 89, 196, 97, 115, 91, 187, 148, 89, 118, 204, 178, 176, 69, 177, 210, 236, 108, 1, 225, 88, 251, 109, 188, 251, 185, 10, 66, 133, 180, 13, 82, 182, 74, 131, 155, 26, 209, 89, 37, 146, 29, 37, 131, 72, 203, 141, 64, 227, 192, 85, 148, 69, 11, 115, 241, 138, 33, 136, 194, 44, 93, 27, 150, 159, 219, 85, 229, 114, 50, 194, 137, 145, 246, 246, 137, 200, 44, 124, 70, 35, 145, 160, 98, 49, 246, 83, 177, 177, 189, 233, 12, 111, 86, 137, 106, 88, 195, 26, 144, 94, 28, 105, 128, 185, 183, 26, 214, 218, 193, 104, 192, 34, 247, 204, 212, 95, 103, 105, 122, 244, 247, 153, 130, 23, 56, 0, 111, 194, 173, 109, 251, 123, 54, 45, 133, 179, 173, 85, 142, 195, 17, 133, 35, 101, 21, 139, 222, 223, 24, 55, 175, 183, 173, 92, 188, 131, 143, 109, 26, 40, 22, 183, 54, 162, 126, 73, 32, 0, 100, 230, 57, 80, 88, 179, 62, 150, 54, 7, 221, 86, 6, 214, 38, 67, 121, 67, 157, 39, 210, 48, 1, 173, 133, 76, 191, 19, 86, 146, 88, 69, 57, 88, 9, 52, 180, 96, 1, 145, 4, 31, 170, 164, 145, 198, 216, 1, 99, 84, 118, 155, 105, 130, 35, 244, 172, 215, 197, 114, 36, 3, 137, 53, 162, 225, 85, 134, 147, 113, 69, 133, 85, 61, 3, 65, 27, 43, 121, 99, 83, 222, 109, 220, 238, 224, 210, 161, 195, 71, 171, 28, 5, 201, 167, 219, 182, 32, 156, 170, 230, 225, 28, 70, 155, 132, 5, 250, 55, 212, 163, 240, 55, 31, 97, 168, 79, 37, 218, 179, 83, 4, 238, 183, 47, 183, 125, 194, 8, 163, 9, 43, 66, 196, 39, 169, 91, 33, 103, 191, 26, 4, 68, 141, 42, 57, 214, 254, 235, 182, 153, 62, 91, 220, 180, 113, 133, 145, 31, 245, 72, 6, 100, 33, 212, 213, 137, 180, 129, 247, 4, 21, 193, 14, 37, 237, 195, 144, 173, 83, 80, 115, 217, 52, 224, 208, 217, 196, 164, 235, 39, 84, 146, 50, 134, 99, 144, 198, 218, 86, 187, 29, 130, 219, 103, 21, 243, 58, 155, 222, 198, 185, 40, 2, 174, 230, 24, 130, 216, 107, 7, 199, 210, 9, 174, 198, 5, 209, 183, 137, 121, 32, 250, 169, 162, 109, 201, 51, 72, 102, 105, 233, 151, 141, 2, 32, 232, 78, 22, 212, 57, 113, 168, 68, 25, 100, 10, 15, 164, 3, 113, 245, 81, 233, 120, 241, 160, 82, 42, 84, 169, 80, 3, 26, 99, 82, 166, 52, 13, 17, 166, 190, 34, 165, 106, 137, 204, 80, 51, 128, 57, 212, 20, 22, 221, 162, 140, 176, 185, 240, 169, 134, 247, 83, 109, 201, 27, 187, 222, 193, 0, 39, 200, 99, 84, 71, 83, 78, 120, 180, 133, 210, 62, 46, 21, 79, 113, 1, 14, 23, 73, 245, 11, 220, 140, 43, 94, 101, 104, 98, 133, 230, 83, 25, 127, 84, 68, 216, 134, 22, 190, 21, 75, 184, 76, 191, 150, 209, 200, 29, 179, 32, 112, 164, 135, 110, 12, 185, 34, 75, 105, 42, 189, 75, 219, 133, 173, 77, 161, 0, 197, 84, 145, 198, 194, 137, 61, 152, 180, 135, 34, 216, 10, 156, 76, 172, 139, 134, 102, 169, 51, 46, 160, 183, 155, 89, 118, 198, 17, 44, 102, 51, 48, 214, 162, 214, 12, 1, 225, 106, 43, 33, 42, 79, 14, 92, 168, 91, 208, 63, 88, 161, 217, 141, 130, 219, 141, 129, 56, 129, 122, 181, 181, 233, 75, 184, 104, 164, 118, 84, 211, 232, 32, 94, 237, 126, 52, 172, 203, 175, 37, 94, 156, 150, 44, 6, 28, 197, 18, 36, 145, 172, 221, 48, 23, 50, 195, 26, 178, 251, 101, 134, 82, 177, 147, 98, 110, 47, 135, 209, 67, 214, 81, 136, 4, 220, 124, 64, 84, 100, 214, 81, 50, 47, 118, 35, 212, 70, 38, 165, 40, 255, 0, 140, 228, 228, 86, 214, 170, 230, 66, 0, 33, 143, 171, 133, 73, 231, 126, 137, 23, 36, 28, 233, 164, 201, 118, 76, 150, 204, 1, 27, 104, 180, 72, 183, 38, 254, 144, 57, 147, 85, 55, 157, 228, 50, 36, 91, 69, 31, 151, 172, 25, 220, 96, 117, 155, 250, 23, 237, 52, 29, 195, 73, 41, 16, 18, 122, 64, 220, 175, 226, 60, 218, 131, 38, 220, 231, 144, 225, 86, 146, 234, 100, 219, 232, 86, 149, 140, 132, 188, 206, 206, 223, 188, 111, 91, 80, 187, 237, 187, 108, 48, 196, 116, 190, 224, 117, 247, 14, 48, 99, 124, 21, 124, 128, 172, 179, 177, 158, 64, 73, 180, 106, 110, 46, 217, 251, 0, 173, 137, 148, 116, 54, 214, 55, 11, 24, 75, 218, 199, 210, 42, 118, 53, 132, 142, 141, 53, 245, 55, 202, 70, 116, 164, 102, 8, 194, 170, 200, 69, 240, 171, 51, 226, 14, 22, 191, 10, 168, 64, 225, 239, 170, 169, 157, 185, 24, 139, 129, 207, 149, 32, 61, 148, 128, 240, 163, 192, 151, 33, 143, 178, 169, 218, 16, 149, 103, 1, 182, 155, 80, 199, 84, 130, 252, 2, 253, 181, 177, 18, 128, 44, 48, 170, 155, 112, 0, 31, 77, 94, 65, 113, 92, 123, 46, 236, 206, 237, 117, 85, 88, 10, 160, 17, 141, 51, 109, 131, 99, 244, 84, 151, 10, 42, 212, 166, 84, 20, 204, 22, 38, 226, 162, 98, 3, 33, 141, 95, 43, 113, 110, 20, 38, 136, 147, 134, 85, 73, 139, 180, 170, 35, 177, 212, 77, 205, 36, 130, 231, 83, 101, 157, 92, 77, 181, 254, 47, 117, 41, 172, 182, 228, 41, 59, 7, 104, 2, 160, 26, 209, 216, 72, 49, 141, 143, 165, 193, 83, 228, 107, 54, 250, 141, 89, 219, 2, 164, 103, 74, 74, 140, 27, 59, 86, 213, 104, 156, 92, 98, 140, 57, 131, 233, 174, 115, 163, 250, 77, 91, 97, 148, 14, 201, 111, 35, 133, 116, 144, 27, 170, 191, 16, 113, 172, 46, 230, 8, 238, 155, 171, 113, 117, 62, 245, 21, 117, 120, 48, 186, 243, 125, 1, 192, 183, 222, 32, 204, 133, 102, 24, 120, 91, 237, 174, 198, 214, 195, 144, 3, 232, 174, 75, 183, 198, 95, 185, 15, 224, 0, 31, 226, 117, 253, 149, 215, 28, 201, 173, 87, 6, 22, 245, 17, 164, 185, 83, 218, 152, 11, 12, 115, 160, 67, 210, 165, 74, 168, 66, 165, 74, 149, 38, 2, 166, 52, 244, 168, 1, 170, 7, 226, 21, 51, 202, 160, 109, 173, 127, 183, 10, 10, 71, 154, 202, 215, 124, 242, 162, 108, 200, 27, 164, 191, 141, 253, 212, 23, 32, 185, 3, 1, 106, 46, 215, 250, 192, 253, 52, 208, 223, 6, 206, 235, 118, 36, 138, 53, 103, 102, 232, 252, 58, 205, 244, 248, 10, 162, 194, 54, 55, 12, 60, 125, 181, 39, 116, 49, 170, 183, 22, 166, 142, 24, 220, 223, 29, 35, 58, 100, 55, 136, 36, 187, 38, 144, 20, 184, 212, 198, 227, 212, 47, 106, 44, 93, 190, 222, 156, 125, 56, 138, 175, 36, 104, 237, 212, 83, 150, 68, 27, 16, 69, 23, 169, 50, 198, 29, 152, 217, 240, 7, 202, 148, 147, 0, 39, 69, 147, 114, 238, 192, 220, 88, 1, 229, 68, 216, 48, 235, 177, 183, 167, 43, 248, 213, 121, 153, 195, 222, 244, 78, 216, 196, 110, 24, 223, 225, 33, 197, 242, 184, 52, 13, 35, 105, 145, 12, 139, 32, 179, 106, 22, 177, 231, 229, 84, 183, 122, 97, 221, 105, 101, 3, 80, 225, 229, 70, 238, 91, 167, 220, 110, 122, 236, 70, 166, 80, 167, 70, 11, 113, 198, 179, 153, 36, 45, 137, 44, 121, 231, 66, 29, 184, 2, 196, 169, 12, 77, 129, 189, 88, 132, 46, 180, 101, 24, 230, 60, 232, 79, 181, 154, 69, 91, 96, 120, 220, 26, 177, 4, 14, 172, 174, 199, 210, 185, 213, 25, 149, 36, 103, 220, 119, 41, 36, 148, 174, 178, 108, 109, 101, 248, 71, 33, 87, 182, 189, 190, 93, 236, 50, 73, 17, 69, 233, 62, 130, 29, 130, 156, 69, 238, 47, 84, 163, 219, 245, 119, 45, 49, 123, 93, 155, 77, 188, 234, 226, 196, 170, 122, 152, 23, 92, 53, 248, 84, 182, 82, 228, 171, 211, 112, 122, 111, 98, 87, 11, 255, 0, 125, 73, 100, 6, 51, 182, 124, 239, 249, 102, 246, 191, 133, 22, 65, 160, 144, 191, 211, 108, 171, 55, 120, 170, 70, 36, 142, 86, 206, 227, 141, 68, 73, 189, 91, 89, 94, 25, 35, 186, 87, 80, 117, 216, 105, 248, 83, 141, 85, 199, 240, 214, 134, 210, 88, 247, 160, 36, 224, 29, 212, 67, 239, 125, 245, 31, 123, 207, 157, 51, 236, 35, 234, 122, 11, 177, 56, 144, 78, 21, 93, 234, 184, 98, 122, 221, 178, 138, 177, 71, 213, 113, 24, 34, 231, 19, 236, 171, 139, 16, 75, 1, 79, 255, 0, 95, 25, 42, 70, 164, 101, 55, 4, 81, 152, 98, 71, 42, 206, 215, 158, 13, 43, 72, 229, 15, 16, 181, 252, 48, 171, 136, 112, 23, 170, 209, 45, 252, 56, 213, 132, 22, 172, 95, 39, 69, 67, 138, 32, 54, 161, 45, 76, 26, 6, 25, 113, 163, 45, 135, 10, 2, 154, 34, 154, 6, 19, 134, 63, 69, 80, 222, 73, 136, 90, 187, 123, 10, 205, 222, 18, 172, 178, 16, 74, 131, 234, 161, 8, 148, 81, 147, 99, 157, 89, 18, 105, 195, 136, 204, 86, 118, 226, 121, 157, 22, 61, 163, 232, 14, 125, 114, 15, 136, 15, 221, 229, 79, 182, 216, 222, 104, 226, 66, 67, 57, 210, 92, 146, 113, 60, 105, 192, 73, 191, 219, 183, 29, 71, 104, 198, 32, 88, 147, 203, 149, 103, 119, 23, 67, 220, 247, 71, 77, 253, 96, 95, 201, 69, 105, 108, 118, 131, 107, 39, 68, 18, 236, 88, 106, 98, 45, 123, 86, 22, 226, 102, 125, 214, 226, 75, 124, 82, 185, 250, 109, 85, 83, 27, 196, 154, 61, 148, 43, 239, 178, 183, 169, 7, 187, 83, 87, 74, 49, 174, 115, 229, 181, 45, 59, 57, 31, 121, 191, 202, 128, 125, 181, 209, 214, 203, 131, 154, 222, 166, 61, 53, 51, 90, 158, 133, 200, 163, 2, 165, 74, 149, 80, 133, 74, 149, 42, 0, 84, 169, 82, 164, 3, 80, 152, 254, 106, 249, 253, 134, 141, 85, 89, 191, 228, 40, 241, 63, 85, 34, 151, 7, 3, 185, 84, 210, 21, 64, 184, 201, 193, 192, 212, 118, 204, 218, 130, 176, 196, 101, 68, 220, 128, 99, 46, 25, 108, 49, 22, 170, 209, 202, 201, 102, 3, 17, 206, 169, 5, 131, 202, 110, 0, 241, 167, 87, 107, 20, 32, 227, 136, 2, 130, 103, 102, 56, 168, 30, 84, 231, 112, 161, 131, 8, 207, 190, 153, 1, 4, 162, 19, 169, 174, 73, 251, 188, 168, 238, 117, 69, 169, 77, 212, 98, 42, 137, 156, 48, 179, 139, 209, 225, 153, 4, 37, 84, 19, 107, 155, 54, 52, 154, 1, 157, 213, 200, 32, 105, 182, 6, 245, 61, 169, 10, 204, 192, 230, 42, 11, 188, 103, 33, 90, 24, 153, 84, 225, 123, 171, 123, 197, 50, 181, 165, 145, 244, 170, 135, 189, 144, 100, 40, 67, 146, 220, 161, 91, 77, 154, 216, 94, 148, 81, 53, 193, 213, 128, 198, 170, 187, 157, 64, 131, 144, 181, 19, 174, 122, 97, 65, 181, 176, 34, 152, 139, 2, 109, 204, 82, 22, 214, 74, 241, 66, 46, 8, 162, 157, 220, 186, 10, 216, 2, 223, 85, 83, 73, 14, 9, 41, 245, 28, 20, 81, 39, 148, 146, 172, 230, 192, 0, 183, 240, 169, 0, 107, 41, 71, 56, 97, 141, 28, 73, 213, 138, 199, 17, 247, 135, 149, 82, 114, 53, 182, 147, 113, 192, 213, 141, 173, 244, 48, 110, 38, 212, 65, 74, 1, 200, 228, 49, 85, 184, 94, 3, 149, 83, 221, 177, 192, 28, 235, 69, 160, 179, 19, 171, 87, 157, 103, 111, 0, 45, 116, 204, 96, 111, 66, 137, 43, 53, 95, 50, 158, 166, 12, 174, 172, 85, 148, 221, 88, 102, 43, 83, 105, 222, 72, 96, 155, 196, 184, 63, 234, 160, 199, 218, 191, 178, 178, 141, 255, 0, 186, 164, 84, 133, 14, 50, 189, 59, 85, 91, 145, 82, 246, 171, 193, 209, 153, 182, 196, 107, 86, 12, 14, 86, 170, 186, 245, 76, 204, 112, 13, 67, 219, 16, 200, 57, 90, 136, 200, 70, 34, 185, 162, 48, 117, 76, 164, 88, 139, 59, 81, 215, 133, 86, 141, 141, 176, 171, 42, 110, 42, 89, 117, 8, 42, 96, 208, 240, 169, 15, 162, 145, 65, 84, 209, 84, 140, 0, 160, 12, 198, 56, 113, 162, 41, 166, 48, 220, 13, 13, 213, 13, 175, 152, 164, 101, 85, 181, 234, 153, 222, 52, 172, 194, 33, 130, 225, 172, 229, 106, 104, 150, 59, 34, 7, 3, 0, 73, 196, 85, 152, 17, 70, 229, 45, 123, 42, 221, 124, 197, 80, 51, 71, 171, 80, 188, 141, 197, 178, 90, 117, 238, 123, 149, 93, 1, 209, 1, 54, 93, 43, 119, 30, 84, 65, 93, 184, 58, 72, 119, 145, 238, 63, 60, 96, 84, 49, 113, 197, 74, 138, 229, 99, 14, 99, 212, 69, 139, 18, 223, 226, 55, 171, 83, 111, 229, 27, 13, 198, 244, 181, 152, 67, 250, 101, 109, 58, 76, 143, 35, 88, 53, 188, 5, 102, 69, 186, 222, 128, 53, 218, 85, 3, 144, 31, 77, 105, 90, 184, 147, 150, 246, 73, 195, 58, 159, 150, 87, 242, 76, 135, 2, 67, 146, 60, 222, 223, 250, 107, 116, 224, 43, 27, 229, 153, 18, 109, 137, 145, 50, 1, 80, 223, 48, 194, 236, 192, 251, 235, 100, 154, 209, 240, 97, 212, 129, 57, 10, 33, 161, 183, 196, 45, 83, 190, 116, 144, 236, 42, 84, 169, 85, 146, 42, 84, 169, 80, 2, 165, 74, 149, 32, 17, 202, 169, 49, 255, 0, 146, 188, 238, 126, 170, 184, 217, 86, 123, 176, 253, 90, 121, 145, 244, 26, 76, 165, 195, 9, 63, 99, 236, 219, 128, 86, 93, 156, 100, 30, 67, 79, 255, 0, 109, 170, 132, 159, 38, 246, 7, 248, 35, 146, 3, 206, 57, 27, 255, 0, 85, 235, 114, 149, 81, 7, 51, 39, 200, 187, 76, 225, 223, 78, 156, 131, 133, 127, 217, 85, 37, 249, 35, 184, 15, 232, 111, 97, 144, 112, 234, 35, 33, 255, 0, 45, 235, 178, 166, 162, 64, 224, 102, 249, 75, 230, 24, 254, 24, 162, 156, 127, 227, 144, 15, 161, 173, 85, 219, 180, 247, 189, 186, 126, 103, 111, 152, 48, 207, 72, 12, 63, 202, 107, 209, 169, 193, 60, 232, 3, 203, 216, 75, 27, 90, 68, 146, 54, 228, 241, 178, 253, 98, 166, 171, 184, 32, 72, 176, 74, 241, 227, 119, 88, 216, 175, 190, 213, 233, 27, 137, 194, 174, 147, 98, 78, 119, 196, 1, 85, 6, 237, 50, 213, 112, 50, 23, 181, 103, 109, 138, 174, 13, 105, 169, 217, 79, 7, 3, 215, 139, 169, 165, 142, 146, 51, 7, 15, 174, 166, 179, 68, 183, 33, 181, 114, 184, 204, 215, 105, 184, 218, 237, 183, 131, 214, 168, 196, 254, 32, 43, 14, 94, 215, 212, 220, 74, 187, 120, 137, 130, 38, 17, 133, 142, 199, 84, 150, 196, 249, 10, 165, 116, 209, 54, 214, 211, 48, 220, 198, 230, 224, 233, 111, 182, 173, 60, 177, 244, 87, 89, 212, 6, 122, 120, 154, 109, 239, 109, 147, 111, 123, 198, 226, 223, 186, 106, 161, 145, 16, 4, 36, 99, 192, 225, 85, 41, 146, 211, 69, 128, 251, 25, 8, 26, 101, 65, 108, 69, 129, 4, 248, 26, 109, 187, 144, 132, 53, 193, 190, 21, 8, 145, 190, 232, 247, 120, 213, 157, 190, 217, 228, 117, 0, 124, 89, 120, 218, 147, 112, 135, 90, 182, 210, 241, 8, 25, 241, 37, 75, 95, 43, 11, 213, 41, 225, 146, 82, 242, 48, 232, 237, 212, 127, 51, 31, 239, 53, 208, 237, 162, 120, 126, 33, 111, 221, 181, 205, 87, 238, 177, 59, 36, 98, 56, 9, 1, 245, 54, 32, 12, 6, 25, 214, 75, 103, 152, 238, 217, 237, 26, 215, 220, 223, 7, 41, 141, 177, 192, 211, 163, 128, 172, 165, 73, 13, 151, 129, 167, 149, 36, 86, 37, 179, 36, 220, 114, 55, 202, 139, 22, 217, 102, 208, 130, 85, 86, 124, 21, 185, 30, 76, 43, 115, 129, 22, 59, 92, 154, 137, 136, 253, 220, 65, 173, 38, 24, 86, 126, 194, 30, 148, 132, 27, 95, 34, 71, 215, 90, 86, 174, 107, 250, 142, 170, 122, 80, 37, 244, 154, 58, 55, 42, 25, 91, 251, 42, 32, 216, 218, 161, 150, 153, 104, 53, 234, 97, 141, 87, 13, 227, 83, 14, 109, 72, 176, 225, 133, 72, 30, 84, 0, 230, 156, 53, 3, 20, 171, 44, 151, 84, 32, 19, 196, 229, 84, 155, 107, 58, 144, 55, 47, 116, 255, 0, 197, 112, 43, 65, 91, 12, 41, 22, 36, 115, 170, 76, 75, 12, 166, 187, 77, 131, 252, 111, 47, 150, 172, 42, 230, 197, 118, 155, 109, 196, 95, 165, 131, 92, 215, 193, 220, 150, 96, 14, 7, 232, 170, 210, 71, 33, 97, 165, 49, 38, 194, 194, 228, 213, 253, 142, 216, 192, 36, 158, 99, 109, 40, 75, 19, 247, 84, 98, 105, 151, 107, 40, 42, 252, 198, 179, 183, 73, 18, 39, 109, 172, 100, 203, 44, 138, 183, 26, 242, 92, 7, 1, 88, 226, 66, 194, 234, 110, 15, 195, 108, 171, 177, 234, 134, 136, 50, 98, 140, 48, 35, 145, 174, 99, 186, 237, 83, 103, 58, 202, 139, 104, 159, 27, 12, 175, 198, 213, 166, 187, 207, 149, 225, 156, 123, 117, 181, 230, 89, 70, 159, 202, 155, 215, 135, 185, 29, 155, 159, 203, 222, 41, 32, 114, 150, 62, 62, 209, 93, 123, 103, 94, 96, 155, 183, 218, 247, 13, 182, 229, 90, 250, 36, 89, 20, 142, 95, 253, 43, 211, 157, 149, 128, 101, 201, 128, 35, 200, 227, 86, 204, 87, 36, 113, 212, 40, 148, 53, 248, 253, 148, 74, 72, 118, 21, 42, 84, 170, 137, 21, 42, 84, 168, 1, 82, 166, 181, 56, 160, 8, 185, 244, 154, 202, 145, 199, 234, 226, 30, 39, 15, 97, 173, 73, 77, 150, 177, 100, 111, 249, 177, 123, 79, 215, 75, 169, 75, 134, 110, 210, 166, 25, 99, 79, 76, 66, 165, 76, 51, 164, 113, 184, 162, 66, 7, 160, 110, 55, 34, 50, 81, 79, 168, 124, 71, 151, 133, 21, 220, 36, 109, 35, 100, 130, 245, 206, 238, 247, 108, 69, 179, 118, 62, 210, 204, 114, 168, 217, 120, 80, 185, 53, 211, 175, 185, 182, 248, 69, 141, 206, 231, 81, 233, 168, 103, 115, 146, 45, 201, 52, 40, 59, 127, 114, 146, 109, 114, 4, 219, 194, 120, 72, 110, 254, 197, 90, 187, 180, 79, 209, 197, 162, 255, 0, 152, 113, 150, 78, 44, 199, 199, 144, 163, 44, 146, 203, 253, 52, 56, 253, 246, 192, 125, 53, 130, 206, 89, 208, 220, 113, 132, 13, 246, 219, 61, 180, 47, 52, 154, 165, 233, 169, 36, 156, 7, 248, 69, 7, 181, 163, 44, 40, 92, 222, 87, 102, 150, 66, 6, 155, 95, 33, 97, 225, 82, 152, 180, 146, 141, 170, 30, 173, 136, 14, 6, 10, 88, 253, 130, 142, 136, 2, 8, 193, 1, 84, 98, 87, 207, 33, 90, 112, 140, 185, 97, 163, 102, 244, 169, 63, 17, 196, 158, 20, 207, 6, 214, 85, 252, 216, 99, 123, 223, 53, 21, 0, 66, 174, 144, 112, 162, 6, 179, 41, 57, 11, 223, 218, 40, 86, 21, 168, 178, 81, 155, 181, 118, 242, 197, 161, 219, 38, 179, 98, 2, 250, 65, 22, 198, 179, 247, 123, 68, 222, 246, 253, 214, 214, 4, 11, 184, 140, 106, 219, 27, 104, 37, 175, 118, 70, 53, 182, 162, 202, 7, 21, 181, 235, 62, 104, 223, 107, 60, 146, 162, 137, 35, 156, 50, 155, 159, 129, 155, 27, 251, 233, 213, 231, 33, 101, 9, 36, 113, 99, 123, 190, 219, 72, 219, 105, 154, 85, 210, 108, 208, 187, 21, 116, 254, 19, 157, 29, 39, 117, 187, 9, 90, 72, 200, 191, 172, 222, 199, 219, 198, 186, 237, 231, 108, 216, 247, 157, 164, 103, 117, 31, 172, 175, 162, 101, 194, 72, 200, 192, 216, 249, 240, 53, 201, 247, 63, 151, 187, 167, 109, 12, 234, 14, 235, 107, 254, 236, 99, 212, 7, 239, 166, 98, 174, 183, 171, 248, 50, 47, 93, 139, 171, 178, 249, 148, 12, 235, 44, 210, 25, 23, 2, 46, 105, 182, 170, 165, 210, 76, 181, 50, 248, 216, 94, 170, 163, 92, 177, 6, 247, 22, 171, 144, 29, 50, 194, 128, 224, 36, 141, 126, 154, 209, 240, 100, 185, 52, 163, 64, 155, 153, 52, 228, 88, 253, 117, 102, 132, 84, 172, 173, 124, 195, 27, 251, 234, 198, 147, 157, 114, 91, 147, 177, 44, 3, 168, 48, 162, 176, 199, 194, 162, 69, 3, 5, 170, 198, 136, 175, 227, 76, 203, 133, 232, 100, 91, 17, 238, 162, 1, 50, 200, 55, 169, 168, 190, 53, 77, 37, 55, 251, 40, 233, 184, 91, 227, 82, 209, 73, 150, 2, 99, 157, 26, 40, 69, 241, 52, 21, 153, 116, 222, 164, 55, 9, 197, 168, 25, 121, 2, 168, 176, 192, 140, 141, 11, 191, 200, 177, 118, 55, 104, 240, 105, 164, 142, 38, 60, 193, 107, 159, 170, 130, 55, 94, 209, 89, 253, 255, 0, 126, 30, 8, 54, 106, 125, 70, 78, 179, 12, 236, 20, 88, 95, 219, 90, 107, 79, 185, 25, 110, 178, 237, 98, 216, 238, 218, 6, 14, 167, 212, 126, 37, 191, 164, 175, 136, 52, 221, 195, 187, 109, 247, 119, 129, 98, 70, 142, 248, 128, 26, 70, 36, 127, 13, 128, 247, 214, 57, 37, 253, 36, 221, 78, 36, 95, 58, 42, 200, 177, 42, 234, 54, 81, 240, 162, 241, 53, 209, 248, 212, 247, 70, 78, 85, 178, 209, 219, 56, 14, 123, 100, 18, 160, 208, 146, 64, 195, 20, 102, 33, 150, 199, 49, 161, 154, 246, 174, 227, 179, 239, 246, 219, 157, 164, 59, 101, 148, 29, 212, 8, 17, 227, 97, 165, 142, 145, 107, 173, 243, 21, 192, 13, 214, 233, 207, 229, 105, 78, 111, 203, 218, 104, 209, 180, 143, 102, 155, 113, 35, 91, 29, 65, 138, 0, 127, 118, 216, 211, 117, 145, 76, 30, 142, 138, 67, 146, 115, 202, 198, 139, 92, 78, 211, 230, 45, 222, 216, 1, 30, 226, 73, 212, 97, 166, 117, 212, 61, 231, 26, 215, 218, 252, 217, 3, 216, 110, 160, 49, 95, 239, 198, 117, 129, 230, 185, 212, 246, 192, 59, 73, 189, 74, 163, 4, 208, 238, 34, 19, 64, 226, 88, 155, 39, 83, 113, 82, 160, 5, 74, 149, 68, 208, 52, 61, 233, 84, 106, 66, 144, 2, 156, 217, 13, 97, 179, 127, 206, 65, 253, 178, 38, 182, 119, 70, 201, 88, 44, 199, 245, 233, 142, 29, 66, 62, 140, 168, 41, 112, 116, 244, 198, 252, 40, 99, 117, 181, 111, 134, 120, 143, 147, 175, 237, 169, 134, 70, 248, 93, 79, 147, 10, 100, 143, 149, 61, 43, 31, 236, 107, 59, 187, 119, 189, 167, 106, 66, 36, 13, 44, 214, 191, 73, 45, 168, 41, 251, 198, 244, 0, 94, 232, 178, 182, 216, 71, 9, 80, 236, 217, 49, 176, 32, 86, 102, 195, 97, 34, 202, 119, 123, 162, 164, 199, 253, 20, 83, 112, 27, 241, 147, 225, 194, 141, 183, 109, 195, 194, 173, 184, 144, 205, 35, 12, 31, 47, 73, 197, 112, 242, 162, 18, 25, 150, 4, 192, 91, 212, 121, 14, 53, 207, 119, 54, 147, 175, 90, 117, 164, 120, 228, 113, 38, 58, 202, 222, 255, 0, 15, 31, 109, 60, 251, 151, 8, 85, 88, 9, 72, 192, 159, 186, 15, 31, 217, 80, 220, 74, 35, 26, 81, 114, 24, 1, 192, 14, 117, 95, 105, 25, 105, 134, 177, 169, 142, 167, 55, 230, 7, 217, 66, 65, 102, 163, 37, 173, 180, 97, 35, 182, 101, 141, 201, 57, 147, 86, 52, 219, 211, 144, 240, 161, 163, 133, 85, 215, 96, 204, 161, 236, 13, 236, 14, 66, 134, 119, 2, 228, 223, 44, 41, 185, 224, 75, 196, 177, 97, 108, 56, 16, 125, 213, 50, 215, 102, 38, 216, 155, 155, 85, 85, 157, 154, 4, 151, 77, 196, 142, 85, 15, 59, 83, 137, 14, 182, 83, 129, 82, 84, 131, 204, 80, 230, 32, 74, 27, 248, 150, 66, 131, 113, 123, 6, 22, 62, 60, 106, 13, 30, 180, 210, 115, 91, 216, 243, 13, 251, 41, 35, 92, 209, 23, 151, 226, 203, 221, 122, 117, 98, 178, 83, 37, 88, 23, 163, 33, 138, 214, 142, 123, 188, 74, 62, 235, 175, 198, 158, 220, 232, 247, 35, 28, 141, 66, 72, 132, 165, 21, 27, 73, 115, 169, 31, 240, 184, 201, 168, 136, 230, 81, 118, 0, 56, 37, 100, 92, 236, 195, 58, 155, 174, 168, 170, 91, 163, 49, 59, 183, 203, 59, 13, 249, 51, 68, 6, 215, 116, 113, 234, 32, 244, 49, 253, 244, 251, 69, 114, 219, 174, 217, 190, 237, 243, 70, 55, 49, 128, 4, 170, 198, 69, 55, 70, 0, 140, 65, 175, 68, 40, 7, 141, 10, 104, 18, 68, 100, 120, 195, 163, 124, 74, 194, 227, 221, 69, 118, 89, 40, 121, 11, 106, 173, 156, 172, 51, 152, 221, 32, 51, 59, 175, 18, 77, 56, 182, 145, 87, 247, 93, 169, 129, 47, 182, 248, 127, 3, 28, 63, 148, 213, 2, 172, 141, 161, 193, 86, 25, 169, 169, 153, 46, 6, 97, 141, 68, 173, 78, 199, 58, 84, 8, 3, 139, 80, 36, 108, 234, 204, 151, 183, 133, 84, 112, 111, 84, 132, 193, 22, 114, 112, 206, 136, 98, 118, 201, 177, 164, 137, 108, 78, 116, 116, 30, 160, 41, 55, 0, 144, 31, 211, 119, 36, 77, 106, 171, 34, 231, 96, 246, 62, 227, 85, 223, 113, 220, 65, 3, 160, 203, 127, 42, 217, 214, 2, 21, 240, 172, 189, 206, 231, 166, 141, 41, 225, 240, 249, 240, 170, 163, 151, 192, 174, 161, 55, 44, 168, 253, 199, 120, 24, 198, 125, 36, 103, 124, 197, 86, 103, 44, 229, 219, 226, 57, 158, 38, 133, 168, 230, 198, 236, 113, 39, 206, 156, 28, 143, 1, 144, 174, 165, 84, 186, 28, 118, 179, 124, 176, 161, 236, 49, 192, 30, 28, 233, 11, 183, 168, 156, 56, 154, 129, 107, 156, 106, 87, 198, 194, 152, 131, 163, 92, 219, 32, 5, 72, 200, 204, 49, 200, 101, 66, 91, 129, 97, 72, 176, 31, 17, 166, 1, 212, 155, 97, 136, 52, 100, 117, 81, 234, 111, 98, 213, 16, 75, 217, 159, 4, 25, 14, 117, 49, 121, 44, 160, 217, 5, 32, 54, 187, 103, 121, 27, 9, 250, 144, 92, 43, 31, 204, 66, 125, 46, 60, 121, 31, 26, 238, 54, 219, 152, 119, 123, 116, 220, 192, 117, 71, 32, 184, 230, 57, 131, 226, 43, 205, 161, 69, 25, 10, 222, 236, 61, 206, 125, 156, 207, 181, 85, 87, 138, 127, 88, 86, 54, 10, 202, 61, 90, 124, 197, 75, 67, 147, 174, 38, 152, 156, 42, 172, 157, 193, 84, 207, 120, 137, 88, 0, 42, 192, 139, 201, 112, 9, 10, 60, 47, 72, 119, 29, 177, 32, 16, 224, 116, 186, 196, 216, 16, 7, 225, 254, 44, 42, 10, 69, 145, 141, 72, 85, 68, 238, 59, 38, 210, 117, 178, 235, 140, 204, 3, 41, 22, 65, 153, 52, 69, 222, 236, 153, 117, 9, 151, 78, 129, 37, 206, 30, 134, 192, 54, 52, 4, 145, 221, 159, 79, 182, 185, 169, 28, 254, 178, 35, 124, 153, 154, 186, 29, 244, 145, 233, 33, 93, 26, 217, 141, 66, 247, 35, 1, 106, 231, 29, 79, 235, 19, 15, 72, 190, 55, 25, 216, 241, 160, 174, 134, 97, 94, 213, 50, 254, 126, 221, 160, 123, 255, 0, 83, 110, 1, 7, 196, 163, 84, 147, 183, 236, 24, 223, 111, 220, 97, 78, 98, 104, 164, 141, 191, 203, 113, 85, 148, 212, 175, 198, 178, 87, 107, 226, 108, 232, 153, 183, 216, 187, 52, 39, 116, 243, 62, 234, 45, 234, 237, 151, 80, 134, 38, 123, 18, 220, 95, 87, 209, 65, 249, 199, 183, 195, 12, 144, 238, 182, 236, 195, 245, 41, 210, 142, 37, 198, 239, 124, 5, 206, 66, 198, 167, 242, 206, 226, 104, 119, 210, 76, 171, 125, 182, 141, 19, 158, 70, 247, 93, 62, 53, 46, 248, 237, 220, 247, 80, 246, 221, 174, 222, 93, 192, 218, 235, 156, 176, 2, 197, 28, 122, 64, 191, 34, 107, 74, 217, 52, 101, 106, 53, 111, 239, 46, 108, 183, 105, 47, 111, 134, 112, 72, 0, 8, 218, 252, 29, 5, 136, 171, 81, 129, 183, 137, 164, 144, 254, 100, 130, 237, 127, 186, 163, 16, 40, 27, 61, 180, 113, 108, 97, 129, 69, 162, 219, 168, 195, 137, 144, 226, 215, 246, 209, 73, 19, 7, 154, 95, 232, 64, 53, 48, 31, 121, 184, 47, 190, 177, 251, 142, 158, 42, 8, 146, 205, 118, 38, 237, 98, 83, 247, 51, 23, 62, 124, 40, 160, 176, 64, 16, 21, 105, 61, 87, 25, 172, 99, 58, 4, 100, 155, 180, 141, 107, 157, 114, 17, 141, 137, 190, 145, 81, 13, 36, 219, 150, 233, 88, 157, 5, 64, 189, 128, 80, 46, 198, 245, 93, 72, 196, 100, 118, 220, 30, 163, 176, 107, 70, 182, 85, 30, 11, 85, 67, 200, 236, 67, 183, 164, 131, 239, 169, 136, 186, 138, 8, 83, 164, 226, 49, 165, 4, 14, 219, 131, 21, 142, 66, 195, 137, 38, 140, 15, 160, 181, 203, 10, 71, 26, 57, 33, 61, 106, 167, 16, 9, 55, 194, 138, 119, 142, 178, 233, 149, 74, 200, 247, 99, 200, 223, 27, 209, 127, 76, 36, 210, 74, 250, 126, 27, 145, 135, 190, 161, 220, 81, 100, 221, 144, 47, 161, 116, 166, 25, 233, 25, 233, 167, 201, 56, 89, 44, 137, 25, 72, 25, 144, 84, 253, 181, 108, 76, 182, 125, 42, 117, 44, 129, 226, 241, 81, 194, 179, 55, 18, 44, 91, 137, 58, 76, 100, 219, 11, 104, 191, 196, 48, 199, 206, 143, 28, 192, 233, 96, 110, 24, 93, 79, 49, 74, 93, 112, 14, 170, 217, 52, 27, 73, 102, 32, 89, 73, 12, 160, 112, 184, 198, 130, 91, 161, 185, 12, 62, 9, 253, 45, 127, 198, 7, 161, 189, 163, 10, 130, 204, 48, 184, 203, 10, 155, 72, 143, 4, 144, 180, 101, 203, 98, 142, 45, 233, 226, 62, 154, 61, 82, 30, 152, 234, 21, 37, 195, 212, 113, 190, 34, 138, 29, 14, 126, 234, 204, 18, 51, 46, 56, 55, 222, 243, 227, 70, 71, 32, 243, 172, 102, 13, 97, 22, 94, 52, 57, 229, 225, 84, 247, 187, 56, 165, 83, 127, 229, 107, 98, 13, 88, 13, 124, 41, 49, 210, 183, 25, 82, 146, 146, 57, 201, 99, 146, 23, 233, 62, 121, 171, 112, 97, 225, 64, 118, 246, 87, 65, 184, 219, 71, 184, 137, 145, 252, 213, 135, 221, 60, 235, 158, 222, 167, 233, 36, 49, 238, 89, 80, 224, 84, 147, 131, 3, 197, 106, 171, 146, 109, 128, 102, 94, 4, 225, 65, 55, 38, 160, 187, 141, 179, 190, 133, 144, 106, 38, 202, 8, 34, 231, 219, 69, 181, 170, 154, 104, 148, 211, 27, 225, 162, 71, 128, 185, 168, 90, 230, 244, 229, 176, 210, 51, 164, 80, 166, 148, 133, 32, 102, 216, 11, 113, 172, 125, 252, 165, 156, 64, 15, 244, 254, 46, 87, 229, 236, 173, 13, 254, 227, 244, 145, 141, 22, 253, 67, 130, 19, 154, 14, 45, 88, 128, 218, 215, 207, 235, 173, 244, 211, 238, 57, 247, 95, 237, 68, 179, 192, 123, 105, 239, 143, 128, 168, 218, 195, 196, 231, 75, 202, 183, 57, 224, 149, 254, 138, 44, 98, 192, 27, 99, 66, 81, 143, 128, 162, 51, 133, 30, 116, 0, 70, 144, 34, 224, 125, 71, 232, 161, 170, 177, 245, 190, 60, 135, 237, 168, 160, 205, 219, 18, 114, 21, 49, 114, 112, 206, 152, 15, 139, 17, 122, 176, 0, 81, 200, 80, 129, 84, 25, 18, 213, 37, 112, 228, 2, 175, 126, 96, 92, 80, 1, 149, 174, 112, 194, 213, 97, 36, 233, 254, 103, 4, 198, 255, 0, 93, 0, 88, 11, 131, 141, 77, 136, 100, 35, 129, 22, 164, 7, 88, 210, 186, 170, 76, 23, 80, 218, 182, 133, 138, 248, 206, 174, 21, 186, 132, 240, 43, 113, 67, 96, 219, 112, 241, 19, 214, 253, 27, 117, 93, 242, 253, 66, 54, 175, 202, 28, 138, 212, 54, 123, 134, 59, 45, 174, 232, 158, 163, 20, 253, 52, 137, 193, 50, 252, 227, 204, 128, 6, 20, 229, 154, 0, 140, 87, 169, 250, 73, 12, 58, 114, 235, 135, 36, 117, 91, 150, 155, 156, 42, 10, 67, 221, 227, 50, 9, 61, 98, 18, 38, 148, 175, 222, 130, 75, 218, 36, 253, 229, 190, 52, 236, 164, 6, 142, 85, 14, 84, 244, 166, 81, 142, 174, 174, 59, 117, 30, 3, 239, 114, 168, 7, 104, 78, 63, 154, 54, 206, 99, 60, 58, 253, 95, 245, 124, 2, 94, 167, 121, 65, 84, 5, 75, 221, 246, 226, 67, 112, 12, 131, 212, 55, 7, 195, 133, 169, 12, 204, 238, 44, 218, 117, 105, 6, 92, 29, 252, 119, 16, 250, 100, 3, 193, 86, 176, 138, 198, 101, 0, 147, 211, 81, 134, 121, 124, 87, 173, 158, 229, 57, 210, 88, 41, 1, 208, 58, 175, 16, 170, 116, 204, 63, 137, 206, 34, 177, 177, 51, 104, 251, 192, 218, 252, 63, 181, 168, 0, 193, 185, 85, 157, 158, 206, 125, 252, 235, 4, 71, 72, 248, 165, 127, 192, 156, 232, 27, 56, 37, 222, 238, 22, 8, 21, 137, 108, 53, 17, 128, 243, 174, 191, 101, 178, 135, 99, 0, 130, 60, 88, 227, 36, 156, 93, 171, 153, 224, 235, 170, 37, 6, 218, 29, 180, 11, 183, 133, 109, 18, 11, 3, 196, 159, 196, 124, 104, 51, 36, 202, 122, 155, 121, 12, 82, 128, 84, 56, 228, 120, 85, 146, 72, 7, 194, 134, 246, 208, 124, 105, 38, 211, 145, 180, 154, 134, 87, 109, 212, 113, 109, 213, 72, 96, 17, 125, 71, 73, 197, 190, 241, 194, 163, 14, 231, 171, 218, 96, 155, 22, 143, 113, 57, 17, 88, 90, 232, 153, 95, 249, 178, 169, 182, 2, 212, 81, 209, 155, 103, 183, 82, 52, 190, 215, 16, 47, 97, 127, 196, 60, 234, 233, 25, 146, 110, 220, 36, 128, 107, 190, 166, 77, 64, 163, 6, 7, 11, 117, 6, 2, 222, 66, 165, 182, 102, 15, 34, 175, 198, 192, 153, 36, 0, 18, 117, 96, 108, 121, 26, 36, 11, 35, 130, 197, 112, 46, 122, 98, 215, 227, 123, 120, 218, 166, 145, 127, 201, 145, 64, 0, 88, 18, 50, 190, 56, 143, 10, 114, 40, 93, 80, 241, 196, 161, 48, 25, 97, 75, 109, 25, 59, 137, 28, 53, 138, 1, 110, 7, 217, 86, 25, 21, 22, 195, 14, 67, 60, 40, 123, 16, 25, 231, 191, 2, 45, 225, 72, 174, 80, 70, 70, 84, 33, 88, 136, 201, 177, 91, 225, 143, 133, 103, 239, 24, 65, 186, 48, 130, 36, 26, 67, 107, 92, 141, 235, 95, 72, 44, 70, 71, 157, 100, 111, 149, 255, 0, 82, 174, 35, 50, 32, 3, 80, 82, 20, 144, 166, 236, 47, 229, 84, 165, 242, 67, 198, 71, 218, 196, 219, 153, 12, 106, 186, 142, 146, 214, 240, 21, 37, 217, 233, 75, 172, 101, 190, 38, 95, 85, 172, 249, 161, 30, 92, 106, 166, 199, 118, 23, 112, 29, 191, 46, 41, 25, 163, 143, 83, 0, 193, 179, 208, 125, 149, 180, 182, 178, 219, 30, 87, 22, 28, 136, 254, 250, 26, 14, 238, 165, 8, 229, 44, 108, 53, 16, 196, 104, 4, 122, 141, 252, 168, 203, 119, 118, 141, 100, 84, 54, 186, 234, 184, 189, 175, 124, 124, 197, 87, 157, 122, 59, 148, 142, 49, 160, 62, 43, 118, 185, 93, 63, 123, 10, 169, 255, 0, 96, 95, 181, 110, 119, 70, 48, 52, 29, 17, 131, 248, 243, 207, 233, 166, 170, 39, 110, 147, 5, 233, 24, 164, 238, 186, 149, 129, 10, 225, 215, 34, 8, 199, 220, 105, 162, 148, 176, 4, 225, 115, 133, 87, 238, 83, 4, 139, 175, 99, 164, 95, 85, 191, 9, 69, 144, 229, 227, 122, 156, 18, 164, 200, 143, 19, 6, 66, 46, 24, 100, 107, 27, 214, 31, 192, 210, 150, 148, 95, 141, 175, 129, 171, 49, 144, 110, 14, 56, 99, 84, 80, 138, 42, 57, 214, 52, 230, 120, 84, 26, 18, 152, 244, 81, 152, 226, 0, 36, 139, 219, 42, 226, 59, 166, 226, 93, 198, 229, 134, 225, 172, 99, 37, 162, 35, 213, 211, 71, 248, 126, 140, 235, 123, 190, 247, 200, 186, 111, 177, 218, 90, 73, 205, 214, 105, 14, 43, 24, 56, 21, 253, 230, 174, 96, 199, 125, 41, 148, 136, 45, 19, 28, 136, 255, 0, 109, 190, 202, 232, 213, 72, 77, 190, 167, 54, 235, 166, 213, 87, 65, 218, 38, 104, 216, 50, 216, 175, 196, 70, 35, 193, 129, 171, 59, 13, 218, 206, 122, 19, 27, 78, 163, 210, 223, 238, 15, 219, 85, 224, 155, 69, 128, 36, 40, 186, 233, 111, 186, 120, 163, 125, 148, 102, 237, 235, 44, 79, 188, 88, 220, 67, 12, 138, 143, 42, 16, 58, 110, 216, 129, 106, 187, 86, 84, 17, 91, 186, 185, 47, 24, 201, 194, 135, 184, 220, 195, 178, 64, 210, 13, 82, 55, 193, 24, 205, 191, 96, 168, 30, 242, 34, 219, 148, 116, 234, 239, 80, 233, 13, 148, 100, 90, 225, 219, 199, 152, 172, 150, 234, 238, 93, 166, 145, 139, 23, 62, 169, 143, 212, 162, 162, 154, 156, 249, 184, 52, 190, 229, 30, 94, 89, 6, 50, 238, 231, 105, 28, 221, 206, 44, 120, 40, 228, 42, 12, 170, 26, 227, 221, 227, 70, 147, 74, 129, 18, 12, 6, 126, 53, 46, 138, 180, 122, 126, 22, 24, 131, 227, 93, 41, 66, 57, 95, 37, 95, 10, 66, 244, 141, 239, 164, 139, 50, 231, 78, 51, 189, 0, 201, 41, 225, 198, 152, 122, 141, 206, 67, 42, 102, 38, 216, 84, 148, 16, 47, 144, 20, 192, 34, 130, 199, 237, 52, 225, 149, 112, 90, 11, 200, 215, 176, 198, 164, 168, 115, 144, 219, 194, 128, 10, 186, 156, 242, 241, 163, 41, 210, 44, 180, 5, 112, 77, 128, 176, 163, 96, 56, 208, 4, 194, 243, 162, 18, 66, 140, 47, 142, 52, 61, 98, 164, 13, 252, 168, 25, 173, 181, 222, 203, 183, 219, 244, 1, 67, 27, 222, 234, 249, 227, 226, 40, 237, 220, 183, 12, 117, 233, 142, 250, 116, 100, 77, 215, 223, 89, 201, 164, 169, 191, 11, 98, 124, 169, 213, 118, 229, 148, 60, 162, 48, 79, 169, 236, 91, 72, 231, 164, 87, 14, 218, 237, 239, 125, 174, 208, 118, 107, 182, 174, 197, 221, 18, 104, 141, 244, 229, 74, 186, 163, 33, 82, 132, 88, 169, 210, 120, 2, 40, 135, 126, 142, 172, 146, 70, 234, 206, 35, 93, 72, 70, 2, 35, 133, 175, 207, 141, 82, 233, 246, 115, 164, 109, 123, 196, 125, 75, 122, 214, 101, 104, 214, 255, 0, 186, 192, 91, 223, 87, 191, 248, 255, 0, 119, 85, 18, 70, 82, 117, 97, 169, 76, 114, 2, 24, 30, 87, 206, 161, 47, 113, 94, 173, 148, 223, 183, 183, 129, 87, 118, 155, 93, 203, 179, 179, 74, 186, 220, 201, 164, 105, 22, 212, 45, 166, 252, 170, 159, 253, 102, 199, 85, 245, 206, 45, 247, 117, 41, 191, 243, 91, 10, 179, 36, 123, 136, 93, 162, 148, 20, 149, 126, 36, 113, 98, 40, 127, 153, 204, 121, 210, 252, 187, 103, 146, 191, 22, 191, 3, 119, 182, 118, 244, 237, 240, 105, 176, 235, 200, 1, 148, 140, 135, 238, 138, 181, 124, 239, 76, 77, 205, 48, 54, 207, 17, 85, 51, 145, 44, 14, 77, 238, 163, 219, 64, 102, 198, 220, 5, 17, 206, 124, 232, 12, 120, 211, 64, 193, 185, 206, 212, 125, 164, 27, 109, 220, 49, 232, 221, 32, 145, 110, 25, 5, 139, 15, 99, 90, 170, 202, 192, 2, 107, 40, 162, 146, 46, 1, 167, 221, 6, 250, 61, 175, 230, 79, 205, 219, 12, 235, 161, 237, 253, 4, 43, 28, 142, 117, 29, 69, 136, 194, 254, 22, 167, 77, 181, 156, 187, 62, 162, 192, 41, 56, 131, 96, 111, 92, 146, 110, 55, 80, 97, 4, 242, 198, 60, 28, 219, 220, 106, 212, 93, 243, 186, 198, 70, 169, 245, 175, 254, 68, 86, 250, 169, 171, 215, 170, 46, 223, 249, 187, 151, 14, 182, 254, 195, 168, 125, 188, 110, 49, 98, 190, 84, 29, 190, 209, 54, 173, 41, 89, 26, 78, 169, 13, 102, 0, 90, 195, 133, 171, 37, 62, 99, 222, 253, 248, 225, 113, 228, 84, 253, 116, 237, 243, 51, 134, 245, 237, 20, 142, 106, 228, 125, 98, 159, 125, 12, 191, 233, 123, 153, 244, 79, 201, 155, 68, 225, 108, 235, 51, 125, 219, 119, 211, 76, 100, 219, 60, 93, 51, 160, 168, 118, 101, 117, 100, 55, 57, 96, 65, 161, 39, 204, 219, 102, 248, 246, 210, 47, 147, 41, 162, 15, 152, 187, 113, 181, 210, 101, 254, 80, 126, 218, 21, 170, 186, 138, 222, 211, 127, 93, 118, 43, 73, 217, 251, 145, 144, 202, 145, 68, 28, 223, 21, 117, 227, 252, 66, 181, 226, 89, 17, 20, 52, 100, 49, 182, 187, 27, 251, 48, 170, 95, 247, 189, 180, 253, 249, 1, 228, 80, 212, 135, 123, 237, 135, 253, 102, 255, 0, 3, 83, 119, 79, 170, 33, 123, 109, 171, 253, 187, 254, 131, 119, 8, 156, 70, 179, 199, 17, 110, 153, 25, 129, 112, 14, 110, 60, 107, 159, 112, 186, 37, 143, 80, 8, 91, 225, 99, 102, 2, 252, 185, 215, 70, 123, 207, 106, 181, 154, 113, 110, 32, 169, 250, 136, 161, 62, 251, 229, 247, 95, 87, 73, 239, 157, 226, 191, 217, 77, 93, 46, 164, 91, 219, 109, 110, 85, 45, 250, 24, 246, 85, 219, 110, 86, 229, 175, 25, 125, 77, 123, 157, 11, 107, 213, 46, 215, 189, 253, 27, 169, 98, 127, 77, 37, 186, 163, 61, 13, 111, 140, 125, 181, 127, 184, 207, 217, 206, 207, 114, 187, 1, 39, 84, 198, 194, 192, 17, 24, 4, 139, 252, 89, 86, 10, 56, 83, 110, 7, 58, 186, 165, 122, 190, 166, 59, 21, 245, 93, 119, 39, 87, 204, 29, 166, 181, 28, 71, 59, 240, 183, 58, 193, 239, 93, 252, 148, 109, 191, 111, 55, 81, 132, 251, 148, 251, 191, 186, 159, 182, 178, 183, 61, 195, 116, 241, 13, 151, 80, 254, 154, 47, 73, 182, 12, 227, 48, 24, 242, 25, 80, 134, 24, 175, 164, 129, 96, 127, 183, 10, 84, 210, 150, 94, 69, 125, 206, 202, 43, 130, 81, 56, 2, 203, 149, 17, 244, 148, 37, 178, 227, 122, 169, 169, 99, 123, 12, 21, 133, 212, 103, 99, 197, 125, 245, 211, 246, 78, 198, 202, 203, 188, 223, 174, 56, 24, 96, 56, 133, 253, 231, 230, 106, 239, 117, 85, 44, 138, 81, 221, 194, 48, 186, 19, 74, 26, 67, 183, 153, 164, 176, 0, 133, 244, 200, 188, 222, 252, 133, 27, 109, 182, 238, 83, 43, 69, 26, 149, 133, 244, 146, 36, 12, 22, 234, 112, 54, 184, 189, 171, 187, 64, 132, 98, 49, 250, 40, 138, 139, 124, 0, 191, 59, 87, 63, 231, 111, 132, 116, 126, 5, 226, 121, 230, 239, 99, 62, 210, 93, 27, 227, 168, 156, 81, 70, 10, 71, 58, 19, 158, 36, 91, 144, 225, 93, 255, 0, 115, 237, 144, 119, 29, 185, 134, 107, 6, 31, 211, 144, 102, 135, 246, 87, 9, 191, 218, 110, 118, 59, 150, 218, 110, 87, 76, 131, 224, 97, 147, 131, 145, 6, 182, 215, 177, 91, 158, 76, 118, 107, 117, 115, 208, 12, 107, 119, 196, 96, 13, 253, 181, 55, 194, 246, 54, 38, 166, 171, 211, 64, 131, 249, 142, 119, 52, 54, 36, 159, 10, 216, 197, 160, 83, 69, 168, 107, 24, 176, 24, 248, 213, 112, 106, 227, 53, 129, 55, 225, 198, 169, 19, 133, 184, 154, 2, 7, 92, 91, 81, 202, 244, 236, 196, 96, 41, 19, 164, 83, 40, 189, 216, 229, 194, 129, 162, 74, 52, 226, 78, 38, 164, 20, 185, 181, 50, 130, 198, 227, 1, 196, 154, 153, 32, 122, 87, 42, 0, 114, 234, 163, 72, 25, 83, 170, 150, 56, 156, 121, 84, 64, 198, 138, 139, 171, 225, 225, 151, 42, 96, 77, 69, 188, 69, 18, 49, 111, 81, 225, 194, 161, 116, 94, 58, 155, 194, 158, 252, 232, 17, 41, 36, 101, 129, 142, 35, 212, 190, 88, 213, 105, 25, 229, 58, 21, 189, 31, 124, 142, 62, 20, 109, 197, 255, 0, 73, 32, 230, 84, 15, 59, 213, 120, 253, 24, 12, 190, 218, 150, 52, 22, 61, 134, 208, 169, 215, 170, 231, 145, 202, 186, 95, 150, 187, 142, 227, 183, 197, 46, 210, 253, 125, 170, 217, 226, 50, 122, 76, 108, 115, 77, 88, 224, 213, 204, 205, 63, 73, 112, 248, 200, 244, 143, 182, 133, 24, 186, 226, 73, 190, 38, 228, 218, 245, 23, 112, 164, 189, 117, 86, 112, 206, 151, 185, 74, 187, 141, 252, 219, 185, 119, 17, 67, 213, 211, 104, 245, 107, 101, 0, 91, 60, 5, 84, 235, 108, 111, 255, 0, 189, 23, 203, 224, 194, 177, 244, 168, 23, 0, 83, 215, 63, 106, 158, 227, 170, 113, 219, 244, 61, 2, 252, 105, 94, 154, 255, 0, 222, 41, 156, 219, 42, 132, 89, 9, 26, 171, 185, 169, 72, 248, 231, 64, 119, 206, 244, 201, 96, 55, 14, 108, 71, 10, 170, 49, 162, 206, 223, 178, 131, 74, 199, 165, 236, 61, 22, 253, 194, 32, 84, 70, 38, 156, 138, 73, 157, 102, 207, 73, 112, 72, 229, 106, 19, 28, 104, 212, 39, 24, 208, 21, 22, 144, 109, 122, 79, 97, 149, 71, 81, 166, 56, 208, 90, 78, 71, 165, 113, 72, 83, 144, 40, 40, 86, 190, 60, 170, 106, 129, 149, 11, 131, 164, 146, 1, 23, 224, 108, 114, 167, 178, 42, 37, 201, 44, 234, 30, 192, 11, 0, 111, 134, 45, 225, 90, 59, 61, 137, 155, 111, 12, 162, 69, 84, 196, 170, 179, 144, 113, 55, 245, 42, 85, 86, 178, 114, 239, 247, 21, 165, 103, 57, 112, 83, 223, 236, 211, 109, 176, 222, 74, 160, 233, 233, 42, 144, 192, 222, 236, 195, 141, 98, 202, 184, 92, 103, 157, 171, 95, 230, 1, 60, 91, 125, 15, 41, 149, 100, 35, 31, 86, 144, 117, 131, 96, 8, 85, 250, 43, 32, 155, 231, 199, 149, 117, 233, 81, 87, 243, 62, 119, 223, 93, 219, 106, 109, 207, 148, 170, 214, 7, 80, 196, 28, 199, 159, 58, 146, 178, 160, 58, 143, 164, 11, 134, 240, 229, 231, 82, 117, 194, 245, 107, 179, 109, 246, 251, 158, 224, 187, 125, 192, 13, 27, 35, 20, 83, 197, 215, 28, 125, 149, 118, 112, 155, 240, 57, 106, 165, 193, 169, 216, 187, 74, 5, 93, 254, 224, 7, 145, 192, 104, 148, 226, 17, 78, 35, 219, 93, 16, 185, 24, 212, 34, 141, 98, 141, 85, 70, 0, 88, 84, 212, 215, 21, 236, 236, 229, 157, 212, 170, 170, 132, 77, 8, 24, 138, 58, 190, 60, 252, 40, 10, 64, 169, 6, 55, 195, 1, 80, 89, 103, 86, 30, 172, 73, 229, 84, 251, 151, 107, 131, 184, 195, 211, 155, 210, 203, 140, 82, 129, 118, 70, 253, 149, 97, 92, 15, 26, 42, 177, 28, 106, 147, 135, 36, 181, 136, 60, 255, 0, 127, 180, 220, 236, 39, 253, 54, 225, 52, 146, 61, 47, 247, 36, 28, 208, 213, 51, 112, 77, 135, 149, 122, 46, 243, 97, 179, 222, 192, 118, 251, 148, 18, 35, 103, 124, 193, 252, 74, 120, 26, 226, 59, 215, 101, 221, 118, 171, 186, 150, 159, 102, 112, 19, 12, 215, 194, 65, 194, 186, 245, 237, 79, 15, 147, 147, 102, 166, 178, 184, 50, 167, 123, 155, 113, 56, 154, 2, 226, 247, 224, 185, 121, 209, 100, 83, 211, 89, 109, 113, 198, 132, 7, 167, 12, 75, 86, 198, 72, 102, 37, 155, 72, 207, 141, 21, 84, 40, 5, 176, 28, 170, 42, 58, 121, 141, 76, 115, 52, 69, 142, 70, 55, 34, 195, 153, 194, 128, 24, 177, 111, 74, 250, 87, 144, 169, 162, 51, 96, 162, 254, 38, 166, 136, 131, 247, 136, 246, 10, 33, 36, 1, 246, 80, 3, 8, 208, 98, 113, 60, 184, 83, 52, 132, 224, 7, 134, 28, 42, 75, 165, 253, 13, 233, 60, 234, 99, 111, 227, 143, 42, 96, 13, 17, 152, 220, 81, 108, 44, 23, 222, 42, 65, 116, 248, 82, 177, 213, 115, 72, 76, 14, 228, 232, 218, 231, 137, 112, 8, 240, 206, 171, 106, 0, 106, 57, 12, 104, 251, 226, 116, 195, 24, 226, 89, 207, 179, 1, 84, 165, 109, 71, 72, 200, 82, 99, 67, 51, 23, 12, 231, 54, 63, 69, 88, 131, 224, 199, 217, 85, 219, 5, 183, 10, 60, 71, 210, 111, 89, 236, 224, 215, 87, 169, 133, 34, 161, 247, 170, 90, 136, 30, 117, 11, 227, 149, 100, 110, 122, 1, 52, 57, 36, 244, 145, 78, 237, 110, 53, 90, 71, 57, 86, 104, 177, 153, 175, 85, 229, 124, 40, 140, 246, 170, 178, 181, 233, 162, 88, 41, 24, 22, 3, 198, 144, 54, 55, 161, 95, 84, 192, 142, 25, 209, 13, 77, 143, 87, 216, 47, 225, 191, 141, 216, 139, 94, 153, 115, 166, 167, 76, 235, 54, 122, 29, 9, 208, 222, 137, 66, 122, 16, 87, 146, 20, 176, 164, 49, 169, 132, 39, 33, 65, 164, 199, 36, 42, 118, 44, 183, 206, 213, 18, 182, 162, 39, 193, 64, 167, 24, 44, 46, 221, 29, 246, 233, 34, 21, 140, 198, 129, 228, 215, 192, 139, 223, 64, 198, 180, 122, 144, 64, 177, 237, 83, 119, 40, 91, 233, 137, 6, 23, 229, 166, 244, 182, 219, 184, 98, 218, 196, 159, 169, 8, 85, 64, 32, 27, 145, 225, 98, 62, 218, 22, 227, 119, 176, 145, 131, 190, 229, 164, 154, 61, 70, 23, 42, 14, 155, 11, 223, 35, 91, 40, 92, 30, 77, 237, 123, 218, 44, 159, 109, 94, 12, 206, 253, 212, 88, 15, 81, 153, 131, 206, 171, 22, 176, 117, 0, 160, 177, 212, 77, 99, 35, 103, 142, 53, 165, 222, 75, 54, 219, 104, 204, 204, 236, 196, 179, 51, 96, 24, 148, 7, 82, 249, 214, 82, 28, 109, 93, 26, 189, 7, 143, 239, 63, 156, 254, 9, 5, 56, 230, 61, 180, 53, 121, 96, 153, 39, 131, 9, 33, 96, 234, 124, 87, 135, 182, 166, 185, 218, 145, 203, 17, 141, 91, 82, 96, 156, 29, 190, 211, 117, 22, 239, 109, 30, 230, 47, 233, 202, 46, 7, 35, 197, 125, 134, 136, 110, 15, 129, 174, 103, 229, 205, 233, 219, 238, 78, 194, 86, 252, 173, 199, 170, 34, 126, 236, 188, 87, 249, 133, 116, 217, 143, 17, 92, 91, 41, 219, 102, 142, 237, 119, 238, 170, 100, 245, 97, 78, 26, 227, 10, 136, 196, 115, 21, 32, 110, 109, 202, 179, 52, 38, 13, 173, 69, 215, 135, 209, 64, 7, 213, 110, 20, 145, 238, 73, 229, 64, 65, 100, 27, 120, 154, 147, 34, 184, 42, 64, 55, 22, 96, 69, 193, 28, 65, 6, 128, 175, 114, 121, 81, 67, 27, 142, 84, 211, 19, 71, 53, 222, 126, 82, 87, 215, 55, 107, 244, 92, 29, 123, 94, 23, 60, 99, 191, 213, 92, 139, 67, 46, 217, 138, 78, 133, 25, 77, 142, 161, 107, 30, 85, 234, 197, 139, 96, 49, 21, 71, 186, 246, 109, 159, 114, 70, 19, 13, 51, 91, 9, 215, 226, 242, 97, 247, 133, 116, 83, 107, 88, 121, 70, 23, 210, 158, 86, 25, 231, 7, 116, 227, 5, 192, 142, 32, 99, 80, 214, 231, 22, 185, 60, 43, 75, 185, 246, 61, 207, 106, 151, 243, 147, 242, 88, 254, 92, 203, 234, 141, 189, 191, 119, 200, 213, 68, 41, 123, 219, 30, 85, 208, 154, 106, 81, 204, 234, 211, 135, 130, 43, 168, 142, 94, 53, 102, 50, 172, 186, 78, 60, 141, 6, 234, 70, 62, 202, 152, 210, 62, 3, 136, 21, 72, 65, 26, 50, 15, 133, 78, 60, 5, 141, 52, 114, 48, 192, 227, 68, 212, 167, 33, 64, 8, 99, 192, 27, 211, 91, 1, 115, 83, 91, 100, 70, 28, 233, 48, 211, 108, 111, 200, 208, 34, 135, 114, 107, 77, 24, 202, 209, 143, 164, 154, 164, 163, 137, 21, 103, 185, 155, 239, 24, 95, 5, 10, 7, 186, 171, 128, 105, 49, 142, 247, 210, 40, 241, 45, 214, 244, 9, 50, 20, 120, 111, 160, 145, 149, 243, 172, 246, 112, 107, 171, 146, 76, 167, 131, 84, 108, 108, 113, 198, 164, 196, 219, 17, 149, 68, 91, 73, 63, 69, 101, 208, 216, 237, 157, 199, 58, 11, 56, 161, 188, 151, 241, 52, 54, 112, 5, 68, 22, 216, 242, 56, 38, 171, 74, 246, 23, 190, 20, 236, 215, 52, 9, 26, 228, 47, 10, 164, 137, 145, 226, 224, 78, 109, 115, 236, 20, 108, 56, 208, 131, 13, 64, 14, 2, 137, 129, 23, 189, 103, 110, 79, 95, 216, 47, 225, 47, 220, 198, 36, 112, 166, 92, 233, 200, 164, 153, 214, 108, 239, 232, 72, 229, 65, 106, 49, 202, 130, 212, 14, 162, 6, 213, 45, 102, 161, 74, 130, 154, 17, 169, 171, 16, 44, 42, 35, 58, 118, 182, 39, 195, 26, 7, 24, 45, 195, 219, 183, 155, 157, 191, 234, 35, 91, 131, 253, 52, 200, 178, 131, 98, 215, 200, 10, 58, 118, 205, 212, 81, 131, 213, 88, 228, 58, 132, 130, 202, 116, 18, 48, 1, 155, 151, 26, 158, 211, 123, 188, 234, 69, 181, 138, 205, 34, 32, 81, 26, 234, 210, 66, 175, 176, 94, 213, 103, 116, 221, 222, 68, 84, 46, 187, 114, 166, 229, 172, 14, 24, 243, 45, 141, 106, 171, 88, 148, 121, 91, 55, 239, 118, 236, 183, 101, 107, 51, 244, 48, 187, 248, 10, 219, 68, 189, 239, 173, 136, 91, 216, 16, 21, 112, 189, 100, 50, 155, 220, 140, 57, 214, 159, 123, 134, 104, 247, 80, 36, 179, 52, 237, 210, 102, 46, 199, 28, 91, 33, 89, 236, 158, 146, 45, 126, 70, 186, 181, 250, 17, 225, 251, 156, 238, 183, 204, 88, 145, 114, 63, 109, 47, 11, 97, 206, 152, 19, 82, 0, 240, 202, 172, 196, 98, 133, 178, 98, 172, 8, 42, 195, 129, 25, 26, 235, 251, 94, 248, 111, 182, 171, 49, 194, 101, 244, 76, 163, 131, 142, 63, 205, 157, 114, 161, 1, 56, 123, 124, 106, 223, 107, 222, 126, 139, 122, 28, 255, 0, 237, 230, 180, 115, 248, 126, 7, 254, 83, 89, 109, 167, 117, 126, 40, 215, 77, 251, 94, 120, 103, 84, 183, 82, 121, 26, 144, 54, 184, 231, 77, 204, 53, 43, 223, 217, 92, 103, 113, 48, 108, 105, 134, 30, 218, 89, 210, 24, 138, 64, 74, 246, 162, 94, 202, 40, 66, 252, 106, 64, 248, 208, 128, 50, 185, 4, 209, 53, 13, 30, 38, 171, 134, 169, 171, 97, 141, 57, 20, 19, 145, 82, 88, 204, 114, 32, 146, 54, 193, 145, 177, 83, 231, 92, 231, 115, 249, 73, 92, 180, 155, 43, 177, 24, 244, 24, 216, 143, 224, 110, 35, 192, 215, 70, 167, 27, 113, 167, 57, 227, 198, 174, 183, 117, 202, 38, 212, 86, 195, 71, 156, 182, 209, 224, 118, 71, 66, 10, 27, 48, 32, 234, 95, 53, 206, 158, 214, 55, 176, 196, 114, 174, 247, 121, 219, 246, 155, 213, 180, 234, 67, 143, 134, 101, 194, 69, 242, 60, 71, 129, 172, 103, 249, 94, 0, 116, 182, 238, 80, 9, 244, 184, 69, 247, 87, 69, 119, 215, 238, 193, 207, 109, 15, 237, 201, 206, 249, 145, 135, 133, 74, 216, 27, 1, 91, 210, 252, 163, 185, 181, 246, 251, 212, 147, 247, 101, 66, 159, 74, 147, 89, 219, 190, 207, 220, 182, 67, 86, 227, 110, 221, 49, 156, 177, 126, 108, 126, 221, 56, 143, 117, 104, 182, 85, 240, 204, 157, 44, 185, 69, 64, 75, 88, 102, 15, 44, 13, 32, 45, 97, 203, 157, 62, 149, 32, 20, 32, 163, 113, 20, 235, 234, 101, 70, 55, 56, 88, 243, 170, 36, 201, 223, 99, 190, 155, 158, 170, 8, 24, 90, 167, 184, 58, 183, 83, 49, 207, 91, 99, 237, 168, 94, 144, 9, 254, 17, 106, 214, 237, 221, 135, 188, 111, 54, 95, 171, 217, 192, 37, 133, 217, 149, 125, 106, 173, 117, 192, 224, 213, 146, 249, 1, 194, 180, 54, 61, 251, 188, 118, 216, 186, 59, 61, 201, 143, 110, 24, 145, 17, 85, 101, 185, 207, 226, 20, 172, 147, 228, 170, 182, 184, 37, 187, 237, 29, 231, 105, 27, 75, 185, 217, 203, 28, 106, 61, 79, 109, 74, 7, 50, 86, 245, 87, 238, 120, 90, 245, 161, 191, 249, 147, 188, 247, 29, 159, 233, 119, 47, 31, 69, 152, 51, 232, 93, 12, 214, 200, 53, 184, 85, 11, 13, 54, 225, 106, 206, 201, 74, 72, 218, 174, 221, 173, 191, 161, 209, 179, 95, 58, 19, 181, 65, 158, 220, 112, 161, 180, 131, 59, 214, 105, 26, 54, 72, 181, 64, 158, 60, 106, 37, 189, 180, 235, 30, 168, 196, 164, 250, 91, 225, 183, 26, 111, 8, 116, 171, 179, 132, 60, 109, 121, 8, 207, 210, 77, 25, 111, 108, 114, 20, 29, 184, 103, 221, 132, 81, 114, 202, 196, 142, 118, 23, 171, 77, 11, 36, 101, 239, 120, 197, 174, 78, 24, 154, 202, 201, 242, 122, 190, 207, 110, 186, 213, 209, 217, 39, 61, 65, 147, 78, 156, 232, 173, 25, 210, 216, 98, 5, 13, 62, 27, 214, 108, 239, 77, 53, 129, 54, 84, 35, 157, 21, 242, 160, 156, 232, 46, 162, 165, 83, 85, 22, 167, 96, 160, 97, 141, 3, 238, 204, 3, 25, 225, 83, 97, 117, 36, 229, 99, 149, 66, 139, 112, 83, 217, 64, 89, 197, 89, 165, 177, 218, 170, 201, 250, 179, 40, 66, 9, 78, 148, 160, 95, 149, 192, 250, 141, 88, 220, 111, 54, 91, 102, 187, 74, 186, 155, 6, 10, 65, 35, 217, 29, 207, 211, 69, 110, 129, 136, 137, 222, 21, 141, 150, 206, 125, 10, 230, 227, 131, 99, 89, 155, 135, 237, 27, 80, 6, 194, 24, 183, 18, 147, 139, 74, 90, 80, 128, 113, 199, 74, 154, 215, 132, 121, 10, 118, 93, 187, 43, 183, 198, 56, 143, 153, 153, 221, 183, 81, 110, 119, 233, 36, 119, 208, 33, 24, 176, 177, 62, 163, 150, 38, 170, 91, 11, 120, 211, 247, 121, 165, 125, 248, 119, 96, 206, 34, 64, 108, 0, 3, 51, 107, 12, 168, 113, 200, 27, 51, 136, 202, 186, 245, 250, 17, 226, 251, 143, 230, 221, 127, 152, 99, 25, 45, 133, 20, 33, 76, 241, 229, 74, 228, 31, 1, 147, 10, 139, 58, 168, 196, 231, 86, 204, 73, 147, 108, 253, 149, 7, 145, 116, 149, 54, 55, 192, 249, 26, 3, 205, 115, 129, 247, 208, 217, 201, 62, 52, 134, 142, 179, 229, 222, 228, 55, 123, 83, 182, 149, 175, 184, 219, 0, 46, 126, 252, 127, 117, 189, 153, 26, 215, 194, 188, 255, 0, 103, 188, 155, 99, 186, 143, 117, 14, 45, 31, 196, 191, 137, 15, 196, 166, 187, 221, 190, 226, 45, 196, 9, 60, 7, 84, 82, 128, 201, 207, 31, 217, 92, 123, 169, 218, 229, 112, 206, 221, 59, 59, 171, 15, 148, 76, 83, 222, 198, 152, 155, 91, 198, 145, 172, 77, 137, 94, 156, 26, 141, 56, 52, 1, 48, 121, 212, 239, 66, 189, 78, 247, 166, 4, 209, 173, 122, 152, 55, 52, 33, 157, 61, 238, 41, 0, 75, 227, 99, 82, 1, 8, 42, 194, 234, 115, 6, 131, 126, 3, 58, 112, 196, 103, 68, 132, 12, 172, 118, 238, 35, 38, 241, 55, 244, 216, 156, 127, 132, 213, 164, 115, 108, 13, 141, 87, 98, 178, 46, 147, 145, 254, 215, 167, 141, 173, 233, 53, 73, 195, 19, 172, 148, 123, 167, 98, 217, 239, 3, 77, 0, 27, 93, 230, 98, 69, 30, 135, 60, 164, 65, 129, 243, 174, 85, 181, 9, 94, 25, 19, 163, 186, 128, 141, 105, 158, 23, 193, 148, 241, 90, 238, 37, 127, 77, 113, 127, 53, 73, 250, 93, 254, 219, 115, 29, 186, 133, 88, 53, 254, 242, 223, 35, 239, 174, 141, 59, 27, 125, 175, 39, 62, 237, 105, 87, 185, 97, 152, 59, 181, 211, 188, 153, 127, 124, 159, 126, 52, 62, 34, 143, 190, 49, 201, 187, 51, 70, 125, 19, 42, 186, 142, 87, 22, 32, 249, 17, 85, 244, 216, 243, 229, 91, 156, 194, 107, 18, 7, 10, 52, 49, 151, 91, 28, 174, 79, 186, 132, 70, 84, 104, 86, 49, 9, 118, 111, 136, 144, 71, 32, 56, 15, 58, 76, 105, 144, 82, 75, 145, 195, 32, 124, 168, 195, 51, 238, 161, 35, 235, 147, 1, 101, 25, 1, 69, 191, 190, 245, 155, 245, 35, 122, 191, 35, 250, 151, 218, 67, 122, 142, 171, 211, 7, 123, 15, 65, 207, 28, 87, 237, 181, 73, 74, 16, 67, 44, 168, 248, 221, 151, 65, 95, 240, 181, 190, 186, 5, 146, 156, 187, 153, 36, 58, 71, 165, 62, 187, 86, 143, 109, 245, 236, 154, 217, 196, 196, 21, 228, 27, 17, 106, 207, 151, 111, 26, 255, 0, 79, 116, 146, 15, 222, 73, 16, 253, 10, 194, 173, 118, 130, 218, 55, 32, 12, 44, 152, 140, 69, 241, 242, 167, 182, 59, 112, 105, 236, 219, 91, 122, 240, 94, 237, 145, 172, 189, 210, 40, 137, 182, 180, 146, 214, 58, 113, 2, 249, 213, 233, 54, 172, 241, 151, 132, 245, 0, 10, 172, 140, 108, 195, 27, 33, 184, 207, 26, 207, 216, 106, 29, 215, 111, 196, 234, 55, 242, 182, 53, 184, 129, 109, 185, 8, 69, 140, 107, 172, 242, 125, 126, 145, 81, 88, 130, 174, 236, 175, 104, 82, 81, 157, 55, 0, 104, 158, 197, 197, 159, 82, 94, 218, 136, 248, 91, 198, 161, 26, 221, 88, 147, 169, 83, 62, 53, 167, 37, 180, 184, 25, 221, 46, 70, 100, 219, 11, 213, 102, 19, 150, 110, 147, 91, 43, 224, 45, 82, 213, 103, 161, 209, 170, 219, 187, 124, 170, 255, 0, 68, 202, 197, 97, 113, 170, 192, 14, 32, 2, 180, 25, 98, 141, 23, 85, 142, 57, 99, 87, 165, 19, 133, 97, 33, 212, 156, 78, 0, 208, 164, 17, 116, 44, 77, 210, 216, 158, 53, 49, 79, 21, 250, 154, 211, 103, 189, 86, 80, 182, 181, 251, 91, 41, 12, 21, 156, 131, 101, 4, 218, 252, 168, 139, 211, 146, 100, 136, 169, 26, 192, 32, 220, 91, 17, 122, 34, 199, 1, 134, 207, 41, 9, 247, 154, 199, 246, 83, 109, 99, 128, 78, 89, 37, 99, 24, 87, 178, 105, 24, 157, 39, 137, 167, 90, 107, 124, 181, 250, 143, 111, 185, 247, 201, 197, 53, 236, 254, 155, 6, 195, 108, 143, 160, 234, 54, 204, 131, 73, 142, 214, 50, 53, 56, 177, 204, 234, 196, 95, 192, 81, 132, 91, 93, 64, 137, 164, 3, 79, 164, 48, 25, 91, 202, 170, 202, 59, 121, 9, 172, 129, 40, 189, 180, 102, 71, 239, 218, 245, 125, 154, 191, 196, 191, 212, 100, 253, 215, 254, 151, 252, 123, 127, 164, 200, 245, 53, 144, 35, 141, 52, 144, 24, 51, 94, 229, 73, 35, 236, 162, 109, 222, 102, 157, 134, 155, 232, 35, 0, 0, 80, 60, 77, 71, 84, 90, 128, 133, 18, 253, 52, 197, 249, 99, 167, 77, 205, 178, 171, 113, 4, 176, 233, 156, 48, 215, 252, 84, 118, 235, 92, 58, 254, 166, 55, 217, 239, 108, 159, 114, 218, 151, 236, 104, 195, 238, 236, 135, 186, 238, 116, 98, 161, 148, 95, 196, 40, 189, 84, 36, 140, 69, 75, 114, 88, 238, 103, 50, 11, 72, 100, 109, 67, 149, 12, 234, 195, 149, 116, 87, 132, 112, 91, 151, 60, 146, 235, 203, 109, 55, 195, 133, 49, 118, 57, 251, 170, 24, 99, 99, 79, 76, 156, 18, 225, 122, 111, 174, 155, 26, 108, 105, 48, 67, 223, 31, 10, 217, 249, 107, 187, 13, 164, 223, 162, 157, 173, 183, 156, 222, 54, 57, 71, 39, 236, 106, 197, 246, 212, 77, 172, 111, 149, 69, 213, 90, 106, 205, 37, 241, 46, 141, 171, 39, 84, 219, 61, 37, 177, 62, 84, 139, 12, 43, 59, 179, 73, 220, 91, 104, 169, 191, 136, 171, 34, 175, 78, 82, 65, 50, 33, 24, 106, 0, 220, 48, 241, 171, 248, 218, 184, 172, 161, 196, 167, 242, 59, 170, 229, 76, 53, 243, 36, 77, 169, 6, 168, 146, 121, 94, 157, 114, 229, 72, 100, 193, 227, 82, 83, 67, 198, 164, 186, 184, 101, 65, 65, 70, 84, 254, 85, 1, 126, 34, 166, 40, 4, 44, 65, 167, 45, 113, 81, 52, 184, 26, 64, 43, 227, 122, 66, 228, 253, 116, 220, 48, 169, 11, 240, 160, 100, 100, 56, 91, 133, 112, 255, 0, 54, 201, 212, 238, 169, 21, 236, 35, 141, 1, 190, 64, 182, 53, 219, 73, 170, 198, 249, 87, 158, 252, 192, 100, 61, 227, 114, 100, 4, 29, 66, 192, 254, 27, 13, 63, 69, 111, 163, 212, 206, 127, 113, 233, 95, 50, 174, 230, 51, 12, 205, 13, 195, 116, 125, 33, 134, 71, 141, 234, 32, 243, 167, 124, 199, 240, 175, 213, 81, 91, 240, 247, 87, 81, 198, 59, 156, 176, 161, 146, 73, 240, 25, 81, 27, 133, 252, 106, 20, 49, 132, 219, 140, 73, 163, 112, 30, 20, 40, 173, 99, 206, 139, 141, 235, 39, 234, 54, 94, 143, 161, 255, 217 }, false, null, "Rafael Bueno Gonzales", "RAFAELBUENOG2020@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAELskOa5H8ORQ2Fhbk1Te+5pUhgfPB0O+FrlWIGkM526/STwi+7aSrbtYrAQDJZs7dg==", null, false, "24305815", false, "Admin", 10 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5519ba39-e4e0-4537-8d6b-bb3c4bf9efc7", "4c1ca73b-6b47-46d5-932a-52b199aadd22" },
                    { "5f863392-eb62-48bf-8ff0-dd2b3d3146b2", "4c1ca73b-6b47-46d5-932a-52b199aadd22" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Atribuicao_GradeDisciplinaId",
                table: "Atribuicao",
                column: "GradeDisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atribuicao_ProfessorId",
                table: "Atribuicao",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Atribuicao_TurmaId",
                table: "Atribuicao",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilidade_AnoSemIngresso",
                table: "Disponibilidade",
                column: "AnoSemIngresso");

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilidade_ProfessorId",
                table: "Disponibilidade",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_CursoId",
                table: "Grade",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeDisciplinas_DisciplinaId",
                table: "GradeDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeDisciplinas_GradeId",
                table: "GradeDisciplinas",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_AnoSemIngresso",
                table: "Turma",
                column: "AnoSemIngresso");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_GradeId",
                table: "Turma",
                column: "GradeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Atribuicao");

            migrationBuilder.DropTable(
                name: "Disponibilidade");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "GradeDisciplinas");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "disciplina");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "PeriodoLetivo");

            migrationBuilder.DropTable(
                name: "Curso");
        }
    }
}
