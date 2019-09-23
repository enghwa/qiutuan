using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FargateDemo.Configuration;

namespace FargateDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(FargateDemoWebCoreModule))]
    public class FargateDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FargateDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FargateDemoWebHostModule).GetAssembly());
        }
    }
}
