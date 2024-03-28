using IspRipCore.Models;
using IspRipCore.Services.IspStatusAggregator;
using Microsoft.AspNetCore.Mvc;

namespace IspRipCore.Controllers;

[Controller]
[Route("/isp")]
public class IspController : ControllerBase
{
    private readonly IIspStatusAggregatorService _ispStatusAggregator;
    
    public IspController(IIspStatusAggregatorService ispStatusAggregator)
    {
        _ispStatusAggregator = ispStatusAggregator;
    }

    [HttpGet("{id:guid}")]
    public async Task<BaseResponse<Isp>> GetIsp(Guid id) => await _ispStatusAggregator.GetIsp(id);

    [HttpGet("{country:length(2)}")]
    public async Task<BaseResponse<IEnumerable<Isp>>> GetIsps(string country) => await _ispStatusAggregator.GetIsps(country);
}