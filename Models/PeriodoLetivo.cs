using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aion.Models;

[Table("PeriodoLetivo")]
public class PeriodoLetivo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime Ano { get; set; }

    public int Semestre { get; set; }
    
}
