using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryPlus.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Description must be included.")]
    public string Description { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}