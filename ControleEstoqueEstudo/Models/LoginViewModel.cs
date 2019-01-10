using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstoqueEstudo.Models
{
    public class LoginViewModel
    {

        [Display (Name = "Usuário")]
        [Required]
        public string Usuario { get; set; }
        [Display(Name = "Senha")]
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Display(Name = "Lembre-me")]
        public bool LembrarMe { get; set; }
    }
}