using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhoneBookProject.Authorization;

namespace PhoneBookProject
{
    [DependsOn(
        typeof(PhoneBookProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PhoneBookProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PhoneBookProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PhoneBookProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
