using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aion.Models;

[Table("GradeDisciplinas")]
public class GradeDisciplinas
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int GradeId { get; set; }

    public int DisciplinaId { get; set; }

    public int Semestre { get; set; }

    public bool TemDivisao { get; set; }

    public string CargaHoraria { get; set; }
}
