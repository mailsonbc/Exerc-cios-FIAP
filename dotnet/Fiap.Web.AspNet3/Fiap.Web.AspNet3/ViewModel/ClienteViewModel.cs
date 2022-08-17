using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Web.AspNet3.ViewModel
{
    public class ClienteViewModel
    {
        [Key]
        [Display(Name = "Id do Cliente")]
        [HiddenInput]
        public int ClienteId { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [MaxLength(70, ErrorMessage = "O tamanho máximo do nome é de 70 caracteres.")]
        [MinLength(2, ErrorMessage = "Digite um nome com mais de 2 caracteres.")]
        public string? Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Digite o e-mail do cliente.")]
        [EmailAddress(ErrorMessage = "Digite o e-mail corretamente.")]
        public string? Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Selecione a data de nascimento.")]
        [DataType(DataType.Date, ErrorMessage = "Data de nascimento inválida.")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Observação")]        
        public string? Observacao { get; set; }

        public int RepresentanteId { get; set; }
       
        public RepresentanteViewModel? Representante { get; set; }
    }
}
