using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aula02.Models
{
    public class Pessoa
    {
       
        private long id;

       
        private string nome;

        
        private DateTime nascimento;

        
        private decimal? credito;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código chave")]
        public long Id { get => id; set => id = value; }


        [MaxLength(50)]
        [Display(Name = "Nome completo")]
        [Required(ErrorMessage = "Por favor, preencha o campo {0}.")]
        public string Nome { get => nome; set => nome = value; }

        [DataType(DataType.Date)]
        [Display(Name = "Data nascimento")]
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }

        [Column(TypeName = "decimal(8,2)")]
        [Display(Name = "Crédito")]
        public decimal? Credito { get => credito; set => credito = value; }
    }
}
