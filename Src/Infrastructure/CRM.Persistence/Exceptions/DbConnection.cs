

using Microsoft.Extensions.DependencyInjection;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;

namespace CRM.Persistence.Exceptions
{
    public static class DbConnection
    {
        public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(DbConnection).Assembly.ExportedTypes);
            HbmMapping domainMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

            var configuration = new Configuration();
            configuration.DataBaseIntegration(config =>
            {
                config.Dialect<MsSql2012Dialect>();
                config.ConnectionString = connectionString;
                config.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                config.SchemaAction = SchemaAutoAction.Validate;
                config.LogFormattedSql = true;
                config.LogSqlInConsole = true;
            });
            configuration.AddMapping(domainMapping);

            var sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddScoped<IMapperSession, NHibernateMapperSession>();

            return services;
        }

    }
}
