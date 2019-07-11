using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OpenPOS.Users.MultiTenancy.Dto;

namespace OpenPOS.Users.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

