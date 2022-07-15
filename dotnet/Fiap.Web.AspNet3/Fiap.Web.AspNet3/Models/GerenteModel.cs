using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet3.Models
{
    [Table("Gerente")]
    public class GerenteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("GerenteId")]
        public int? GerenteId { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeGerente { get; set; }

        [Required]
        [StringLength(50)]
        public string Sobrenome { get; set; }
    }
}
