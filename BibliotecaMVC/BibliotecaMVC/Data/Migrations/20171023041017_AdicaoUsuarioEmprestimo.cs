using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaMVC.Data.Migrations
{
    public partial class AdicaoUsuarioEmprestimo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_LivroEmprestimo_LivroID",
                table: "LivroEmprestimo");

            migrationBuilder.DropIndex(
                name: "IX_LivroAutor_AutorID",
                table: "LivroAutor");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Emprestimo",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_ApplicationUserId",
                table: "Emprestimo",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_AspNetUsers_ApplicationUserId",
                table: "Emprestimo",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_AspNetUsers_ApplicationUserId",
                table: "Emprestimo");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_Emprestimo_ApplicationUserId",
                table: "Emprestimo");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Emprestimo");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_LivroEmprestimo_LivroID",
                table: "LivroEmprestimo",
                column: "LivroID");

            migrationBuilder.CreateIndex(
                name: "IX_LivroAutor_AutorID",
                table: "LivroAutor",
                column: "AutorID");
        }
    }
}
