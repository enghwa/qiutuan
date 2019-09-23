using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FargateDemo.Roles.Dto;
using FargateDemo.Users.Dto;

namespace FargateDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
