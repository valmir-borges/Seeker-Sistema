using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Desaparecidos.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("PessoaId")]
        [Display(Name = "Código da Pessoa")]

        public int PessoaId { get; set; }

        [Column("PessoaNome")]
        [Display(Name = "Nome da Pessoa")]

        public string PessoaNome { get; set; } = string.Empty;

        [Column("PessoaRoupa")]
        [Display(Name = "Roupa da Pessoa")]

        public string PessoaRoupa { get;set; } = string.Empty;

        [Column("PessoaCor")]
        [Display(Name = "Cor da Pessoa")]

        public string PessoaCor { get; set; } = string.Empty;

        [Column("PessoaSexo")]
        [Display(Name = "Sexo da Pessoa")]

        public string PessoaSexo { get; set; } = string.Empty;

        [Column("PessoaObservacao")]
        [Display(Name = "Observacao da Pessoa")]

        public string PessoaObservacao { get; set; } = string.Empty;

        [Column("PessoaLocalDesaparecimento")]
        [Display(Name = "Local de desaparecimento da Pessoa")]

        public string PessoaLocalDesaparecimento { get; set; } = string.Empty;

        [Column("PessoaFoto")]
        [Display(Name = "Foto da Pessoa")]

        public string PessoaFoto { get; set; } = string.Empty;

        [Column("PessoaDtDesaparecimento")]
        [Display(Name = "Data de desaparecimento da Pessoa")]

        public DateTime PessoaDtDesaparecimento { get; set; }

        [Column("PessoaDtEncontro")]
        [Display(Name = "Data de encontro da Pessoa")]

        public DateTime? PessoaDtEncontro { get; set; }

        [Column("PessoaStatus")]
        [Display(Name = "Status de encontro da Pessoa")]

        public byte PessoaStatus { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuario")]

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
