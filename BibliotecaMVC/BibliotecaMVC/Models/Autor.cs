using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Models
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O campo Nome pode ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        public ICollection<LivroAutor> LivroAutor { get; set; }
    }
}
