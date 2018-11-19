using System.Threading.Tasks;
using PhoneBookProject.Configuration.Dto;

namespace PhoneBookProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
