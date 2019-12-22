using AutoMapper;
using CRM.Application.Common.Exceptions;
using CRM.Application.Common.Interfaces;
using CRM.Application.Users.Models;
using CRM.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRM.Application.Users.Queries
{
    public class GetUserDetailQueryHandeler : IRequestHandler<GetUserDetailQuery, UserViewModel>
    {
        private readonly IdbContext _context;
        private readonly IMapper _mapper;

        public GetUserDetailQueryHandeler(IdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserViewModel> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.User
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            return _mapper.Map<UserViewModel>(entity);
        }

        Task<UserViewModel> IRequestHandler<GetUserDetailQuery, UserViewModel>.Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
