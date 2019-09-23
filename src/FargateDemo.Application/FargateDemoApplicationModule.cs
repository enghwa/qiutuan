using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FargateDemo.Authorization;

namespace FargateDemo
{
    [DependsOn(
        typeof(FargateDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FargateDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FargateDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FargateDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
