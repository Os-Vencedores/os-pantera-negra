using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Site_Toters_Sistema.Models
{
    public class toter
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(60, MinimumLength = 6)]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(20, MinimumLength = 4)]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(30)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "(00) 00000-0000")]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}