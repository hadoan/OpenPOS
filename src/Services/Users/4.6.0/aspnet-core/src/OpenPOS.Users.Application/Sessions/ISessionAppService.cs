using System.Threading.Tasks;
using Abp.Application.Services;
using OpenPOS.Users.Sessions.Dto;

namespace OpenPOS.Users.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
