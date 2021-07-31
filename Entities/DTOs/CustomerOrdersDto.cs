using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CustomerOrdersDto
    {
        public string CustomerId { get; set; }
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
    }
}
