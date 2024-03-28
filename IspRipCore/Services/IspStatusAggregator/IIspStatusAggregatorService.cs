using IspRipCore.Models;

namespace IspRipCore.Services.IspStatusAggregator;

public interface IIspStatusAggregatorService
{
    Task<BaseResponse<IEnumerable<Isp>>> GetIsps(string country);
    Task<BaseResponse<Isp>> GetIsp(Guid id);
}