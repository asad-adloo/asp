using NHibernate.Mapping.ByCode.Conformist;
using CRM.Domain.Entities;
using NHibernate.Mapping.ByCode;

namespace CRM.Application.mapping
{
    public class UserMapping : ClassMapping<User>
    {
        public UserMapping()
        {

            Id(x => x.Id, x => x.Generator(Generators.Identity));


            Property(b => b.UserName, x =>
            {
                x.Length(50);
                x.NotNullable(true);
            });

            Property(b => b.Password, x =>
            {
                x.Length(50);
                x.NotNullable(true);
            });

            Property(b => b.FirstName, x =>
            {
                x.Length(50);
                x.NotNullable(true);
            });

            Property(b => b.LastName, x =>
            {
                x.Length(50);
                x.NotNullable(true);
            });

            Property(b => b.Phone, x =>
            {
                x.Length(50);
                x.NotNullable(false);
            });


            Property(b => b.Mobile, x =>
            {
                x.Length(50);
                x.NotNullable(false);
            });

            Property(b => b.Role, x =>
            {
                x.Length(50);
                x.NotNullable(true);
            });

            Table("Users");
        }
    }
}
