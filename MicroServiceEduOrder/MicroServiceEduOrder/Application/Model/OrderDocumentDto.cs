using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Application.Model
{
    public class OrderDocumentDto
    {
        public OrderDocumentDto()
        {
            Products = new List<ProductLineDto>();
        }
        public string OrderNo { get; set; }
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public List<ProductLineDto> Products { get; set; }
    }
}
