using AuthServer.STS.Identity.Configuration.Intefaces;

namespace AuthServer.STS.Identity.Configuration
{
    public class RegisterConfiguration : IRegisterConfiguration
    {
        public bool Enabled { get; set; } = true;
    }
}
