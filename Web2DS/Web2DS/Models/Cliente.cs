using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Web2DS.Models
{
    public class Cliente
    {
        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        public string Nome { get; set; }

        [Display(Name = "Codigo do Cliente")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public int Cod { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public string Endereco { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(11)]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayFormat(DataFormatString = "(XX) XXXXX-XXXX")]
        public string telefone { get; set; }

        [Display(Name = "Email do Cliente")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [RegularExpression(@"\w + ([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Informe email válido")]
        public string email { get; set; }

        [Display(Name = "CPF")]
        [StringLength(11)]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayFormat(DataFormatString = "XXXXXXXXXX-XX")]
        public string cpf { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "0:dd/mm/yyyy")]
        public DateTime nascimento { get; set; }

       
    }
}