using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Application.Users.Commands
{
    public class DeleteUserCommand : IRequest
    {

        public string Id { get; set; }
    }
}
