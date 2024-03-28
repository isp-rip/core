using IspRipCore.Models;

namespace IspRipCore.Services.IspStatusProvider;

public interface IIspStatusProviderService
{
    Task<BaseResponse<IspStatus>> GetStatus(Guid id);
    Task<BaseResponse<IspStatus>> GetStatus(Isp isp) => GetStatus(isp.Id);
}