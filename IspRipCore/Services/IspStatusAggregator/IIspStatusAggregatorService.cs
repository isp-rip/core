using IspRipCore.Models;

namespace IspRipCore.Services.IspStatusAggregator;

public interface IIspStatusAggregatorService
{
    Task<BaseResponse<IspStatus>> GetStatus(Guid id);
    Task<BaseResponse<IspStatus>> GetStatus(Isp isp) => GetStatus(isp.Id);
}