using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Nome Completo")]
        [MaxLength(150,ErrorMessage ="O Campo nome pode ter no máximo {0} carácteres!"),MinLength(3,ErrorMessage ="O campo nome deve possuir no mínimo {0} caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(11, ErrorMessage = "O Campo Telefone pode ter no máximo {0} carácteres!"), MinLength(10, ErrorMessage = "O campo nome deve possuir no mínimo {0} caracteres!")]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public ICollection<SistemaUsuario> SistemaUsuarios  {get;set;}
        //public int? CategoriaID { get; set; }
        //public virtual Categoria Categorias { get; set; }

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
