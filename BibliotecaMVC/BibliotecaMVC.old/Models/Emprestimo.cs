﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Models
{
    public class Emprestimo
    {
        [Key]
        public int EmprestimoID { get; set; }

        public int UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }

        public string DataInicio { get; set; }

        public string DataFim { get; set; }

        public string DataDevolucao { get; set; }

        public ICollection<LivroEmprestimo> LivroEmprestimo { get; set; }


        //public int? UsuarioID { get; set; }
        //public virtual Usuario Usuarios { get; set; }

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
