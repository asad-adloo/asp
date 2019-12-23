using CRM.Common;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CRM.Application.Invoices.Models
{
    public class InvoiceViewModel
    {
        public string Id { get; set; }
        public string SalerId { get; set; }
        public string CustomerId { get; set; }
        public string RegisterdByUserId { get; set; }
        public string SystemCode { get; set; }
        public string HandiCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public InvoiceStatus Status { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }

        public User Saler { get; set; }
        public User Customer { get; set; }
        public User RegisterByUser { get; set; }
        public IList<InvoiceItem> InvoiceItems { get; protected set; }

    }
}
