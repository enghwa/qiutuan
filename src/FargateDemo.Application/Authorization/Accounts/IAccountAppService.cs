using System.Threading.Tasks;
using Abp.Application.Services;
using FargateDemo.Authorization.Accounts.Dto;

namespace FargateDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
