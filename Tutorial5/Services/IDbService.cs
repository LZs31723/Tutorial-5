using Tutorial_5.DTO;
using Tutorial_5.DTO;

namespace Tutorial_5.Services;

public interface IDbService
{
    Task<IEnumerable<PcGet>> GetPcsAsync();
    Task<IEnumerable<PcComponentDto>> GetPcComponents(int id);
    Task<PcGet> CreatePcAsync(PcCreate dto);
    Task<PcGet> UpdatePcAsync(int id, PcUpdate dto);
    Task<bool> DeletePcAsync(int id);
}