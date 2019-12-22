using CRM.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ReqularPrice { get; set; }
        public double SalePrice { get; set; }
        public string Tax { get; set; }
        public ItemType TaxType { get; set; }
        public string Duty { get; set; }
        public ItemType DutyType { get; set; }
        public string ImageName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } 
        public ProductStatus Status { get; set; }
    }
}
