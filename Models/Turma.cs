using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escola.Models
{
    [Table("Turma")]
    public class Turma
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Ativo")]
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        public virtual List<Aluno> Aluno { get; set; }  
    }
}
