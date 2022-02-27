using System;

namespace NorthwindManager.Dtos
{
  public class OrderDto
  {
    public long Id { get; set; }
    public DateTime? OrderDate { private get; set; }
    public DateTime? RequiredDate { private get; set; }
    public DateTime? ShippedDate { private get; set; }
    public int NrOrderDetails { get; set; }

    //public long OrderDateMillis => OrderDate?.ToJavaScriptMilliseconds() ?? 0;
    //public long RequiredDateMillis => RequiredDate?.ToJavaScriptMilliseconds() ?? 0;
    //public long ShippedDateMillis => ShippedDate?.ToJavaScriptMilliseconds() ?? 0;

  }
}
