using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    [Key]
    public int StylistsId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}