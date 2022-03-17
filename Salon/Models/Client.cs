namespace Salon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public int StylistsId { get; set; }
    public virtual Stylist Stylist { get; set; }

  }
}