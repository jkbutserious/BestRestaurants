namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public int CusineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}