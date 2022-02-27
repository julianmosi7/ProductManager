using Microsoft.AspNetCore.Mvc;
using NorthwindManager.Dtos;
using NorthwindManager.Services;
using NorthwindManagerDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NorthwindManager.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class NorthwindController : ControllerBase
    {
        private NorthwindService northwindService;

        public NorthwindController(NorthwindService northwindService)
        {
            this.northwindService = northwindService;
        }

        [HttpGet]
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return northwindService.GetCustomers().Select(x => new CustomerDto
            {
                Id = x.CustomerId,
                ContactName = x.ContactName,
                City = x.City
            });
        }

        [HttpGet]
        public IEnumerable<ProductDto> GetProducts()
        {
            return northwindService.GetProducts().Select(x => new ProductDto
            {
                ProductID = x.ProductId,
                ProductName = x.ProductName,
                CategoryName = x.Category.CategoryName,
                CompanyNameSupplier = x.Supplier.CompanyName,
                Price = x.UnitPrice
            });
        }

    }
}
