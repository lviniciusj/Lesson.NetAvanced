using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMVC.Models
{
    public class Livro
    {
        [Key]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Título", Description = "Título do Livro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int Quantidade { get; set; }

        public string Foto { get; set; }

        public ICollection<LivroEmprestimo> LivroEmprestimos { get; set; }
        public ICollection<LivroAutor> LivroAutores { get; set; }
    }
}
