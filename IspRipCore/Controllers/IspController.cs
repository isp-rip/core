using IspRipCore.Models;
using IspRipCore.Services.IspDataProvider;
using IspRipCore.Services.IspStatusAggregator;
using Microsoft.AspNetCore.Mvc;

namespace IspRipCore.Controllers;

[Controller]
[Route("/api/isp")]
public class IspController : ControllerBase
{
    private readonly IIspStatusAggregatorService _ispStatusAggregator;
    private readonly IIspDataProviderService _ispDataProvider;

    public IspController(IIspStatusAggregatorService ispStatusAggregator, IIspDataProviderService ispDataProvider)
    {
        _ispStatusAggregator = ispStatusAggregator;
        _ispDataProvider = ispDataProvider;
    }

    [HttpGet("status/{id:guid}")]
    public async Task<BaseResponse<IspStatus>> GetIsp(Guid id) => await _ispStatusAggregator.GetStatus(id);

    [HttpGet("list/{country:length(2)}")]
    public async Task<BaseResponse<IEnumerable<Isp>>> GetIsps(string country) => await _ispDataProvider.GetIsps(country);
}