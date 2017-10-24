using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<SistemaUsuario>()
               .HasKey(bc => new { bc.SistemaID, bc.UsuarioID });

            builder.Entity<SistemaUsuario>()
                .HasOne(bc => bc.Sistemas)
                .WithMany(b => b.SistemaUsuarios)
                .HasForeignKey(bc => bc.SistemaID);

            builder.Entity<SistemaUsuario>()
                .HasOne(bc => bc.Usuarios)
                .WithMany(c => c.SistemaUsuarios)
                .HasForeignKey(bc => bc.UsuarioID);


            //Builder for LivroEmprestimo
            builder.Entity<LivroEmprestimo>()
              .HasKey(bc => new { bc.LivroID, bc.EmprestimoID });

            builder.Entity<LivroEmprestimo>()
                .HasOne(bc => bc.Livros)
                .WithMany(b => b.LivroEmprestimos)
                .HasForeignKey(bc => bc.LivroID);

            builder.Entity<LivroEmprestimo>()
                .HasOne(bc => bc.Emprestimos)
                .WithMany(c => c.LivroEmprestimos)
                .HasForeignKey(bc => bc.EmprestimoID);

            //Builder for Livro Autor
            builder.Entity<LivroAutor>()
               .HasKey(bc => new { bc.LivroID, bc.AutorID });

            builder.Entity<LivroAutor>()
                .HasOne(bc => bc.Livros)
                .WithMany(b => b.LivroAutores)
                .HasForeignKey(bc => bc.LivroID);

            builder.Entity<LivroAutor>()
                .HasOne(bc => bc.Autores)
                .WithMany(c => c.LivroAutores)
                .HasForeignKey(bc => bc.AutorID);

            base.OnModelCreating(builder);
        }

        public DbSet<Livro> Livro { get; set; }
    }
}
