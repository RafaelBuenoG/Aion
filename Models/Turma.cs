using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aion.Models;

[Table("Turma")]
public class Turma
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Nome { get; set; }

    public int AnoSemIngresso { get; set; }

    [ForeignKey("AnoSemIngresso")]
    public PeriodoLetivo PeriodoLetivo { get; set; }
    
    public int Grade { get; set; }
    
    [ForeignKey("Grade")]
    public Grade Grade { get; set; }
}
