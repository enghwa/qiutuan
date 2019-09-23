using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FargateDemo.Configuration.Dto;

namespace FargateDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FargateDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
