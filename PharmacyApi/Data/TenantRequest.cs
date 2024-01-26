namespace PharmacyApi.Data
{
    public class TenantRequest
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string _tenantIdKey = "TenantID";

        public TenantRequest(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string TenantID
        {
            get
            {
                var context = _httpContextAccessor.HttpContext;
                if (context.Request.Query.ContainsKey(_tenantIdKey))
                {
                    return context.Request.Query[_tenantIdKey];
                }

                return Guid.NewGuid().ToString();
            }
        }
    }
}
