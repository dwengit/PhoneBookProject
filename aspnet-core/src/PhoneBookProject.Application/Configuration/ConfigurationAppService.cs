using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PhoneBookProject.Configuration.Dto;

namespace PhoneBookProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhoneBookProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
