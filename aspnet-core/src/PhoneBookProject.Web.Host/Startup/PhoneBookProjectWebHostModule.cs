using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhoneBookProject.Configuration;

namespace PhoneBookProject.Web.Host.Startup
{
    [DependsOn(
       typeof(PhoneBookProjectWebCoreModule))]
    public class PhoneBookProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhoneBookProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookProjectWebHostModule).GetAssembly());
        }
    }
}
