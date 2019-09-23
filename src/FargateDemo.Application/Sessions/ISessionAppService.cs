using System.Threading.Tasks;
using Abp.Application.Services;
using FargateDemo.Sessions.Dto;

namespace FargateDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
