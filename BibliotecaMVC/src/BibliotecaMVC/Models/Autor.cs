using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Models
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "O Campo nome pode ter no máximo {0} carácteres!"), MinLength(3, ErrorMessage = "O campo nome deve possuir no mínimo {0} caracteres!")]
        [Display(Name = "Nome", Description = "Nome do Autor")]
        public string Nome { get; set; }

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
