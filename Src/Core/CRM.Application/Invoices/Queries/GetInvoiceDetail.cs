using CRM.Application.Invoices.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Application.Invoices.Queries
{
    public class GetInvoiceDetail: IRequest<InvoiceViewModel>
    {
        public string Id { get; set; }
    }
}
