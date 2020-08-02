using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoanSample.Domain.Data
{

    public interface ICustomerStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
