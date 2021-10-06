namespace BlueprintAspergerApi.Models
{
  public class Message
  {
    public long Id { get; set; }
    public string Contenu { get; set; }
    public User Destinataire { get; set; }
  }
}