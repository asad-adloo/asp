
using CRM.Domain.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CRM.Application.mapping
{
    class InvoiceMapping : ClassMapping<Invoice>
    {

        public InvoiceMapping()
        {
            Id(x => x.Id, x => x.Generator(Generators.Identity));


            Property(b => b.SalerId, x =>
            {
                x.Length(50);
                x.NotNullable(true);


            });
        }

    }
}
