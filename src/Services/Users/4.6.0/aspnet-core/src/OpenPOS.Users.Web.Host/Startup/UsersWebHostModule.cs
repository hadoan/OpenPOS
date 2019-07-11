using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OpenPOS.Users.Configuration;

namespace OpenPOS.Users.Web.Host.Startup
{
    [DependsOn(
       typeof(UsersWebCoreModule))]
    public class UsersWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public UsersWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UsersWebHostModule).GetAssembly());
        }
    }
}
