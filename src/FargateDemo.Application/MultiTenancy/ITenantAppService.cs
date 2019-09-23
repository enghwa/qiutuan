using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FargateDemo.MultiTenancy.Dto;

namespace FargateDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

