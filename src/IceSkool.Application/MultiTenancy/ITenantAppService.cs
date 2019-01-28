using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IceSkool.MultiTenancy.Dto;

namespace IceSkool.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

