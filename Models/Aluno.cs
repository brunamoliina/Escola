using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escola.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column(TypeName = "Date")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public char Sexo { get; set; }

        [Column("Faltas")]
        [Display(Name = "Total Faltas")]
        public int? TotalFaltas { get; set; }

        [Column("TurmaId")]
        [Display(Name = "Id da Turma")]
        public int TurmaId { get; set; }

        internal virtual Turma? Turma { get; }
    }
}
