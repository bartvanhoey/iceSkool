using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using IceSkool.Configuration.Dto;

namespace IceSkool.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : IceSkoolAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
