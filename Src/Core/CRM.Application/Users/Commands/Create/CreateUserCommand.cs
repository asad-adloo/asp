using CRM.Application.Common.Interfaces;
using CRM.Common;
using CRM.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CRM.Application.Users.Commands
{
    public class CreateUserCommand : IRequest
    {

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public UserRoles Role { get; set; }


        public class Handler : IRequestHandler<CreateUserCommand>
        {
            private readonly IdbContext _context;
            private readonly IMediator _mediator;


            public Handler(IdbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
            {
                var entity = new User
                {
                    Id = Guid.NewGuid(),
                    UserName = request.UserName,
                    Password = request.Password,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Phone = request.Phone,
                    Mobile = request.Mobile,
                    Role = UserRoles.Customer
                };

                _context.User.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
