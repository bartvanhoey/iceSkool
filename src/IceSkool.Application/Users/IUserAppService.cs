using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IceSkool.Roles.Dto;
using IceSkool.Users.Dto;

namespace IceSkool.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
