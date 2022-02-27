namespace NorthwindManager.Dtos
{
  public class OrderDetailsDto
  {
    public long OrderId { get; set; }
    public double UnitPrice { get; set; }
    public long Quantity { get; set; }
    public string ProductName { get; set; }

  }
}
