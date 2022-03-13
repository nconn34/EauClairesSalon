using System.Collections.Generic;

namespace Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Stylists = new HashSet<Stylist>();
    }

    public int StylistsId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Stylist> Stylists { get; set; }
  }
}