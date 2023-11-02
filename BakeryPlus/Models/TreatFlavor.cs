namespace BakeryPlus.Models
{
  public class TreatFlavor
  {
    public int TreatFlavorId { get; set; }
    public int TreatId { get; set; }
    public Treat treat { get; set; }
    public int FlavorId { get; set; }
    public Flavor flavor { get; set; }
  }
}