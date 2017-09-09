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

        //Ctrl + K + C (Comment)
        //Ctrl + K + U (Uncomment)
        //[Required(ErrorMessage = "Campo Obrigatório!")]
        //[DataType(DataType.)]//CreditCard,Currency,Custom,Date,DateTime,Duration,EmailAddress,Html,ImageUrl,MultilineText,Password,PhoneNumber,PostalCode,Text,Time,Upload,Url
        //[Display(Name = "", Description = "")]
        //[DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        //[MaxLength(150, ErrorMessage = "O Campo nome pode ter no máximo {0} carácteres!"), MinLength(3, ErrorMessage = "O campo nome deve possuir no mínimo {0} caracteres!")]
        //[RegularExpression(".+\\@.+\\..+",ErrorMessage ="Informe um e-mail válido!")]
        //public string X { get; set; }
    }
}
