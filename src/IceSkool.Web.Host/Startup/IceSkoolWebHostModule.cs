using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IceSkool.Configuration;

namespace IceSkool.Web.Host.Startup
{
    [DependsOn(
       typeof(IceSkoolWebCoreModule))]
    public class IceSkoolWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IceSkoolWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IceSkoolWebHostModule).GetAssembly());
        }
    }
}
