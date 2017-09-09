using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Models
{
    public class LivroEmprestimo
    {
        public int LivroID { get; set; }
        public Livro Livros { get; set; }

        public int EmprestimoID { get; set; }
        public Emprestimo Emprestimos { get; set; }
      
    }
}
