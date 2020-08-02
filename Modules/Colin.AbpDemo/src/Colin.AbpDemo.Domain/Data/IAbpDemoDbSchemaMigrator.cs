using System.Threading.Tasks;

namespace Colin.AbpDemo.Data
{
    public interface IAbpDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
