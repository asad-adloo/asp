using CRM.Common;
using FluentNHibernate.Mapping;

namespace CRM.Domain.Entities
{
    public class UserShippingAddress
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual string Address { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Mobile { get; set; }
        public virtual double Longitude { get; set; }
        public virtual double Latitude { get; set; }
        public virtual ActiveAndDeleteStatus Status { get; set; }

    }



    public class UserShippingMap : ClassMap<UserShippingAddress>
    { 
        

    }
}
