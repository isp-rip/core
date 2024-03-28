using IspRipCore.Models;

namespace IspRipCore.Services.IspStatusProvider;

public class RipeStatusProvider : IIspStatusProviderService
{
    public Task<BaseResponse<IspStatus>> GetStatus(Guid id)
    {
        throw new NotImplementedException();
    }
}