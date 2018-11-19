using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoneBookProject.MultiTenancy.Dto;

namespace PhoneBookProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
