using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet3.Models
{
    [Table("Clientes")]
    public class ClienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Clientes")]
        [Display(Name = "Id do Cliente")]
        [HiddenInput]
        public int ClienteId { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [MaxLength(70, ErrorMessage = "O tamanho máximo do nome é de 70 caracteres.")]
        [MinLength(2, ErrorMessage = "Digite um nome com mais de 2 caracteres.")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]        
        [Required(ErrorMessage = "Digite o e-mail do cliente.")]
        [EmailAddress(ErrorMessage = "Digite o e-mail corretamente.")]
        [StringLength(50)]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Selecione a data de nascimento.")]
        [DataType(DataType.Date, ErrorMessage = "Data de nascimento inválida.")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Observação")]
        [Required(ErrorMessage = "Digite a observação.")]
        [StringLength(500)]
        public string Observacao { get; set; }

        public ClienteModel()
        {

        }

        public ClienteModel(int clienteId)
        {
            ClienteId = clienteId;
        }

    }
}
