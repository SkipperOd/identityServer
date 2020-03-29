using System;
using IdentityServer4.EntityFramework.Interfaces;

namespace AuthServer.Admin.EntityFramework.Identity.Interfaces
{
    [Obsolete("Implement IAdminPersistedGrantDbContext instead.")]
    public interface IAdminPersistedGrantIdentityDbContext : IPersistedGrantDbContext
    {
    }
}
