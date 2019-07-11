using System.Threading.Tasks;
using Abp.Application.Services;
using OpenPOS.Users.Authorization.Accounts.Dto;

namespace OpenPOS.Users.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
