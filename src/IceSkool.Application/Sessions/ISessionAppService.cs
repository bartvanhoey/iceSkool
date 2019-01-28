using System.Threading.Tasks;
using Abp.Application.Services;
using IceSkool.Sessions.Dto;

namespace IceSkool.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
