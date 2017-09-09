using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        [Display(Name = "Descrição", Description = "Descrição da Categoria")]
        [MaxLength(300, ErrorMessage = "O Campo nome pode ter no máximo {0} carácteres!")]
        public string Descricao { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

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
