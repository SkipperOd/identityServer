using Microsoft.Extensions.Localization;

namespace AuthServer.Admin.Helpers.Localization
{
    public interface IGenericControllerLocalizer<T> : IStringLocalizer<T>
    {
        
    }
}