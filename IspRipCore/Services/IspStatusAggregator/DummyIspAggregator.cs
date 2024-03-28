using IspRipCore.Models;
using IspRipCore.Services.IspDataProvider;
using IspRipCore.Services.IspStatusProvider;

namespace IspRipCore.Services.IspStatusAggregator;

// TODO: aggregation of multiple IIspStatusProviderService
public class DummyIspAggregator(IIspStatusProviderService ispStatusProvider, IIspDataProviderService ispDataProvider)
    : IIspStatusAggregatorService
{
    public Task<BaseResponse<IspStatus>> GetStatus(Guid id)
    {
        return ispStatusProvider.GetStatus(id);
    }
}