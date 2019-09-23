using System.Threading.Tasks;
using FargateDemo.Configuration.Dto;

namespace FargateDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
