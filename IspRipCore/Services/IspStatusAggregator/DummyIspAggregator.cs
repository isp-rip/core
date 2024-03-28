using IspRipCore.Models;
using IspRipCore.Services.IspDataProvider;
using IspRipCore.Services.IspStatusProvider;

namespace IspRipCore.Services.IspStatusAggregator;

public class DummyIspAggregator : IIspStatusAggregatorService
{
    private readonly IIspStatusProviderService _ispStatusProvider;
    private readonly IIspDataProviderService _ispDataProvider;

    public DummyIspAggregator(IIspStatusProviderService ispStatusProvider, IIspDataProviderService ispDataProvider)
    {
        _ispStatusProvider = ispStatusProvider;
        _ispDataProvider = ispDataProvider;
    }

    public async Task<BaseResponse<IEnumerable<Isp>>> GetIsps(string country)
    {
        var ispsResponse = await _ispDataProvider.GetIsps(country);

        if (!ispsResponse.Success || ispsResponse.Data == null)
        {
            return ispsResponse;
        }

        var ispList = ispsResponse.Data.Select(async isp =>
        {
            var resp = await _ispStatusProvider.GetStatus(isp);
            isp.Status = resp.Data;
            return (resp.Error, isp);
        });

        return null;
    }

    public Task<BaseResponse<Isp>> GetIsp(Guid id)
    {
        return null;
    }
}