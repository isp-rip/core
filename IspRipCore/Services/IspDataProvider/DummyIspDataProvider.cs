using IspRipCore.Models;

namespace IspRipCore.Services.IspDataProvider;

public class DummyIspDataProvider : IIspDataProviderService
{
    private Dictionary<Guid, Isp> _isps = new();
    
    public DummyIspDataProvider()
    {
        _isps[Guid.Parse("62e9f5db-773d-480a-a8f8-3376442caeee")] = new Isp
        {
            Country = "am",
            Id = Guid.Parse("62e9f5db-773d-480a-a8f8-3376442caeee"),
            Name = "Rostelecom"
        };
        
        _isps[Guid.Parse("a098b823-ae75-4370-a45a-33add921abaa")] = new Isp
        {
            Country = "am",
            Id = Guid.Parse("a098b823-ae75-4370-a45a-33add921abaa"),
            Name = "Ucom"
        };
        
        _isps[Guid.Parse("e0c5b11b-2d7d-435b-8760-6ada8e9ebe4a")] = new Isp
        {
            Country = "am",
            Id = Guid.Parse("e0c5b11b-2d7d-435b-8760-6ada8e9ebe4a"),
            Name = "Telecom Armenia"
        };
    }
    
    public async Task<BaseResponse<IEnumerable<Isp>>> GetIsps(string country)
    {
        return new BaseResponse<IEnumerable<Isp>>
        {
            Data = _isps.Values.Where(isp => isp.Country == country),
            Success = true
        };
    }

    public async Task<BaseResponse<Isp>> GetIsp(Guid id)
    {
        if (!_isps.ContainsKey(id))
        {
            return new BaseResponse<Isp>
            {
                Success = false,
                Error = "No ISP found"
            };
        }

        return new BaseResponse<Isp>
        {
            Success = true,
            Data = _isps[id]
        };
    }
}