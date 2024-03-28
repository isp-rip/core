using IspRipCore.Models;

namespace IspRipCore.Services.IspStatusProvider;

public class RipeStatusProvider : IIspStatusProviderService
{
    public async Task<BaseResponse<IspStatus>> GetStatus(Guid id)
    {
        return new BaseResponse<IspStatus>()
        {
            Data = IspStatus.Ok,
            Success = true
        };
    }
}