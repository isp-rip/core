using IspRipCore.Models;

namespace IspRipCore.Services.IspDataProvider;

public interface IIspDataProviderService
{
    Task<BaseResponse<IEnumerable<Isp>>> GetIsps(string country);
    Task<BaseResponse<Isp>> GetIsp(Guid id);
}