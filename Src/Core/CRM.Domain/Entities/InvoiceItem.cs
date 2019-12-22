using CRM.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Domain.Entities
{
    public class InvoiceItem 

    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int PurchasePrice { get; set; }
        public int ShippingPrice { get; set; }
        public ItemType ShippingPriceType { get; set; }
        public int Discount { get; set; }
        public ItemType DiscountType { get; set; }
        public int Tax { get; set; }
        public ItemType TaxType { get; set; }
        public int Qty { get; set; }


    }
}
