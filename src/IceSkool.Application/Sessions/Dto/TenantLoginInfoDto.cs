using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using IceSkool.MultiTenancy;

namespace IceSkool.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
