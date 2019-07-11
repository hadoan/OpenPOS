using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OpenPOS.Users.Authorization;

namespace OpenPOS.Users
{
    [DependsOn(
        typeof(UsersCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class UsersApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<UsersAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(UsersApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
