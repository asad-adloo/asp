using CRM.Application.Users.Models;
using MediatR;

namespace CRM.Application.Users.Queries
{
    public class GetUserDetailQuery : IRequest<UserViewModel>
    {
        public string Id { get; set; }
    }
}
