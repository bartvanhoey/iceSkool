using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IceSkool.Authorization;

namespace IceSkool
{
    [DependsOn(
        typeof(IceSkoolCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class IceSkoolApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IceSkoolAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(IceSkoolApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
