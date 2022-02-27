using System;
namespace NorthwindManager.Dtos
{
    public class ProductDto
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string CompanyNameSupplier { get; set; }
        public double? Price { get; set; }
    }
}
