using System.Threading.Tasks;
using IceSkool.Configuration.Dto;

namespace IceSkool.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
