using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Desaparecidos.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Código da Observação")]

        public int ObservacoesId { get; set; }

        [Column("ObservacoesDescricao")]
        [Display(Name = "Descrição da Observação")]

        public string ObservacoesDescricao { get; set; } = string.Empty;

        [Column("ObservacoesLocal")]
        [Display(Name = "Local do Desaparecimento")]

        public string ObservacoesLocal { get; set; } = string.Empty;

        [Column("ObservacoesData")]
        [Display(Name = "Data do Desaparecimento")]

        public DateTime ObservacoesData { get; set; }

        [ForeignKey("PessoaId")]
        public int PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }

        [ForeignKey("UsuarioId")]

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
