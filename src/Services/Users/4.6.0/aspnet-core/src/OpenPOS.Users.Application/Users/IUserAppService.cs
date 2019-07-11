using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OpenPOS.Users.Roles.Dto;
using OpenPOS.Users.Users.Dto;

namespace OpenPOS.Users.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
