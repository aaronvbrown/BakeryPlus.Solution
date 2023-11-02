using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryPlus.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Treats must have a description.")]
    public string Description { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}