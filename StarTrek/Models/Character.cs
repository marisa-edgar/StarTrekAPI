namespace StarTrek.Models
{
  public class Character
  {
    public int CharacterId { get; set; }
    public string Name { get; set; }
    public string Bio { get; set; }
    public int TrekEventId { get; set; }
    public virtual TrekEvent TrekEvent { get; set; }
  }
}