using AutoMapper;
using CRM.Common;
using CRM.Domain.Entities;
using System;

namespace CRM.Application.Users.Models
{
    public class UserViewModel
    {

        public string Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public UserRoles Role { get; set; }
    }
}
