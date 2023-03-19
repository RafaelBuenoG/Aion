using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aion.Models;

[Table("Atribuicao")]
public class Atribuicao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int ProfessorId { get; set; }

    public int GradeDisciplinasId { get; set; }

    public int TurmaId { get; set; }

    public bool Matriz { get; set; }
}
