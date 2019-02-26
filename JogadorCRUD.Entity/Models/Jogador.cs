using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JogadorCRUD.Entity.Models
{
    public class Jogador
    {
        [Key]
        public int IdJogador { get; set; }

        [Required(ErrorMessage = "Digite o Nome !")]
        [Display(Name = "Nome : ")]        
        [StringLength(20)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite uma data Válida !")]
        [Display(Name = "Nascimento : ", Description = "Selecione uma data !")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Digite o Endereço !")]
        [Display(Name = "Endereço : ")]
        [StringLength(30)]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Digite o CPF !")]
        [Display(Name = "CPF : ")]
        [MinLength(11, ErrorMessage ="CPF deve conter no minimo 13 numeros.")]
        [MaxLength(14, ErrorMessage ="CPF não deve conter mais que 16 caracteres 13 numéricos e 3 pontuações.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Digite a Posição ! ")]
        [Display(Name = "Posição : ")]
        [StringLength(20)]
        public string Posicao { get; set; }

        [Required(ErrorMessage = "Digite o Time !")]
        [Display(Name = "Time : ")]
        [StringLength(20)]
        public string Time { get; set; }

    }
}