using CRM.Common;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;

namespace CRM.Domain.Entities
{
    public class User
    {
        public  Guid Id { get; set; }

        public  string UserName { get; set; }

        public  string Password { get; set; }

        public  string FirstName { get; set; }

        public  string LastName { get; set; }

        public  string Phone { get; set; }

        public  string Mobile { get; set; }

        public  UserRoles Role { get; set; }


        public  IList<UserShippingAddress> ShippingsAddress { get; protected set; } 
        public  IList<Invoice> Invoices{ get; protected set; }

        public User()
        {
            ShippingsAddress = new List<UserShippingAddress>();
            Invoices = new List<Invoice>();

        }
    }
}
