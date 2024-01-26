using Microsoft.EntityFrameworkCore;

namespace PharmacyApi.Data
{
    public class PharmacyDbContextFactory : IDbContextFactory<PharmacyDbContext>
    {
        private readonly IDbContextFactory<PharmacyDbContext> _pooledFactory;
        private readonly TenantRequest _tenant;

        public PharmacyDbContextFactory(IDbContextFactory<PharmacyDbContext> pooledFactory, TenantRequest tenant)
        {
            _pooledFactory = pooledFactory;
            _tenant = tenant;
        }

        public PharmacyDbContext CreateDbContext()
        {
            var context = _pooledFactory.CreateDbContext();

            context.TenantID = _tenant.TenantID;

            return context;
        }
    }
}