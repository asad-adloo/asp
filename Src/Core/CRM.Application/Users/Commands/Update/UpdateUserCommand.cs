using MediatR;
using Microsoft.EntityFrameworkCore;
using CRM.Application.Common.Exceptions;
using CRM.Application.Common.Interfaces;
using CRM.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;
using CRM.Common;

namespace CRM.Application.Users.Commands
{
    public class UpdateUserCommand: IRequest
    {

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public UserRoles Role { get; set; }

        public class Handler : IRequestHandler<UpdateUserCommend>
        {
            private readonly IdbContext _context;

            public Handler(IdbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateUserCommend request, CancellationToken cancellationToken)
            {
                var entity = await _context.User
                    .SingleOrDefaultAsync(User => User.Id == request.Id, cancellationToken);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(User), request.Id);
                }

                entity.FirstName = request.FirstName;
                entity.LastName = request.LastName;
                entity.Password = request.Password;
                entity.Phone = request.Phone;
                entity.Mobile = request.Mobile;
                
                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
