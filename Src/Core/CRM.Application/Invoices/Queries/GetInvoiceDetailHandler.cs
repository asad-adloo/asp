using AutoMapper;
using CRM.Application.Common.Exceptions;
using CRM.Application.Common.Interfaces;
using CRM.Application.Invoices.Models;
using CRM.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRM.Application.Invoices.Queries
{
    class GetInvoiceDetailHandler : IRequestHandler<GetInvoiceDetail, InvoiceViewModel>
    {
        private readonly IdbContext _context;
        private readonly IMapper _mapper;


        public GetInvoiceDetailHandler(IdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;                
        }

        public async Task<InvoiceViewModel> Handle(GetInvoiceDetail request, CancellationToken cancellationToken)
        {
            var Entity = await _context.Invoices
                .FindAsync(request.Id);


            if (Entity == null)
            { 
                throw new NotFoundException(nameof(Invoice), request.Id);
            }

            return _mapper.Map<InvoiceViewModel>(Entity);
        }
    }
}
