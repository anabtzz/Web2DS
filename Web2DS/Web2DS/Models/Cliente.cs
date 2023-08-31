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
        private string Nome { get; set; }

        [Display(Name = "Codigo do Cliente")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        private int Cod { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        private string Endereco { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(11)]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayFormat(DataFormatString = "(XX) XXXXX-XXXX")]
        private string telefone { get; set; }

        [Display(Name = "Email do Cliente")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [RegularExpression(@"\w + ([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Informe email válido")]
        private string email { get; set; }

        [Display(Name = "CPF")]
        [StringLength(11)]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayFormat(DataFormatString = "XXXXXXXXXX-XX")]
        private string cpf { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "0:dd/mm/yyyy")]
        private DateTime nascimento { get; set; }

       
    }
}